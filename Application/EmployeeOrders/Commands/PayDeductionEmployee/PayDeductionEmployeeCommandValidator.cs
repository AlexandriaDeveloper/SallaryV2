//using FluentValidation;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Domain.EmployeeOrders.Commands.PayDeductionEmployee
//{
//    public class PayDeductionEmployeeCommandValidator :AbstractValidator<PayDeductionEmployeeCommand>
//    {
//        public PayDeductionEmployeeCommandValidator()
//        {
//            RuleFor(x => x.employeeOrder.EmployeeId).NotEmpty().NotNull();
//            RuleFor(x => x.employeeOrder.OrderId).NotEmpty().NotNull();
//            RuleFor(x => x.employeeOrder.FormId).NotNull().NotEmpty();

//            RuleFor(x => x.employeeOrder.Amount).NotEmpty().NotNull();
//            RuleFor(x => x.employeeOrder.CreditOrDepit).NotEmpty().NotNull();

//            RuleFor(x => x.employeeOrder.Details).MaximumLength(200);
//        }
//    }
//}
