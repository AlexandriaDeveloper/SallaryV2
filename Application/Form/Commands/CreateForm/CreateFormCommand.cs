using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Shared;

namespace Application.Form.Commands.CreateForm
{
    public record CreateFormCommand(FormDto form) : ICommand;

    public class CreateFormCommandHandler : ICommandHandler<CreateFormCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public CreateFormCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result> Handle(CreateFormCommand request, CancellationToken cancellationToken)
        {
            Domain.Models.Form formToDb = _mapper.Map<Domain.Models.Form>(request.form);

            await _uow.FormRepository.AddItem(formToDb);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Domain.Enums.SaveState.Saved)
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            }
            return Result.Success();
        }
    }
}
