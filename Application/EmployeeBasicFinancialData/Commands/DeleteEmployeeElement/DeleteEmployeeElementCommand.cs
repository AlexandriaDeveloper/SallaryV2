using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Shared;
using FluentValidation;

namespace Application.EmployeeBasicFinancialDatas.Commands.DeleteEmployeeElement
{

    public record DeleteEmployeeElementCommand(int id) : ICommand;
    public class DeleteEmployeeElementCommandHandler : ICommandHandler<DeleteEmployeeElementCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public DeleteEmployeeElementCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result> Handle(DeleteEmployeeElementCommand request, CancellationToken cancellationToken)
        {

            if (!await _uow.EmployeeBasicFinancialDataRepository.CheckExistAsync(request.id))
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            await _uow.EmployeeBasicFinancialDataRepository.HardDelete(request.id);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Domain.Enums.SaveState.Saved)
            {
                return Result.Failure(result);
            }

            return Result.Success();

        }

        public class DeleteEmployeeElementCommandValidator : AbstractValidator<DeleteEmployeeElementCommand>
        {
            public DeleteEmployeeElementCommandValidator()
            {
                RuleFor(x => x.id).NotEmpty();
            }
        }
    }
}
