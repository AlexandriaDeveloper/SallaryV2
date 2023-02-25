using Application.Common.Messaging;
using Application.EmployeeBasicFinancialsDatas.Queries.GetEmployeeFinincialData;
using AutoMapper;
using Domain.Interfaces;
using Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmployeeBasicFinancialDatas.Commands.AddEmployeeWazifiElements
{

    public record AddEmployeeElementsCommand(EmployeeBasicFinancialDataDtos[] FinicialDataDto):ICommand;
    public class AddEmployeeWazifiElementsCommandHandler : ICommandHandler<AddEmployeeElementsCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public AddEmployeeWazifiElementsCommandHandler(IUOW uow , IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result> Handle(AddEmployeeElementsCommand request, CancellationToken cancellationToken)
        {

            foreach (var FinicialData in request.FinicialDataDto)
            {
                _uow.EmployeeBasicFinancialDataRepository.AddItem(new Domain.Models.EmployeeBasicFinancialData() { 
                
                EmployeeId= FinicialData.EmployeeId,
                Amount= FinicialData.Amount,
                FinancialDataTypesId= FinicialData.FinancialDataTypesId

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
        public int FinancialDataTypesId { get; set; }
        public decimal Amount { get; set; }

    }
}
