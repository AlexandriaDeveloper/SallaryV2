using Application.Common.Messaging;
using AutoMapper;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Application.EmployeeSubscriptions.Queries.GetEmployeeSubscriptionByEmployeeId
{
    public record GetEmployeeSubscriptionBalanceByEmployeeIdQuery(int employeeId) : IQuery<List<EmployeeSubscriptionBalanceDto>>;
    public class GetEmployeeSubscriptionByEmployeeIdQueryHandler : IQueryHandler<GetEmployeeSubscriptionBalanceByEmployeeIdQuery, List<EmployeeSubscriptionBalanceDto>>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetEmployeeSubscriptionByEmployeeIdQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<Result<List<EmployeeSubscriptionBalanceDto>>> Handle(GetEmployeeSubscriptionBalanceByEmployeeIdQuery request, CancellationToken cancellationToken)
        {
            //var spec = new GetEmployeeSubscriptionByEmployeeIdQuerySpecification(request.employeeId);
            // var employeeSubscription=  await _uow.EmployeeSubscriptionRepository.GetAllBySpecAsync(spec );
            var spec = new GetEmployeePeriodicSubscriptionByEmployeeIdQuerySpecification(request.employeeId);
            var employeeSubscription = await _uow.PeriodicSubscriptionRepository.GetAllBySpecAsync(spec);


            List<EmployeeSubscriptionBalanceDto> employeesSubs = new List<EmployeeSubscriptionBalanceDto>();
            foreach (var empSub in employeeSubscription.Data.GroupBy(t => t.SubscriptionId))
            {
                EmployeeSubscriptionBalanceDto empToReturn = new EmployeeSubscriptionBalanceDto();
                //empToReturn.EmployeeSubscriptionId = empSub.Key;
                empToReturn.SubscriptionId = empSub.Key;
                empToReturn.SubscriptionName = _uow.SubscriptionRepository.GetByIdAsync(empSub.Key).Result.Name;

                foreach (var employeeSubData in empSub)
                {
                    if (employeeSubData.CreditOrDebit == 'c')
                    {
                        empToReturn.Credit += employeeSubData.Amount;


                    }
                    if (employeeSubData.CreditOrDebit == 'd')
                    {
                        empToReturn.Debit += employeeSubData.Amount;
                    }
                    //    empToReturn.Net += employeeSubData.Employee.PeriodicSubscriptions.Where(x => x.CreditOrDebit == 'c' && x.SubscriptionId == employeeSubData.SubscriptionId).Sum(t => t.Amount)
                    //- employeeSubData.Employee.PeriodicSubscriptions.Where(x => x.CreditOrDebit == 'd' && x.SubscriptionId == employeeSubData.SubscriptionId).Sum(t => t.Amount);

                    //    employeesSubs.Add(new EmployeeSubscriptionBalanceDto()
                    //    {

                    //        Credit = employeeSubData.Employee.PeriodicSubscriptions.Where(x => x.CreditOrDebit == 'c' && x.SubscriptionId == employeeSubData.SubscriptionId).Sum(t => t.Amount),
                    //        Debit = employeeSubData.Employee.PeriodicSubscriptions.Where(x => x.CreditOrDebit == 'd' && x.SubscriptionId == employeeSubData.SubscriptionId).Sum(t => t.Amount),
                    //        Net = employeeSubData.Employee.PeriodicSubscriptions.Where(x => x.CreditOrDebit == 'c' && x.SubscriptionId == employeeSubData.SubscriptionId).Sum(t => t.Amount)
                    //- employeeSubData.Employee.PeriodicSubscriptions.Where(x => x.CreditOrDebit == 'd' && x.SubscriptionId == employeeSubData.SubscriptionId).Sum(t => t.Amount),
                    //        EmployeeSubscriptionId = employeeSubData.Id,
                    //        SubscriptionId = employeeSubData.SubscriptionId,
                    //        SubscriptionName = employeeSubData.Subscription.Name,

                    //    });

                }

                employeesSubs.Add(empToReturn);


            }




            return Result<List<EmployeeSubscriptionBalanceDto>>.Success(employeesSubs);
        }
    }
}

public class GetEmployeeSubscriptionByEmployeeIdQuerySpecification : Specification<EmployeeSubscription>
{

    public GetEmployeeSubscriptionByEmployeeIdQuerySpecification(int employeeId)
    {
        AddInclude(x => x.Employee);
        AddInclude(x => x.Employee.PeriodicSubscriptions);
        AddInclude(x => x.Subscription);
        AddCriteries(x => x.EmployeeId.Equals(employeeId));
    }

}
public class GetEmployeePeriodicSubscriptionByEmployeeIdQuerySpecification : Specification<PeriodicSubscription>
{

    public GetEmployeePeriodicSubscriptionByEmployeeIdQuerySpecification(int employeeId)
    {
        AddInclude(x => x.Employee);
        AddInclude(x => x.Employee.EmployeeSubscriptions);
        AddInclude(x => x.Subscription);
        AddCriteries(x => x.EmployeeId.Equals(employeeId));
    }

}


public class EmployeeSubscriptionBalanceDto
{

    public int SubscriptionId { get; set; }
    public int EmployeeSubscriptionId { get; set; }
    public string SubscriptionName { get; set; }
    public decimal Credit { get; set; }
    public decimal Debit { get; set; }
    public decimal Net { get => Credit - Debit; }
}
