using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.EmployeeSubscriptions;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using FluentValidation;

namespace Application.EmployeeSubscriptions.Queries.GetEmployeeSubscriptionById
{

    public record GetEmployeeSubscriptionByIdQuery(int id) : IQuery<EmployeeToSubscriptionDto>;
    public class GetEmployeeSubscriptionByIdQueryHandler : IQueryHandler<GetEmployeeSubscriptionByIdQuery, EmployeeToSubscriptionDto>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetEmployeeSubscriptionByIdQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result<EmployeeToSubscriptionDto>> Handle(GetEmployeeSubscriptionByIdQuery request, CancellationToken cancellationToken)
        {
            EmployeeSubscription employeeSubscriptionFromDb = await _uow.EmployeeSubscriptionRepository.GetByIdAsync(request.id);
            if (employeeSubscriptionFromDb == null)
            {

                return Result<EmployeeToSubscriptionDto>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            EmployeeToSubscriptionDto modelToReturn = _mapper.Map<EmployeeToSubscriptionDto>(employeeSubscriptionFromDb);

            return Result<EmployeeToSubscriptionDto>.Success(modelToReturn);


        }
    }

    public class GetEmployeeSubscriptionByIdQueryValidator : AbstractValidator<GetEmployeeSubscriptionByIdQuery>
    {
        public GetEmployeeSubscriptionByIdQueryValidator()
        {
            RuleFor(p => p.id).NotEmpty();
        }
    }





}
