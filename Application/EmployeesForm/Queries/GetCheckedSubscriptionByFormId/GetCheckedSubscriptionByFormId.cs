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
            //get all subscriptions

            //check if subscription > 0 in specific file 

            var subsriptions = await _uow.SubscriptionRepository.GetAllAsync();
            List<GetCheckedSubscriptionByFormIdDto> checkedList = new List<GetCheckedSubscriptionByFormIdDto>();
            // var employeeForm = await _uow.PeriodicSubscriptionRepository.GetByAsync(x => x.FormId== request.formId);
            //if (employeeForm == null)
            //{
            //    return Result<List<GetCheckedSubscriptionByFormIdDto>>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            //}
            foreach (var subsripe in subsriptions)
            {

                GetCheckedSubscriptionByFormIdDto subInList = new GetCheckedSubscriptionByFormIdDto()
                {
                    SubscriptionName = subsripe.Name,
                    Checked = false,
                    SubscriptionId = subsripe.Id

                };
                if (_uow.PeriodicSubscriptionRepository.CheckByExpressionAsync(x => x.FormId == request.formId && x.SubscriptionId == subsripe.Id))
                {
                    subInList.Checked = true;
                }
                checkedList.Add(subInList);
            }
            return Result.Success(checkedList);
        }
    }
}
