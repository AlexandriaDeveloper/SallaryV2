using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Calculations
{
    public class OrdersCalculations
    {
        private readonly decimal _wazifi;
        private readonly decimal _mokamel;
        private readonly decimal _taawidi;
        private readonly Order _order;
        private readonly IUOW _uow;

        public OrdersCalculations(decimal Wazifi,decimal Mokamel,decimal taawidi ,Order order,IUOW uow)
        {
            _wazifi = Wazifi;
            _mokamel = Mokamel;
            _taawidi = taawidi;
            _order = order;
            _uow = uow;
        }

        //public EmployeeOrder CalculateEmployeeOrder() {

        //    EmployeeOrder employeeOrder= new EmployeeOrder();
        //    if (_order.Name == Constant.Model.OrderConstants.ABSENCE) { 
        //    employeeOrder.w
            
        //    }
        
        
        //}

        //calculationMethod() { 
        
        
        
        //}


    }
}
