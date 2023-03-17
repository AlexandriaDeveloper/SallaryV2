using Application.Common.Messaging;
using AutoMapper;
using Domain.Interfaces;
using Domain.Shared;

namespace Application.EmployeeBasicFinancialDatas.Commands.AddEmployeeWazifiElements
{

    public record AddEmployeeElementsCommand(EmployeeBasicFinancialDataDtos[] FinicialDataDto) : ICommand;
    public class AddEmployeeElementsCommandHandler : ICommandHandler<AddEmployeeElementsCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public AddEmployeeElementsCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result> Handle(AddEmployeeElementsCommand request, CancellationToken cancellationToken)
        {

            foreach (var FinicialData in request.FinicialDataDto)
            {
                await _uow.EmployeeBasicFinancialDataRepository.AddItem(new Domain.Models.EmployeeBasicFinancialData()
                {

                    EmployeeId = FinicialData.EmployeeId,
                    Amount = FinicialData.Amount,
                    FinancialDataTypesId = FinicialData.FinancialDataTypeId

                });

            }

            await _uow.SaveChangesAsync(cancellationToken);

            return Result.Success();
        }
    }


    public class EmployeeBasicFinancialDataDtos
    {


        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int FinancialDataTypeId { get; set; }
        public decimal Amount { get; set; }

    }
}
