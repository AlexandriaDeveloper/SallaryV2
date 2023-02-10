using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using FluentValidation;

namespace Application.PeriodicSubscriptions.Queries.GetPeriodicSubscriptionById
{

    public record GetPeriodicSubscriptionByIdQuery(int id) : IQuery<PeriodicSubscriptionDto>;
    public class GetPeriodicSubscriptionByIdQueryHandler : IQueryHandler<GetPeriodicSubscriptionByIdQuery, PeriodicSubscriptionDto>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetPeriodicSubscriptionByIdQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result<PeriodicSubscriptionDto>> Handle(GetPeriodicSubscriptionByIdQuery request, CancellationToken cancellationToken)
        {
            PeriodicSubscription periodicSubscription = await _uow.PeriodicSubscriptionRepository.GetByIdAsync(request.id);
            if (periodicSubscription == null)
            {
                return Result<PeriodicSubscriptionDto>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            PeriodicSubscriptionDto periodicSubscriptionToReturn = _mapper.Map<PeriodicSubscriptionDto>(periodicSubscription);

            return Result<PeriodicSubscriptionDto>.Success(periodicSubscriptionToReturn);

        }
    }

    public class GetPeriodicSubscriptionByIdQueryValidator : AbstractValidator<GetPeriodicSubscriptionByIdQuery>
    {
        public GetPeriodicSubscriptionByIdQueryValidator()
        {
            RuleFor(P => P.id).NotNull().NotEmpty();
        }
    }
}
