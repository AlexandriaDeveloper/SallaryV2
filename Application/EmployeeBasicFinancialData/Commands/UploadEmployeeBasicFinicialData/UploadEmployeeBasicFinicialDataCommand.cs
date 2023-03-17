using Application.Common.Messaging;
using Application.Services;
using AutoMapper;
using Domain.Interfaces;
using Domain.Shared;
using Microsoft.AspNetCore.Http;
using System.Data;

namespace Application.EmployeeBasicFinancialDatas.Commands.UploadEmployeeBasicFinicialData
{
    public record UploadEmployeeBasicFinicialDataCommand(UploadEmployeeBasicFinicialDataParam file) : ICommand;
    public class UploadEmployeeBasicFinicialDataCommandHandler : ICommandHandler<UploadEmployeeBasicFinicialDataCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public UploadEmployeeBasicFinicialDataCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<Result> Handle(UploadEmployeeBasicFinicialDataCommand request, CancellationToken cancellationToken)
        {

            var tempPath = await CopyFile(request.file.File);
            NPOIService npoi = new NPOIService();
            DataTable dt = npoi.ReadFile(tempPath, "Sheet1");
            bool hasError = false;
            foreach (DataRow row in dt.Rows)
            {
                var emp = await _uow.EmployeeRepository.GetByExpressionAsync(x => x.TegaraCode == row.ItemArray[0]);

                if (emp == null)
                {
                    hasError = true;
                    break;
                }

                for (int i = 2; i < row.ItemArray.Length; i++)
                {
                    int finicialId;
                    decimal amount;
                    bool haveAmount = decimal.TryParse(row.ItemArray[i].ToString(), out amount);
                    bool haveFinicialId = int.TryParse(dt.Columns[i].ColumnName.ToString(), out finicialId);

                    if (!haveFinicialId)
                    {

                        hasError = true;
                        break;

                    }

                    if (haveAmount)
                    {
                        Domain.Models.EmployeeBasicFinancialData employeeDataToUpload = new Domain.Models.EmployeeBasicFinancialData();
                        employeeDataToUpload.EmployeeId = emp.Id;
                        employeeDataToUpload.Amount = decimal.Parse(row.ItemArray[i].ToString());
                        employeeDataToUpload.FinancialDataTypesId = int.Parse(dt.Columns[i].ColumnName.ToString());
                        await _uow.EmployeeBasicFinancialDataRepository.AddItem(employeeDataToUpload);
                    }

                }


            }

            if (hasError)
            {
                return Result.Failure(new Error("500", "حدث خطأ ما "));
            }
            var result = await _uow.SaveChangesAsync(cancellationToken);

            if (result != Domain.Enums.SaveState.Saved)
            {
                return Result.Failure(result);
            }

            return Result.Success();
        }

        private async Task<string> CopyFile(IFormFile file)
        {
            var tempPath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".xlsx";
            //var tempPath = Path.GetTempPath() + file.FileName;
            if (System.IO.File.Exists(tempPath))
            {
                System.IO.File.Delete(tempPath);
            }
            using (var fileStream = new FileStream(tempPath, FileMode.Create))
            {

                await file.CopyToAsync(fileStream);
            }
            return tempPath;
        }
    }

    public class UploadEmployeeBasicFinicialDataParam
    {
        public IFormFile File { get; set; }
    }
}
