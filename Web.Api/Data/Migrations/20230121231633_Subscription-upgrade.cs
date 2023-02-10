using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Subscriptionupgrade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PeriodicSubscription_Employees_EmployeeId",
                table: "PeriodicSubscription");

            migrationBuilder.DropIndex(
                name: "IX_PeriodicSubscription_EmployeeId",
                table: "PeriodicSubscription");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeForms_EmployeeId",
                table: "EmployeeForms");

            migrationBuilder.DropColumn(
                name: "EmployeeOrderDeductionId",
                table: "PeriodicSubscription");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "PeriodicSubscription",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FormId",
                table: "PeriodicSubscription",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 1, 16, 31, 287, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.CreateIndex(
                name: "IX_PeriodicSubscription_EmployeeId_FormId_SubscriptionId",
                table: "PeriodicSubscription",
                columns: new[] { "EmployeeId", "FormId", "SubscriptionId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PeriodicSubscription_FormId",
                table: "PeriodicSubscription",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_PeriodicSubscription_SubscriptionId",
                table: "PeriodicSubscription",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeForms_EmployeeId_FormId",
                table: "EmployeeForms",
                columns: new[] { "EmployeeId", "FormId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PeriodicSubscription_Employees_EmployeeId",
                table: "PeriodicSubscription",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeriodicSubscription_Form_FormId",
                table: "PeriodicSubscription",
                column: "FormId",
                principalTable: "Form",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeriodicSubscription_Subscriptions_SubscriptionId",
                table: "PeriodicSubscription",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PeriodicSubscription_Employees_EmployeeId",
                table: "PeriodicSubscription");

            migrationBuilder.DropForeignKey(
                name: "FK_PeriodicSubscription_Form_FormId",
                table: "PeriodicSubscription");

            migrationBuilder.DropForeignKey(
                name: "FK_PeriodicSubscription_Subscriptions_SubscriptionId",
                table: "PeriodicSubscription");

            migrationBuilder.DropIndex(
                name: "IX_PeriodicSubscription_EmployeeId_FormId_SubscriptionId",
                table: "PeriodicSubscription");

            migrationBuilder.DropIndex(
                name: "IX_PeriodicSubscription_FormId",
                table: "PeriodicSubscription");

            migrationBuilder.DropIndex(
                name: "IX_PeriodicSubscription_SubscriptionId",
                table: "PeriodicSubscription");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeForms_EmployeeId_FormId",
                table: "EmployeeForms");

            migrationBuilder.DropColumn(
                name: "FormId",
                table: "PeriodicSubscription");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "PeriodicSubscription",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeOrderDeductionId",
                table: "PeriodicSubscription",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 22, 35, 51, 584, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.CreateIndex(
                name: "IX_PeriodicSubscription_EmployeeId",
                table: "PeriodicSubscription",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeForms_EmployeeId",
                table: "EmployeeForms",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PeriodicSubscription_Employees_EmployeeId",
                table: "PeriodicSubscription",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");
        }
    }
}
