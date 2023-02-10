using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using FluentValidation;

namespace Application.EmployeeOrderDetailses.Commands.DeleteEmployeeOrderByOrderDetailsId
{

    public record DeleteEmployeeOrderByOrderDetailsIdCommand(int orderDetailsId) : ICommand;
    public class DeleteEmployeeOrderByOrderDetailsIdCommandHandler : ICommandHandler<DeleteEmployeeOrderByOrderDetailsIdCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public DeleteEmployeeOrderByOrderDetailsIdCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result> Handle(DeleteEmployeeOrderByOrderDetailsIdCommand request, CancellationToken cancellationToken)
        {

            EmployeeOrder empOrderFromDb = await _uow.EmployeeOrderRepository.GetByIdAsync(request.orderDetailsId);
            if (empOrderFromDb == null)
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            await _uow.EmployeeOrderRepository.HardDelete(request.orderDetailsId);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Domain.Enums.SaveState.Saved)
            {
                return Result.Failure(result);
            }
            return Result.Success();
        }

        public class DeleteEmployeeOrderByOrderDetailsIdCommandValidator : AbstractValidator<DeleteEmployeeOrderByOrderDetailsIdCommand>
        {

            public DeleteEmployeeOrderByOrderDetailsIdCommandValidator()
            {
                RuleFor(p => p.orderDetailsId).NotEmpty();
            }
        }
    }
}
