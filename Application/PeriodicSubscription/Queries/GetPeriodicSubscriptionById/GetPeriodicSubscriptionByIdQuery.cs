using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using FluentValidation;

namespace Application.PeriodicSubscriptions.Queries.GetPeriodicSubscriptionById
{

    public record GetPeriodicSubscriptionByIdQuery(int id) : IQuery<FormEmployeeSubscriptionDto>;
    public class GetPeriodicSubscriptionByIdQueryHandler : IQueryHandler<GetPeriodicSubscriptionByIdQuery, FormEmployeeSubscriptionDto>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetPeriodicSubscriptionByIdQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result<FormEmployeeSubscriptionDto>> Handle(GetPeriodicSubscriptionByIdQuery request, CancellationToken cancellationToken)
        {
            FormEmployeeSubscription periodicSubscription = await _uow.FormEmployeeSubscriptionRepository.GetByIdAsync(request.id);
            if (periodicSubscription == null)
            {
                return Result<FormEmployeeSubscriptionDto>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            FormEmployeeSubscriptionDto periodicSubscriptionToReturn = _mapper.Map<FormEmployeeSubscriptionDto>(periodicSubscription);

            return Result<FormEmployeeSubscriptionDto>.Success(periodicSubscriptionToReturn);

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
