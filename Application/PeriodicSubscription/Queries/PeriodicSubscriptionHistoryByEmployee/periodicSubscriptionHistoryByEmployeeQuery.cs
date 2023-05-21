using Application.Common.Messaging;
using AutoMapper;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Application.PeriodicSubscriptions.Queries.PeriodicSubscriptionHistoryByEmployee
{
    public record PeriodicSubscriptionHistoryByEmployeeQuery(int subscriptionId, int employeeId) : IQuery<List<PeriodicSubscriptionHistoryDto>>;
    public class PeriodicSubscriptionHistoryByEmployeeQueryHandler : IQueryHandler<PeriodicSubscriptionHistoryByEmployeeQuery, List<PeriodicSubscriptionHistoryDto>>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public PeriodicSubscriptionHistoryByEmployeeQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<Result<List<PeriodicSubscriptionHistoryDto>>> Handle(PeriodicSubscriptionHistoryByEmployeeQuery request, CancellationToken cancellationToken)
        {

            var specification = new PeriodicSubscriptionHistoryByEmployeeQuerySpecification(request.subscriptionId, request.employeeId);
            List<FormEmployeeSubscription> periodicSubscriptionsHistoryFromDb = _uow.FormEmployeeSubscriptionRepository.GetAllBySpecAsync(specification).Result.Data;

            List<PeriodicSubscriptionHistoryDto> fullHistory = new List<PeriodicSubscriptionHistoryDto>();

            foreach (var item in periodicSubscriptionsHistoryFromDb.GroupBy(x => x.FormEmployee.FormId))
            {
                PeriodicSubscriptionHistoryDto history = new PeriodicSubscriptionHistoryDto();

                history.FormId = item.Key;
                history.FormName = _uow.FormRepository.GetByIdAsync(item.Key).Result.Details;
                if (history.CreditOrDebit == null)
                {
                    history.CreditOrDebit = new List<PeriodicSubscriptionHistoryDto.PeriodicSubscriptionHistoryDataDto>();
                }
                foreach (var creditOrDebit in item)
                {

                    var credit = new PeriodicSubscriptionHistoryDto.PeriodicSubscriptionHistoryDataDto();

                    credit.Id = creditOrDebit.Id;
                    if (creditOrDebit.CreditOrDebit == 'c')
                    {
                        credit.Credit = creditOrDebit.Amount;
                    }
                    if (creditOrDebit.CreditOrDebit == 'd')
                    {
                        credit.Debit = creditOrDebit.Amount;
                    }
                    history.CreditOrDebit.Add(credit);
                }

                fullHistory.Add(history);
            }


            return Result<List<PeriodicSubscriptionHistoryDto>>.Success(fullHistory);
        }
    }

    public class PeriodicSubscriptionHistoryByEmployeeQuerySpecification : Specification<FormEmployeeSubscription>
    {
        public PeriodicSubscriptionHistoryByEmployeeQuerySpecification(int subscriptionId, int employeeId)
        {
            //AddInclude(x => x.Subscription);
           AddInclude(x => x.FormEmployee);
            AddCriteries(x => x.SubscriptionId == subscriptionId);
            AddCriteries(x => x.FormEmployee.EmployeeId == employeeId);
        }
    }

    public class PeriodicSubscriptionHistoryDto
    {
        public int? FormId { get; set; }
        public string FormName { get; set; }

        public List<PeriodicSubscriptionHistoryDataDto> CreditOrDebit { get; set; }
        public decimal Net { get => CreditOrDebit.Sum(x => x.Credit) - CreditOrDebit.Sum(x => x.Debit); }



        public class PeriodicSubscriptionHistoryDataDto
        {
            public int Id { get; set; }
            public decimal Credit { get; set; }
            public decimal Debit { get; set; }

        }

    }
}
