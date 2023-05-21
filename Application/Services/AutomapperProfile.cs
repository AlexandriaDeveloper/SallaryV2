using Application.Collections;
using Application.EmployeeBankAccount;
using Application.EmployeeBankAccount.Query.GetEmployeeBankAccountData;
using Application.EmployeeCollections.Commands.AssignEmployeeToCollection;
using Application.EmployeeCollections.Queries;
using Application.EmployeeVacationTypes;
using Application.FinancialDataTypes;
//using Application.FinancialYears;
using Application.Form;
using Application.FormEmployee.Queries.GetFormEmployeeByEmployeeIdAndFormId;
using Application.FormEmployeeOrderExecutions.Queries.GetFormEmployeeOrderExecutionByFormEmployeeOrderId;
using Application.FormEmployeeVacations;
using Application.Orders;
using Application.Subscriptions;
using Application.VacationTypes;
using AutoMapper;
using Domain.EmployeeOrders;
using Domain.Employees;
using Domain.EmployeeSubscriptions;
using Domain.Models;
using Domain.Shared;

namespace Domain.Services
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {

            CreateMap<FormEmployee, Application.FormEmployee.Queries.GetFormEmployeeByEmployeeIdAndFormId.FormEmployeeDto>()
            .ReverseMap();
    
            CreateMap<FormEmployeeOrder, EmployeeOrderDto>()
            .ReverseMap();

            CreateMap<Vacation, VacationTypeDto>()
           .ReverseMap();

            CreateMap<FormEmployeeVacation, FormEmployeeVacationTypeDto>()
                .ReverseMap();

            CreateMap<FormEmployeeSubscription, FormEmployeeSubscriptionDto>()
                .ReverseMap();

            CreateMap<FormEmployeeOrderExecuation, FormEmployeeOrderExecutionsDto>()
                .ForMember(dest => dest.BudgetItemName ,opt => opt.MapFrom(src => src.BudgetItem.Name))
              .ReverseMap();
            CreateMap<FormEmployeeVacation, FormEmployeeVacationDto>()
                  .ForMember(dest => dest.Employee, opt => opt.MapFrom(src => src.FormEmployee.Employee))
                .ReverseMap();
            //CreateMap<FormEmployeeSubscription, EmployeeSubscriptionBalanceDto>()
            //    .ForMember(dest => dest.Credit, opt => opt.MapFrom(src => src.FormEmployee.Where(t => t.CreditOrDebit == 'c').Sum(x => x.Amount)))
            //    .ForMember(dest => dest.Debit, opt => opt.MapFrom(src => src.Employee.FormEmployees.Where(t => t.CreditOrDebit == 'd').Sum(x => x.Amount)))
            //           .ForMember(dest => dest.SubscriptionName, opt => opt.MapFrom(src => src.Subscription.Name))
            //          .ReverseMap();

            CreateMap<Employee, EmployeeDto>().ReverseMap();

            CreateMap<Subscription, SubscriptionDto>().ReverseMap();

            CreateMap<Employee, EmployeeCollectionListDto>()
              .ForMember(dest => dest.EmployeeName, opt => opt.MapFrom(src => src.Name))
              .ForMember(dest => dest.EmployeeCollageName, opt => opt.MapFrom(src => src.CollageName))
              .ForMember(dest => dest.EmployeeSection, opt => opt.MapFrom(src => src.Section))
              .ForMember(dest => dest.EmployeeTabCode, opt => opt.MapFrom(src => src.TabCode))
              .ForMember(dest => dest.EmployeeTegaraCode, opt => opt.MapFrom(src => src.TegaraCode))
              .ReverseMap();

            CreateMap<EmployeeCollection, EmployeeCollectionListDto>()
            .ReverseMap();

            CreateMap<PagedList<Form>, PagedList<FormDto>>().ReverseMap();

            CreateMap<EmployeeBankAccount, EmployeeBankAccontDataDto>()
                 .ForMember(dest => dest.BankName, opt => opt.MapFrom(src => src.Branche.Bank.Name))
                 .ForMember(dest => dest.BranchName, opt => opt.MapFrom(src => src.Branche.Name))
                .ReverseMap();

            CreateMap<FormEmployee, Application.Form.FormEmployeeDto>()
              .ForMember(dest => dest.EmployeeOrderInCollection, opt => opt.MapFrom(src => src.EmployeeOrderNumber))
            .ReverseMap();

            CreateMap<PagedList<FormEmployee>, PagedList<Application.Form.FormEmployeeDto>>()
            .ReverseMap();

            CreateMap<Collection, CollectionDto>().ReverseMap();

            CreateMap<RegisterdEmployeeSubscription, EmployeeToSubscriptionDto>().ReverseMap();

            CreateMap<EmployeeCollection, EmployeeCollectionToAddDto>().ReverseMap();

            //  CreateMap<FinancialYear, FinancialYearDto>().ReverseMap();

            CreateMap<Form, FormDto>().ReverseMap();

            CreateMap<Order, OrderDto>().ReverseMap();

            CreateMap<Employee, EmployeeDetailsDto>().ReverseMap();

            CreateMap<PagedList<Employee>, PagedList<EmployeeDto>>().ReverseMap();

            CreateMap<RegisterdEmployeeSubscription, EmployeeSubscriptionDto>().ReverseMap();

            CreateMap<RegisterdEmployeeSubscription, EmployeeSubscriptionDto>()
             .ForMember(dest => dest.EmployeeName, opt => opt.MapFrom(src => src.Employee.Name))
             .ForMember(dest => dest.EmployeeTabCode, opt => opt.MapFrom(src => src.Employee.TabCode))
             .ForMember(dest => dest.EmployeeNationalId, opt => opt.MapFrom(src => src.Employee.NationalId))
            .ForMember(dest => dest.EmployeeTegaraCode, opt => opt.MapFrom(src => src.Employee.TegaraCode))
             .ForMember(dest => dest.EmployeeSection, opt => opt.MapFrom(src => src.Employee.Section))
            .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.Employee.Id))
            .ReverseMap();

            CreateMap<PagedList<RegisterdEmployeeSubscription>, PagedList<EmployeeSubscriptionDto>>().ReverseMap();

            CreateMap<Bank, BankDto>().ReverseMap();

            CreateMap<Branch, BrancheDto>().ReverseMap();

            CreateMap<FinancialDataType, FinancialDataTypeDto>().ReverseMap();
        }


    }
}
