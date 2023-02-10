using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Shared;

namespace Application.Orders.Queries
{
    public record GetAllOrdersQuery() : IQuery<IReadOnlyList<OrderDto>>;
    public class GetAllOrdersQueryHandler : IQueryHandler<GetAllOrdersQuery, IReadOnlyList<OrderDto>>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetAllOrdersQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result<IReadOnlyList<OrderDto>>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            var orders = await _uow.OrderRepository.GetAllAsync();
            if (orders == null)
            {
                return Result<IReadOnlyList<OrderDto>>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }

            var orderToReturn = _mapper.Map<IReadOnlyList<OrderDto>>(orders);
            return Result<IReadOnlyList<OrderDto>>.Success(orderToReturn);
        }
    }
}
