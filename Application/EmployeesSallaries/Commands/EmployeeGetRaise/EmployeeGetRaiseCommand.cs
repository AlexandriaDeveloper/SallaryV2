using Application.Common.Messaging;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Domain.EmployeesSallaries.Commands.EmployeeGetRaise
{
    public record EmployeeGetRaisedCommand(
             int employeeId,
             int newFinancialYear,
            decimal? wazifiPercentage,
            decimal? wazifiAmount,
            decimal? wazifiMinAmount,
            decimal? wazifiMaxAmount,
            decimal? mokamelPercentage,
            decimal? mokamelAmount,
            decimal? mokamelMinAmount,
            decimal? mokamelMaxAmount

        ) : ICommand<EmployeeBasicSallary>;
    public class EmployeeGetRaisedCommandHandler : ICommandHandler<EmployeeGetRaisedCommand, EmployeeBasicSallary>
    {
        private readonly IUOW _uow;

        public EmployeeGetRaisedCommandHandler(IUOW uow)
        {
            _uow = uow;
        }

        public async Task<Result<EmployeeBasicSallary>> Handle(EmployeeGetRaisedCommand request, CancellationToken cancellationToken)
        {


            var result = await _uow.EmployeeBasicSallaryRepository.EmployeeGetRaise(
                request.employeeId,
                 request.newFinancialYear,
                 request.wazifiPercentage,
                 request.wazifiAmount,
                 request.wazifiMinAmount,
                 request.wazifiMaxAmount,
                 request.mokamelPercentage,
                 request.mokamelAmount,
                 request.mokamelMinAmount,
                 request.mokamelMaxAmount);


            await _uow.EmployeeBasicSallaryRepository.AddItem(result);
            var saveResult = await _uow.SaveChangesAsync(cancellationToken);
            if (saveResult != Enums.SaveState.Saved)
            {

                return Result<EmployeeBasicSallary>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            }

            if (result == null)
            {
                return Result<EmployeeBasicSallary>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            return Result<EmployeeBasicSallary>.Success(result);
        }
    }
}
