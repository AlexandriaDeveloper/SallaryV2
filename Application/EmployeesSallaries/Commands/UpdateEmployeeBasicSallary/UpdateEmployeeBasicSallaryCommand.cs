using Application.Common.Messaging;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using MediatR;
namespace Domain.EmployeesSallaries.Commands.UpdateEmployeeBasicSallary
{
    public record UpdateEmployeeBasicSallaryCommand(int Id, int? FinancialYearId, decimal? BasicSallary, decimal? Wazifi, decimal? Mokamel, decimal? Ta3widi) : ICommand<Unit>;

    public class UpdateEmployeeBasicSallaryCommandHandler : ICommandHandler<UpdateEmployeeBasicSallaryCommand, Unit>
    {
        private readonly IUOW _uow;

        public UpdateEmployeeBasicSallaryCommandHandler(IUOW uow)
        {
            _uow = uow;
        }

        public async Task<Result<Unit>> Handle(UpdateEmployeeBasicSallaryCommand request, CancellationToken cancellationToken)
        {
            EmployeeBasicSallary currentEmployeeSallaryData = await _uow.EmployeeBasicSallaryRepository.GetByIdAsync(request.Id);
            if (currentEmployeeSallaryData == null)
            {
                return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            if (request.FinancialYearId.HasValue)
            {
                currentEmployeeSallaryData.FinancialYearId = request.FinancialYearId.Value;
            }
            if (request.BasicSallary.HasValue)
            {
                currentEmployeeSallaryData.BasicSallary = request.BasicSallary.Value;
            }
            if (request.Wazifi.HasValue)
            {
                currentEmployeeSallaryData.Wazifi = request.Wazifi.Value;
            }
            if (request.Mokamel.HasValue)
            {
                currentEmployeeSallaryData.Mokamel = request.Mokamel.Value;
            }
            if (request.Ta3widi.HasValue)
            {
                currentEmployeeSallaryData.Taawidi = request.Ta3widi.Value;
            }
            await _uow.EmployeeBasicSallaryRepository.Update(currentEmployeeSallaryData);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Enums.SaveState.Saved)
            {
                return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            }
            return Result<Unit>.Success(Unit.Value);
        }
    }


}
