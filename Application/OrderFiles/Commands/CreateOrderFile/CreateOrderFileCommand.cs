namespace Application.OrderFiles.Commands.CreateOrderFile
{
    //public record CreateOrderFileCommand(OrderFileDto orderFile) : ICommand;
    //public class CreateOrderFileCommandHandler : ICommandHandler<CreateOrderFileCommand>

    //{
    //    private readonly IUOW _uow;
    //    private readonly IAuthService _authService;

    //    public CreateOrderFileCommandHandler(IUOW uow, IAuthService authService)
    //    {
    //        _uow = uow;
    //        _authService = authService;
    //    }

    //    public async Task<Result> Handle(CreateOrderFileCommand request, CancellationToken cancellationToken)
    //    {
    //        await _uow.OrderFileRepository.AddItem(new() {
    //            Details = request.orderFile.Details,
    //        });

    //        var result = await _uow.SaveChangesAsync(cancellationToken);
    //        if (result != SaveState.Saved)
    //        {
    //            return Result.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
    //        }
    //        return Result.Success();
    //    }
    //}
    //public class CreateOrderFileCommandValidator :AbstractValidator<CreateOrderFileCommand>{

    //    public CreateOrderFileCommandValidator()
    //    {
    //        RuleFor(p => p.orderFile.Details).NotEmpty();
    //    }
    //}
}
