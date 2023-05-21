using Domain.Primitives;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Qanon :Entity
    {
        [StringLength(140)]
        public override string Name { get => base.Name; set => base.Name = value; }


        public ICollection<Employee> Employees { get; set; }
        public ICollection< FinancialDataType> FinancialDataTypes { get; set; }
    }
}
