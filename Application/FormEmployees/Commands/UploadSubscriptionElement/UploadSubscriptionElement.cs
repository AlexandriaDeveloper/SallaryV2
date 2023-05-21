using Application.Common.Messaging;
using Application.Services;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using Microsoft.AspNetCore.Http;
using System.Data;

namespace Application.EmployeesForms.Commands.UploadSubscriptionElement
{
    public record UploadSubscriptionElementCommand(UploadSubscriptionElementFileDto file) : ICommand;
    public class UploadSubscriptionElementFileCommandHandler : ICommandHandler<UploadSubscriptionElementCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public UploadSubscriptionElementFileCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result> Handle(UploadSubscriptionElementCommand request, CancellationToken cancellationToken)
        {
            if (request.file == null)
                return await Task.FromResult(Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST));

            var tempPath = CopyFile(request.file.File);

            NPOIService npoi = new NPOIService();
            DataTable dt = npoi.ReadFile(tempPath, "Sheet1");



            foreach (DataRow row in dt.Rows)
            {
                var employee = await _uow.FormEmployeeRepository
                       .GetBySingleOrDefaultAsync(new UploadSubscriptionElementCommandSpecification(request.file.FormId, row.ItemArray[0].ToString()));
                if (employee != null)
                {
                    var canParse = decimal.TryParse(row.ItemArray[2].ToString(), out decimal amount);
                    if (canParse)
                    {
                        Domain.Models.FormEmployee formEmployee = await _uow.FormEmployeeRepository.GetByFormIdAndEmployeeId(request.file.FormId, employee.EmployeeId);

                        await _uow.FormEmployeeSubscriptionRepository.AddItem(new FormEmployeeSubscription()
                        {
                            FormEmployeeId= formEmployee.Id,                                         
                            SubscriptionId = request.file.SubscriptionId,
                            CreditOrDebit = 'd',
                            Amount = amount
                        });
                    }
                }
            }
            var result = await _uow.SaveChangesAsync(cancellationToken);

            if (result != Domain.Enums.SaveState.Saved)
            {

                return Result.Failure(result);
            }

            return Result.Success();
        }
        private static object lockFile = new object();

        private string CopyFile(IFormFile file)
        {
            //var tempPath = Path.GetTempPath() + file.FileName;
            var tempPath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".xlsx";
            if (System.IO.File.Exists(tempPath))
            {
                System.IO.File.Delete(tempPath);
            }
            using (var fileStream = new FileStream(tempPath, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }


            return tempPath;
        }
    }



    public class UploadSubscriptionElementFileDto
    {

        public int FormId { get; set; }
        public int SubscriptionId { get; set; }
        public IFormFile File { get; set; }
    }


    public class UploadSubscriptionElementCommandSpecification : Specification<Domain.Models.FormEmployee>
    {

        public UploadSubscriptionElementCommandSpecification(int formId, string employeeTegaraCode)
        {
            AddInclude(x => x.Employee);
            AddCriteries(x => x.FormId == formId);
            //  AddCriteries(x => x.SubscriptionId == subscriptionId);
            AddCriteries(x => x.Employee.TegaraCode == employeeTegaraCode);
        }
    }
}
