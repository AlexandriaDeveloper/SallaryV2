using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using FluentValidation;

namespace Application.EmployeeSubscriptions.Commands.DeleteEmployeeFromSubscription
{
    public record DeleteEmployeeFromSubscriptionCommand(int id) : ICommand;
    public class DeleteEmployeeFromSubscriptionHandler : ICommandHandler<DeleteEmployeeFromSubscriptionCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public DeleteEmployeeFromSubscriptionHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result> Handle(DeleteEmployeeFromSubscriptionCommand request, CancellationToken cancellationToken)
        {
            EmployeeSubscription employeeSubscriptionFromDb = await _uow.EmployeeSubscriptionRepository.GetByIdAsync(request.id);
            if (employeeSubscriptionFromDb == null)
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            await _uow.EmployeeSubscriptionRepository.HardDelete(employeeSubscriptionFromDb.Id);
            var result = await _uow.SaveChangesAsync(cancellationToken); ;
            if (result != Domain.Enums.SaveState.Saved)
            {

                return Result.Failure(result);
            }

            return Result.Success();
        }
    }

    public class DeleteEmployeeFromSubscriptionCommandValidator : AbstractValidator<DeleteEmployeeFromSubscriptionCommand>
    {

        public DeleteEmployeeFromSubscriptionCommandValidator()
        {

            RuleFor(p => p.id).NotEmpty();
        }
    }
}
