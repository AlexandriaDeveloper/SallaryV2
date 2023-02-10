using Application.Common.Messaging;
using Application.EmployeeBankAccount;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Application.BankBranches.Queries
{
    public record GetBankBranchesListQuery(int bankId) : IQuery<IReadOnlyList<BrancheDto>>;
    public class GetBankBranchesListQueryHandler : IQueryHandler<GetBankBranchesListQuery, IReadOnlyList<BrancheDto>>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetBankBranchesListQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<Result<IReadOnlyList<BrancheDto>>> Handle(GetBankBranchesListQuery request, CancellationToken cancellationToken)
        {
            IReadOnlyList<Branch> branchesFromDb = await _uow.BranchRepository.GetAllByExpressionAsync(x => x.BankId == request.bankId && x.DeletedDate == null);
            if (branchesFromDb == null)
            {
                return Result<IReadOnlyList<BrancheDto>>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }

            IReadOnlyList<BrancheDto> branchesToReturn = _mapper.Map<IReadOnlyList<BrancheDto>>(branchesFromDb);
            return Result.Success(branchesToReturn);
        }
    }
}
