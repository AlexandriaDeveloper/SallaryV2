using Application.Common.Messaging;
using AutoMapper;
using Domain.Interfaces;
using Domain.Shared;
using MediatR;

namespace Application.EmployeesForm.Queries.GetCheckedSubscriptionByFormId
{
    public record GetCheckedSubscriptionByFormIdQuery(int formId) : IQuery<List<GetCheckedSubscriptionByFormIdDto>>;
    public class GetCheckedSubscriptionByFormIdQueryHandler : IQueryHandler<GetCheckedSubscriptionByFormIdQuery, List<GetCheckedSubscriptionByFormIdDto>>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetCheckedSubscriptionByFormIdQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        async Task<Result<List<GetCheckedSubscriptionByFormIdDto>>> IRequestHandler<GetCheckedSubscriptionByFormIdQuery, Result<List<GetCheckedSubscriptionByFormIdDto>>>.Handle(GetCheckedSubscriptionByFormIdQuery request, CancellationToken cancellationToken)
        {


            var subscriptions = await _uow.SubscriptionRepository.GetAllAsync();
            List<GetCheckedSubscriptionByFormIdDto> checkedList = new List<GetCheckedSubscriptionByFormIdDto>();
   
            foreach (var subsripe in subscriptions)
            {

                GetCheckedSubscriptionByFormIdDto subInList = new GetCheckedSubscriptionByFormIdDto()
                {
                    SubscriptionName = subsripe.Name,
                    Checked = false,
                    SubscriptionId = subsripe.Id

                };
                if (_uow.FormEmployeeSubscriptionRepository
                    .CheckByExpressionAsync(x => x.FormEmployee.FormId == request.formId && x.SubscriptionId == subsripe.Id))
                {
                    subInList.Checked = true;
                }
                checkedList.Add(subInList);
            }
            return Result.Success(checkedList);
        }
    }
}
