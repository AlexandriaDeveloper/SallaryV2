using Application.Common.Messaging;
using Application.Services;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using Microsoft.AspNetCore.Http;
using System.Data;

namespace Application.Employees.Commands.UploadEmployeesFile;

public record UploadEmployeeFileCommand(IFormFile file, int financialYearId) : ICommand;

public class UploadEmployeeFileCommandHandler : ICommandHandler<UploadEmployeeFileCommand>
{
    private readonly IUOW _uow;
    private readonly IMapper _mapper;
    private readonly IAuthService _authService;

    public UploadEmployeeFileCommandHandler(IUOW uow, IMapper mapper, IAuthService authService)
    {
        _uow = uow;
        _mapper = mapper;
        _authService = authService;
    }
    public async Task<Result> Handle(UploadEmployeeFileCommand request, CancellationToken cancellationToken)
    {
        if (request.file == null)
            return await Task.FromResult(Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST));
        var tempPath = await CopyFile(request.file);
        NPOIService npoi = new NPOIService();
        DataTable dt = npoi.ReadFile(tempPath, "Sheet1");

        foreach (DataRow employee in dt.Rows)
        {
            var empExist = _uow.EmployeeRepository.CheckByExpressionAsync(x => x.NationalId == employee.ItemArray[5]);
            if (!empExist)
            {
                Employee employeeToDb = new Employee();

                employeeToDb.TabCode = employee.ItemArray[0].ToString();
                employeeToDb.TegaraCode = employee.ItemArray[1].ToString();
                employeeToDb.Section = employee.ItemArray[3].ToString();
                employeeToDb.Name = employee.ItemArray[4].ToString();
                employeeToDb.NationalId = employee.ItemArray[5].ToString();
                employeeToDb.CollageName = "كلية الطب";

                employeeToDb.EmployeeGrades = new List<EmployeeGrade>();
                employeeToDb.EmployeeGrades.Add(new EmployeeGrade()
                {
                    GradeId = int.Parse(employee.ItemArray[6].ToString()),
                    CreatedBy = _authService.GetCurrentLoggedInUser(),
                    CreatedDate = DateTime.Now,
                    StartFrom = DateTime.Now,
                });
                //employeeToDb.EmployeeBasicSallaries = new List<EmployeeBasicSallary>();
                //employeeToDb.EmployeeBasicSallaries.Add(new EmployeeBasicSallary()
                //{
                //    FinancialYearId = request.financialYearId,
                //    BasicSallary = Math.Round(decimal.Parse(employee.ItemArray[7].ToString()), 2),
                //    Wazifi = Math.Round(decimal.Parse(employee.ItemArray[8].ToString()), 2),
                //    Mokamel = Math.Round(decimal.Parse(employee.ItemArray[9].ToString()), 2),
                //    Taawidi = Math.Round(decimal.Parse(employee.ItemArray[10].ToString()), 2),
                //    CreatedBy = _authService.GetCurrentLoggedInUser(),
                //    CreatedDate = DateTime.Now,
                //});

                await _uow.EmployeeRepository.AddItem(employeeToDb);
            }
        }
        var result = await _uow.SaveChangesAsync(cancellationToken);

        return await Task.FromResult(Result.Success());
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


