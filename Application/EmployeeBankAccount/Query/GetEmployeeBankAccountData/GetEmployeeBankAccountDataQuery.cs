using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Application.EmployeeBankAccount.Query.GetEmployeeBankAccountData
{

    public record GetEmployeeBankAccountDataQuery(int employeeBankId) : IQuery<EmployeeBankAccontDataDto>;
    public class GetEmployeeBankAccountDataQueryHandler : IQueryHandler<GetEmployeeBankAccountDataQuery, EmployeeBankAccontDataDto>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetEmployeeBankAccountDataQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result<EmployeeBankAccontDataDto>> Handle(GetEmployeeBankAccountDataQuery request, CancellationToken cancellationToken)
        {
            GetEmployeeBankAccountDataQuerySpecification spec = new GetEmployeeBankAccountDataQuerySpecification(request.employeeBankId);
            EmployeeBank empBank = await _uow.EmployeeBankRepository.GetBySingleOrDefaultAsync(spec);
            if (empBank == null)
            {

                return Result<EmployeeBankAccontDataDto>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            EmployeeBankAccontDataDto employeeBankAcontToReturn = _mapper.Map<EmployeeBankAccontDataDto>(empBank);



            return Result<EmployeeBankAccontDataDto>.Success(employeeBankAcontToReturn);
        }
    }

    public class GetEmployeeBankAccountDataQuerySpecification : Specification<EmployeeBank>
    {

        public GetEmployeeBankAccountDataQuerySpecification(int employeeBankId)
        {
            AddCriteries(x => x.Id == employeeBankId);
            AddInclude(x => x.Branche);
            AddInclude(x => x.Branche.Bank);

        }
    }


    public class EmployeeBankAccontDataDto
    {

        public int? Id { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string AccountNumber { get; set; }
    }
}
