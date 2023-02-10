using Domain.Constants;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Persistence.Services;
using System;

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
        //  public DbSet<OrderFile> OrderFiles { get; set; }
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

            //modelBuilder.Entity<Employee>().HasData(
            //    new Employee() { Id = 1, Name = "محمد على شريف", CollageName = "كلية الطب", Section = "مكافأة شامله", NationalId = "0123456781", TabCode = "2309", TegaraCode = "1", CreatedBy = "Admin", CreatedDate = DateTime.Now },
            //    new Employee() { Id = 2, Name = "محمود عبد الحميد شاهين", CollageName = "كلية الطب", Section = "مكافأة شامله", NationalId = "0123456782", TabCode = "2310", TegaraCode = "2", CreatedBy = "Admin", CreatedDate = DateTime.Now },
            //    new Employee() { Id = 3, Name = " اسمهان موسى عيد ", CollageName = "كلية الطب", Section = "مكافأة شامله", NationalId = "0123456783", TabCode = "2311", TegaraCode = "3", CreatedBy = "Admin", CreatedDate = DateTime.Now }

            //    );


            //  modelBuilder.Entity<EmployeeBasicSallary>().HasData(
            // new EmployeeBasicSallary() { Id = 1, EmployeeId = 1, BasicSallary = 246m, FinancialYearId = 1, Wazifi = 1128.09m, Mokamel = 440m, Ta3widi = 31.17m, CreatedBy = "Admin", CreatedDate = DateTime.Now },
            //new EmployeeBasicSallary() { Id = 2, EmployeeId = 2, BasicSallary = 223.5m, FinancialYearId = 1, Wazifi = 1123.49m, Mokamel = 417.5m, Ta3widi = 28.47m, CreatedBy = "Admin", CreatedDate = DateTime.Now },
            // new EmployeeBasicSallary() { Id = 3, EmployeeId = 3, BasicSallary = 208.5m, FinancialYearId = 1, Wazifi = 1083.65m, Mokamel = 402.3m, Ta3widi = 26.67m, CreatedBy = "Admin", CreatedDate = DateTime.Now }



            //  );

            modelBuilder.Entity<Subscription>().HasData(
            new Subscription() { Id = 1, Name = "تأمين علاجى", CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new Subscription() { Id = 2, Name = "نقابه", CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new Subscription() { Id = 3, Name = "محمول شركة ETI", CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new Subscription() { Id = 4, Name = "محمول شركه سيجنال ", CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new Subscription() { Id = 5, Name = "خزنه تك  ", CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new Subscription() { Id = 6, Name = "نفقه  ", CreatedBy = "Admin", CreatedDate = DateTime.Now }
     );

            modelBuilder.Entity<Grade>().HasData(
          new Grade() { Id = 1, Name = "درجة كبير", CreatedBy = "Admin", CreatedDate = DateTime.Now },
          new Grade() { Id = 2, Name = "درجة اولى", CreatedBy = "Admin", CreatedDate = DateTime.Now },
          new Grade() { Id = 3, Name = "درجة ثانيه", CreatedBy = "Admin", CreatedDate = DateTime.Now },
          new Grade() { Id = 4, Name = "درجة ثالثه", CreatedBy = "Admin", CreatedDate = DateTime.Now },
          new Grade() { Id = 5, Name = "درجة رابعه", CreatedBy = "Admin", CreatedDate = DateTime.Now },
          new Grade() { Id = 6, Name = "درجة خامسه", CreatedBy = "Admin", CreatedDate = DateTime.Now },
          new Grade() { Id = 7, Name = "درجة سادسه", CreatedBy = "Admin", CreatedDate = DateTime.Now }
    );

            modelBuilder.Entity<Collection>().HasData(
            new Collection() { Id = 1, Name = "مرتبات بطاقات حكوميه", CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new Collection() { Id = 2, Name = "مرتبات تحويلات بنكيه", CreatedBy = "Admin", CreatedDate = DateTime.Now }

                  );
        }
    }




}
