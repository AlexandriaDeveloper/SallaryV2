using Application.Common.Messaging;
using AutoMapper;
using Domain.Enums;
using Domain.Interfaces;
using Domain.Shared;

namespace Application.Subscriptions.Commands.AddSubscription
{

    public record AddSubscriptionCommand(SubscriptionDto Subscription) : ICommand;
    public class AddSubscriptionCommandHandler : ICommandHandler<AddSubscriptionCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public AddSubscriptionCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result> Handle(AddSubscriptionCommand request, CancellationToken cancellationToken)
        {
            var entityToDb = _mapper.Map<Domain.Models.Subscription>(request.Subscription);
            await _uow.SubscriptionRepository.AddItem(entityToDb);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != SaveState.Saved)
            {
                return Result.Failure(result);
            }
            return Result.Success();
        }
    }
}
