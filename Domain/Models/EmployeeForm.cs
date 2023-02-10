using Domain.Primitives;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{

    //TODO Creat Full Sallary Form 
    public class EmployeeForm : Entity
    {
        [NotMapped]
        public override string Name { get => base.Name; set => base.Name = value; }

        public int FormId { get; set; }
        public int EmployeeId { get; set; }


        public int EmployeeOrderNumber { get; set; }
        [NotMapped]
        public decimal Net { get => Credit.TotalCredit - Debit.TotalDebit; }
        public Form Form { get; set; }
        public Employee Employee { get; set; }
        public EmployeeFormCredit Credit { get; set; }
        public EmployeeFormDebit Debit { get; set; }
    }


    public class EmployeeFormCredit : Entity
    {
        [NotMapped]
        public override string Name { get => base.Name; set => base.Name = value; }
        public int EmployeeFormId { get; set; }
        public decimal Wazifi { get; set; }
        public decimal Mokamel { get; set; }
        public decimal Taawidi { get; set; }

        public decimal WazifiReplacment { get; set; }
        public decimal MokamelReplacment { get; set; }
        public decimal TaawidiReplacment { get; set; }
        [NotMapped]
        public decimal TotalCredit { get => Wazifi + Mokamel + Taawidi; }

        public EmployeeForm EmployeeForm { get; set; }



    }

    public class EmployeeFormDebit : Entity
    {
        [NotMapped]
        public override string Name { get => base.Name; set => base.Name = value; }
        public int EmployeeFormId { get; set; }
        public decimal Gazzaa { get; set; }
        public decimal Abscence { get; set; }
        public decimal Subscriptions { get; set; }
        public decimal Insurance { get; set; }
        public decimal Tax { get; set; }
        public decimal Stamp { get; set; }
        [NotMapped]
        public decimal TotalDebit { get => Gazzaa + Abscence + Subscriptions + Insurance + Tax + Stamp; }

        public EmployeeForm EmployeeForm { get; set; }
    }

}
