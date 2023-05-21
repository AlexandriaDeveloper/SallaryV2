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

public record UploadEmployeeFileCommand(UploadEmployeesFileParam file) : ICommand;

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
        var tempPath = await CopyFile(request.file.Form);
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
                employeeToDb.CollageName = Constant.Model.CollagesName.TAB;
                employeeToDb.QanonId = request.file.QanonId;
                employeeToDb.EmployeeBankId = null;

                employeeToDb.EmployeeGrades = new List<EmployeeGrade>();
                employeeToDb.EmployeeGrades.Add(new EmployeeGrade()
                {
                    GradeId = int.Parse(employee.ItemArray[6].ToString()),
                    CreatedBy = _authService.GetCurrentLoggedInUser(),
                    CreatedDate = DateTime.Now,
                    StartFrom = DateTime.Now,
                });
                await _uow.EmployeeRepository.AddItem(employeeToDb);
            }
        }
        var result = await _uow.SaveChangesAsync(cancellationToken);

        if(result != Domain.Enums.SaveState.Saved)
        {

            return Result.Failure(result);
        }

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

public class UploadEmployeesFileParam {
    public int QanonId { get; set; }
    public IFormFile Form { get; set; }
}


