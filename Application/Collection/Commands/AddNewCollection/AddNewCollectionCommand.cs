using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Shared;
using FluentValidation;

namespace Application.Collections.Commands
{
    public record AddNewCollectionCommand(CollectionDto collection) : ICommand;

    public class AddNewCollectionCommandHandler : ICommandHandler<AddNewCollectionCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public AddNewCollectionCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result> Handle(AddNewCollectionCommand request, CancellationToken cancellationToken)
        {
            var collectionToDb = _mapper.Map<Domain.Models.Collection>(request.collection);
            await _uow.CollectionRepository.AddItem(collectionToDb);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Domain.Enums.SaveState.Saved)
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            }
            return Result.Success();
        }
    }
    public class AddNewCollectionCommandValidator : AbstractValidator<AddNewCollectionCommand>
    {

        public AddNewCollectionCommandValidator()
        {
            RuleFor(x => x.collection.Name).NotEmpty().MaximumLength(150);
        }
    }
}
