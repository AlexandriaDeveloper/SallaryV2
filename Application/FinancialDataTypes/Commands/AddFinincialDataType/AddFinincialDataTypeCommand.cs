using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FinancialDataTypes.Commands.AddFinincialDataType
{

    public record AddFinincialDataTypeCommand(FinancialDataTypeDto data):ICommand;
    public class AddFinincialDataTypeCommandHandler : ICommandHandler<AddFinincialDataTypeCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public AddFinincialDataTypeCommandHandler(IUOW uow , IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result> Handle(AddFinincialDataTypeCommand request, CancellationToken cancellationToken)
        {
            int maxId = 0;

            if (request.data.ParentFinancialDataTypeId.HasValue)
            {

                maxId = _uow.FinancialDataTypesRepository.GetMaxChildId(request.data.ParentFinancialDataTypeId.Value)+1;

            }
            else {


                maxId = _uow.FinancialDataTypesRepository.GetMaxParentId() + 1000;
            }
            request.data.Id= maxId;
               await _uow.FinancialDataTypesRepository.AddItem(new Domain.Models.FinancialDataType()
                {

                    Id = request.data.Id,
                    Name = request.data.Name,
                    ParentFinancialDataTypeId = request.data.ParentFinancialDataTypeId,
                    ReservationDate = request.data.ReservationDate,

                });

              var result =  await  _uow.SaveChangesAsync(cancellationToken);

                if (result != Domain.Enums.SaveState.Saved) { 
                
                return Result.Failure(result);
                }
                return Result.Success();

           
            return Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
        }
    }
}
