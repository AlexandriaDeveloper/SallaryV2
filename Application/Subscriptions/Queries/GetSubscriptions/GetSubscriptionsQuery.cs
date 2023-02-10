using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Application.Subscriptions.Queries.GetSubscriptions
{
    public record GetSubscriptionsQuery : IQuery<IReadOnlyList<SubscriptionDto>>;
    public class GetSubscriptionsQueryHandler : IQueryHandler<GetSubscriptionsQuery, IReadOnlyList<SubscriptionDto>>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetSubscriptionsQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<Result<IReadOnlyList<SubscriptionDto>>> Handle(GetSubscriptionsQuery request, CancellationToken cancellationToken)
        {
            IReadOnlyList<Subscription> subscriptionsFromDb = await _uow.SubscriptionRepository.GetAllAsync();
            if (subscriptionsFromDb == null)
            {
                return Result<IReadOnlyList<SubscriptionDto>>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            IReadOnlyList<SubscriptionDto> subscriptions = _mapper.Map<IReadOnlyList<SubscriptionDto>>(subscriptionsFromDb);

            return Result.Success(subscriptions);
        }
    }
}
