﻿using Application.Common.Messaging;
using AutoMapper;
using Domain.DTOS.EmploueeOrdersDtos;
using Domain.Interfaces;
using Domain.Shared;

namespace Domain.EmployeeOrders.Queries.GetEmployeeOrderData
{
    public record GetEmployeeOrdersDataQuery(int OrderId, int EmployeeId) : IQuery<GetEmployeeOrdersDataDto>;


    public class GetEmployeeOrdersDataQueryHandler : IQueryHandler<GetEmployeeOrdersDataQuery, GetEmployeeOrdersDataDto>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetEmployeeOrdersDataQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            this._mapper = mapper;
        }

        public async Task<Result<GetEmployeeOrdersDataDto>> Handle(GetEmployeeOrdersDataQuery request, CancellationToken cancellationToken)
        {

            GetEmployeeOrdersDataDto employeeOrderDto = new();

            var employeeOrderList = await _uow.EmployeeOrderRepository.GetEmployeeOrdersByOrderId(request.OrderId, request.EmployeeId);
            // var employeeDeductionList = await _uow.EmployeeOrderDeductionRepository.GetEmployeeOrdersDeductionByDeductionId(request.OrderId, request.EmployeeId);
            if (employeeOrderDto.EmployeeDeductions == null)
            {
                employeeOrderDto.EmployeeDeductions = new List<GetEmployeeOrdersDataDto.GetEmployeeDeductionsListDto>();
            }

            if (employeeOrderDto.EmployeeOrders == null)
            {
                employeeOrderDto.EmployeeOrders = new List<GetEmployeeOrdersDataDto.GetEmployeeOrdersListDto>();
            }

            foreach (var employeeOrder in employeeOrderList)
            {


                if (employeeOrder.CreditOrDebit == 'd')
                    employeeOrderDto.EmployeeOrders.Add(new GetEmployeeOrdersDataDto.GetEmployeeOrdersListDto
                    {

                        Amount = employeeOrder.EmployeeOrderExecuations.Sum(x => x.Amount),
                        CreditOrDebit = employeeOrder.CreditOrDebit,
                        Details = employeeOrder.Details,
                        EndAt = employeeOrder.EndAt,
                        Quantity = employeeOrder.Quantity,
                        StartFrom = employeeOrder.StartFrom,
                        Id = employeeOrder.Id,
                        OrderFileName = employeeOrder.Form.Name

                    });

                else if (employeeOrder.CreditOrDebit == 'c')
                {


                    employeeOrderDto.EmployeeDeductions.Add(new GetEmployeeOrdersDataDto.GetEmployeeDeductionsListDto
                    {

                        Amount = employeeOrder.EmployeeOrderExecuations.Sum(x => x.Amount),
                        CreditOrDebit = employeeOrder.CreditOrDebit,
                        Details = employeeOrder.Details,
                        OrderFileName = employeeOrder.Form.Details



                    });



                }

            }


            //foreach (var employeeDeduction in employeeDeductionList)
            //{
            //    employeeOrderDto.EmployeeDeductions.Add(new GetEmployeeOrdersDataDto.GetEmployeeDeductionsListDto
            //    {

            //        Amount = employeeDeduction.EmployeeOrderDeductionExecuations.Sum(x => x.Amount),
            //        CreditOrDebit = employeeDeduction.CreditOrDebit,
            //        Details = employeeDeduction.Details,



            //    });

            //}

            return Result<GetEmployeeOrdersDataDto>.Success(employeeOrderDto);

        }
    }




}