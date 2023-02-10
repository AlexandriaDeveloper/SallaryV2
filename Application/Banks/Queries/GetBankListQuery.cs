using Application.Common.Messaging;
using Application.EmployeeBankAccount;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Application.Banks.Queries
{
    public record GetBankListQuery : IQuery<IReadOnlyList<BankDto>>;
    public class GetBankListQueryHandler : IQueryHandler<GetBankListQuery, IReadOnlyList<BankDto>>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetBankListQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result<IReadOnlyList<BankDto>>> Handle(GetBankListQuery request, CancellationToken cancellationToken)
        {
            IReadOnlyList<Bank> banks = await _uow.BankRepository.GetAllAsync();

            if (banks == null)
            {
                return Result<IReadOnlyList<BankDto>>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }

            IReadOnlyList<BankDto> banksToReturn = _mapper.Map<IReadOnlyList<BankDto>>(banks);
            return Result.Success(banksToReturn);
        }
    }
}
