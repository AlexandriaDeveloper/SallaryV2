using Domain.Constants;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Persistence.Services;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Persistence.Data
{
    public class SallaryCQRSAppContext : DbContext
    {
        private readonly AuthService _authService;

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeePartTime> EmployeesPartTimes { get; set; }

        public DbSet<EmployeeBasicSallary> EmployeeBasicSallaries { get; set; }
        public DbSet<FinancialYear> FinancialYears { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<BudgetItem> BudgetItems { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        public DbSet<EmployeeOrder> EmployeeOrders { get; set; }
        public DbSet<EmployeeOrderExecuation> EmployeeOrderExecuations { get; set; }
        //public DbSet<EmployeeOrderDeduction> EmployeeOrderDeductions { get; set; }
        public DbSet<EmployeeGrade> EmployeeGrades { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<EmployeeCollection> EmployeeCollections { get; set; }

        public DbSet<EmployeeSubscription> EmployeeSubscriptions { get; set; }

        public DbSet<EmployeeForm> EmployeeForms { get; set; }
        public DbSet<EmployeeBank> EmployeeBanks { get; set; }
          public DbSet<FinancialDataType> FinancialDataTypes { get; set; }
        public DbSet<EmployeeBasicFinancialData> EmployeeBasicFinancialData { get; set; }
        public SallaryCQRSAppContext(DbContextOptions<SallaryCQRSAppContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            // TODO : after i do auth system i will chage admin hardcode to one created at db ;



            modelBuilder.Entity<Employee>().HasOne(x => x.EmployeeBank)
                .WithOne(t => t.Employee)
                .HasForeignKey<Employee>(fk => fk.EmployeeBankId);


            modelBuilder.Entity<EmployeeForm>().HasOne(x => x.Credit)
               .WithOne(t => t.EmployeeForm)
               .HasForeignKey<EmployeeFormCredit>(fk => fk.EmployeeFormId);


            modelBuilder.Entity<EmployeeForm>().HasOne(x => x.Debit)
               .WithOne(t => t.EmployeeForm)
               .HasForeignKey<EmployeeFormDebit>(fk => fk.EmployeeFormId);

            modelBuilder.Entity<Employee>()
                .HasIndex(x => x.NationalId).IsUnique();

            modelBuilder.Entity<Employee>()
             .HasIndex(x => x.TabCode).IsUnique();


            modelBuilder.Entity<EmployeeForm>()
             .HasIndex(x => new { x.EmployeeId, x.FormId }).IsUnique();


            modelBuilder.Entity<PeriodicSubscription>()
             .HasIndex(x => new { x.EmployeeId, x.FormId, x.SubscriptionId, x.CreditOrDebit }).IsUnique();



            modelBuilder.Entity<EmployeeGrade>()
                .HasIndex(x => new { x.EmployeeId, x.GradeId }).IsUnique();

            modelBuilder.Entity<EmployeeSubscription>()
                .HasIndex(x => new { x.EmployeeId, x.SubscriptionId }).IsUnique();

            modelBuilder.Entity<EmployeeBasicSallary>()
            .HasIndex(x => new { x.EmployeeId, x.FinancialYearId }).IsUnique();

            modelBuilder.Entity<EmployeeCollection>()
                .HasIndex(x => new { x.EmployeeId, x.CollectionId }).IsUnique();


            modelBuilder.Entity <FinancialDataType> ().Property(m => m.Id).ValueGeneratedNever()
           ;



            modelBuilder.Entity<EmployeeBasicFinancialData>()
                .HasIndex(x => new {x.EmployeeId,x.FinancialDataTypesId }).IsUnique();
            this.SeedData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }



        private void SeedData(ModelBuilder modelBuilder)
        {


            //DEBIT

            modelBuilder.Entity<Order>().HasData(
            new Order() { Id = 1, CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.OrderConstants.ABSENCE },
            new Order() { Id = 2, CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.OrderConstants.PUNISHMENT_ABSENCE },
            new Order() { Id = 3, CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.OrderConstants.PUNISHMENT_EXAMINATION_REWARD },
            new Order() { Id = 4, CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.OrderConstants.VACATION_WITHOT_SALLARY },
            new Order() { Id = 5, CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.OrderConstants.REPAY },
            new Order() { Id = 6, CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.OrderConstants.FIXED_AMOUNT }

             );

            modelBuilder.Entity<Form>().HasData(
            new Form() { Id = 1, Details = "مرتبات شهر مارس", FormDate = "2022-3", CreatedDate = DateTime.Now, CreatedBy = "Admin", FileNumber224 = "1", FileNumber55 = "1" },
            new Form() { Id = 2, Details = "مرتبات شهر ابريل", FormDate = "2022-4", CreatedDate = DateTime.Now, CreatedBy = "Admin", FileNumber224 = "1", FileNumber55 = "1" },
            new Form() { Id = 3, Details = "مرتبات شهر مايو", FormDate = "2022-5", CreatedDate = DateTime.Now, CreatedBy = "Admin", FileNumber224 = "2", FileNumber55 = "2" },
            new Form() { Id = 4, Details = "مرتبات شهر يونيو", FormDate = "2022-6", CreatedDate = DateTime.Now, CreatedBy = "Admin", FileNumber224 = "3", FileNumber55 = "3" }



                );


            modelBuilder.Entity<BudgetItem>().HasData(
                new BudgetItem() { Id = 1, CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.BudgetItems.WAZIFI },
                new BudgetItem() { Id = 2, CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.BudgetItems.MOKAMEL },
                new BudgetItem() { Id = 3, CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.BudgetItems.TA3WIDI },
                new BudgetItem() { Id = 4, CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.BudgetItems.GAZAA },
                new BudgetItem() { Id = 5, CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.BudgetItems.ABSENCE },
                new BudgetItem() { Id = 6, CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.BudgetItems.REPAY },
                new BudgetItem() { Id = 7, CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.BudgetItems.DEDUCTION }

                );


            modelBuilder.Entity<FinancialYear>().HasData(
                new FinancialYear() { Id = 1, Name = "العام المالى 2017-2018", CreatedBy = "Admin", CreatedDate = DateTime.Now },
                new FinancialYear() { Id = 2, Name = "العام المالى 2018-2019", CreatedBy = "Admin", CreatedDate = DateTime.Now },
                new FinancialYear() { Id = 3, Name = "العام المالى 2020-2019", CreatedBy = "Admin", CreatedDate = DateTime.Now },
                new FinancialYear() { Id = 4, Name = "العام المالى 2021-2020", CreatedBy = "Admin", CreatedDate = DateTime.Now },
                new FinancialYear() { Id = 5, Name = "العام المالى 2022-2021", CreatedBy = "Admin", CreatedDate = DateTime.Now }


                );


            modelBuilder.Entity<FinancialDataType>().HasData(

                //بنود

               new FinancialDataType() { Id = 1000, Name = Constant.FinincialData.WAZIFI,ReservationDate=new DateTime(2015,6,30), CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 2000, Name = Constant.FinincialData.MOKAMEL, ReservationDate = new DateTime(2015, 6, 30), CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id =3000, Name = Constant.FinincialData.AGMALI_AGR, ReservationDate = new DateTime(2015, 6, 30), CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 4000, Name = Constant.FinincialData.TAWIDI, ReservationDate = new DateTime(2015, 6, 30), CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 5000, Name = Constant.FinincialData.SHAMEL, ReservationDate = new DateTime(2015, 6, 30), CreatedBy = "Admin", CreatedDate = DateTime.Now },

               //مكونات اجر وظيفى 

               new FinancialDataType() { Id = 1002, Name = Constant.FinincialData.BASIC, ReservationDate = new DateTime(2015, 6, 30), ParentFinancialDataTypeId=1000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 1003, Name = Constant.FinincialData.BASIC2, ReservationDate = new DateTime(2015, 6, 30), ParentFinancialDataTypeId = 1000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 1004, Name = Constant.FinincialData.BADAL_HAD_ADNA, ReservationDate = new DateTime(2015, 6, 30),  ParentFinancialDataTypeId = 1000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 1005, Name = Constant.FinincialData.ALAWA_KHIR_MADMOMA, ReservationDate = new DateTime(2015, 6, 30), ParentFinancialDataTypeId = 1000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 1006, Name = Constant.FinincialData.BADAL_ALAWA_IGTMAIA_WE_MENHA, ReservationDate = new DateTime(2015, 6, 30), ParentFinancialDataTypeId = 1000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 1007, Name = Constant.FinincialData.ALAWA_2015, ReservationDate = new DateTime(2015, 7, 1), ParentFinancialDataTypeId = 1000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 1008, Name = Constant.FinincialData.ALAWA_2016, ReservationDate = new DateTime(2016, 7, 1), ParentFinancialDataTypeId = 1000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 1009, Name = Constant.FinincialData.ALAWA_2017, ReservationDate = new DateTime(2017, 7, 1), ParentFinancialDataTypeId = 1000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 1010, Name = Constant.FinincialData.ALAWA_2017, ReservationDate = new DateTime(2017, 7, 1), ParentFinancialDataTypeId = 1000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 1011, Name = Constant.FinincialData.ALAWA_2018, ReservationDate = new DateTime(2018, 7, 1), ParentFinancialDataTypeId = 1000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 1012, Name = Constant.FinincialData.ALAWA_2018_2, ReservationDate = new DateTime(2018, 7, 1), ParentFinancialDataTypeId = 1000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 1013, Name = Constant.FinincialData.ALAWA_2019, ReservationDate = new DateTime(2019, 7, 1), ParentFinancialDataTypeId = 1000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 1014, Name = Constant.FinincialData.ALAWA_2020, ReservationDate = new DateTime(2020, 7, 1), ParentFinancialDataTypeId = 1000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 1015, Name = Constant.FinincialData.ALAWA_2021, ReservationDate = new DateTime(2021, 7, 1), ParentFinancialDataTypeId = 1000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 1016, Name = Constant.FinincialData.ALAWA_2022, ReservationDate = new DateTime(2022, 7, 1), ParentFinancialDataTypeId = 1000, CreatedBy = "Admin", CreatedDate = DateTime.Now },


               //مكونات اجمالى الاجر

               new FinancialDataType() { Id = 3001, Name = Constant.FinincialData.BASIC, ReservationDate = new DateTime(2015, 6, 30), ParentFinancialDataTypeId = 3000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 3002, Name = Constant.FinincialData.ALAWA_KHIR_MADMOMA, ReservationDate = new DateTime(2015, 6, 30), ParentFinancialDataTypeId = 3000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 3003, Name = Constant.FinincialData.MENHA, ReservationDate = new DateTime(2015, 6, 30), ParentFinancialDataTypeId = 3000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 3004, Name = Constant.FinincialData.ALAWA_IGTMAIA, ReservationDate = new DateTime(2015, 6, 30), ParentFinancialDataTypeId = 3000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 3005, Name = Constant.FinincialData.ALAWA_IDAFIA, ReservationDate = new DateTime(2015, 6, 30), ParentFinancialDataTypeId = 3000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 3006, Name = Constant.FinincialData.BADAL_ADWA, ReservationDate = new DateTime(2015, 6, 30), ParentFinancialDataTypeId = 3000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 3007, Name = Constant.FinincialData.BASIC_150, ReservationDate = new DateTime(2015, 6, 30), ParentFinancialDataTypeId = 3000, CreatedBy = "Admin", CreatedDate = DateTime.Now },


               //مكونات الاجر المكمل

               new FinancialDataType() { Id = 2001, Name = Constant.FinincialData.BASIC_50, ReservationDate = new DateTime(2015, 6, 30), ParentFinancialDataTypeId = 2000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 2002, Name = Constant.FinincialData.BADAL_GAWDA, ReservationDate = new DateTime(2015, 6, 30), ParentFinancialDataTypeId = 2000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 2003, Name = Constant.FinincialData.BADAL_HAD_ADNA, ReservationDate = new DateTime(2015, 6, 30), ParentFinancialDataTypeId = 2000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 2004, Name = Constant.FinincialData.HAFEZ_2019, ReservationDate = new DateTime(2019, 7, 1), ParentFinancialDataTypeId = 2000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 2005, Name = Constant.FinincialData.HAFEZ_2020, ReservationDate = new DateTime(2020, 7, 1), ParentFinancialDataTypeId = 2000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 2006, Name = Constant.FinincialData.HAFEZ_2021, ReservationDate = new DateTime(2021, 7, 1), ParentFinancialDataTypeId = 2000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 2007, Name = Constant.FinincialData.HAFEZ_2022, ReservationDate = new DateTime(2022, 4, 1), ParentFinancialDataTypeId = 2000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 2008, Name = Constant.FinincialData.BADAL_GHALA_2022, ReservationDate = new DateTime(2022, 11, 1), ParentFinancialDataTypeId = 2000, CreatedBy = "Admin", CreatedDate = DateTime.Now },
               new FinancialDataType() { Id = 2009, Name = Constant.FinincialData.HAFEZ_IDAFI, ReservationDate = new DateTime(2015, 6, 30), ParentFinancialDataTypeId = 2000, CreatedBy = "Admin", CreatedDate = DateTime.Now },


               //حافز تعويضى

               new FinancialDataType() { Id = 4001, Name = Constant.FinincialData.TAWIDI_2016, ParentFinancialDataTypeId = 4000, ReservationDate = new DateTime(2015, 6, 30), CreatedBy = "Admin", CreatedDate = DateTime.Now }
    );


            modelBuilder.Entity<Subscription>().HasData(
            new Subscription() { Id = 1, Name = "تأمين علاجى", CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new Subscription() { Id = 2, Name = "نقابه", CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new Subscription() { Id = 3, Name = "محمول شركة ETI", CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new Subscription() { Id = 4, Name = "محمول شركه سيجنال ", CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new Subscription() { Id = 5, Name = "خزنه تك  ", CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new Subscription() { Id = 6, Name = "نفقه  ", CreatedBy = "Admin", CreatedDate = DateTime.Now }
     );

            modelBuilder.Entity<Grade>().HasData(
          new Grade() { Id = 1, Name = Constant.Model.Grades.MOMTAZA, CreatedBy = "Admin", CreatedDate = DateTime.Now },
          new Grade() { Id = 2, Name = Constant.Model.Grades.ALIA, CreatedBy = "Admin", CreatedDate = DateTime.Now },
          new Grade() { Id = 3, Name = Constant.Model.Grades.KABIR, CreatedBy = "Admin", CreatedDate = DateTime.Now },

          new Grade() { Id = 4, Name = Constant.Model.Grades.AWLA, CreatedBy = "Admin", CreatedDate = DateTime.Now },
          new Grade() { Id = 5, Name = Constant.Model.Grades.AWLA_A, ParentId=4,Priority=1,  CreatedBy = "Admin", CreatedDate = DateTime.Now },
          new Grade() { Id = 6, Name = Constant.Model.Grades.AWLA_B, ParentId = 4, Priority = 2, CreatedBy = "Admin", CreatedDate = DateTime.Now },

          new Grade() { Id = 7, Name = Constant.Model.Grades.TANIA, CreatedBy = "Admin", CreatedDate = DateTime.Now },
          new Grade() { Id = 8, Name = Constant.Model.Grades.TANIA_A, ParentId = 7, Priority = 1 ,CreatedBy = "Admin", CreatedDate = DateTime.Now },
          new Grade() { Id = 9, Name = Constant.Model.Grades.TANIA_B, ParentId = 7, Priority = 2, CreatedBy = "Admin", CreatedDate = DateTime.Now },

          new Grade() { Id = 10, Name = Constant.Model.Grades.TALTA, CreatedBy = "Admin", CreatedDate = DateTime.Now },
          new Grade() { Id = 11, Name = Constant.Model.Grades.TALTA_A, ParentId = 10 , Priority = 1, CreatedBy = "Admin", CreatedDate = DateTime.Now },
          new Grade() { Id = 12, Name = Constant.Model.Grades.TALTA_B, ParentId = 10, Priority = 2, CreatedBy = "Admin", CreatedDate = DateTime.Now },
          new Grade() { Id = 13, Name = Constant.Model.Grades.TALTA_C, ParentId = 10, Priority = 3, CreatedBy = "Admin", CreatedDate = DateTime.Now },


          new Grade() { Id = 14, Name = Constant.Model.Grades.RABA,  CreatedBy = "Admin", CreatedDate = DateTime.Now },
          new Grade() { Id = 15, Name = Constant.Model.Grades.RABA_A, ParentId = 14, Priority = 1, CreatedBy = "Admin", CreatedDate = DateTime.Now },
          new Grade() { Id = 16, Name = Constant.Model.Grades.RABA_B, ParentId = 14, Priority = 2, CreatedBy = "Admin", CreatedDate = DateTime.Now },

          new Grade() { Id = 17, Name = Constant.Model.Grades.KHAMSA, CreatedBy = "Admin", CreatedDate = DateTime.Now },
          new Grade() { Id = 18, Name = Constant.Model.Grades.KHAMSA_A, ParentId = 17, Priority = 1, CreatedBy = "Admin", CreatedDate = DateTime.Now },
          new Grade() { Id = 19, Name = Constant.Model.Grades.KHAMSA_B, ParentId = 17, Priority = 2, CreatedBy = "Admin", CreatedDate = DateTime.Now },

          new Grade() { Id = 20, Name = Constant.Model.Grades.SADSA, CreatedBy = "Admin", CreatedDate = DateTime.Now },
          new Grade() { Id = 21, Name = Constant.Model.Grades.SADSA_A, ParentId = 20, Priority = 1, CreatedBy = "Admin", CreatedDate = DateTime.Now },
          new Grade() { Id = 22, Name = Constant.Model.Grades.SADSA_B, ParentId = 20, Priority = 2, CreatedBy = "Admin", CreatedDate = DateTime.Now }
    );


            modelBuilder.Entity<MinimumSallary>().HasData(
            new MinimumSallary() { Id = 1, GradeId = 1, Amount = 170, CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new MinimumSallary() { Id = 2, GradeId = 2, Amount = 170, CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new MinimumSallary() { Id = 3, GradeId = 3, Amount = 170, CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new MinimumSallary() { Id = 4, GradeId = 4, Amount = 255, CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new MinimumSallary() { Id = 5, GradeId = 7, Amount = 300, CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new MinimumSallary() { Id = 6, GradeId = 10, Amount = 340, CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new MinimumSallary() { Id = 7, GradeId = 14, Amount = 385, CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new MinimumSallary() { Id = 8, GradeId = 17, Amount = 400, CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new MinimumSallary() { Id = 9, GradeId = 20, Amount = 400, CreatedBy = "Admin", CreatedDate = DateTime.Now }
        );

            modelBuilder.Entity<Collection>().HasData(
            new Collection() { Id = 1, Name = "مرتبات بطاقات حكوميه", CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new Collection() { Id = 2, Name = "مرتبات تحويلات بنكيه", CreatedBy = "Admin", CreatedDate = DateTime.Now }            
    );
        }
    }




}
