using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixPeriodicUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PeriodicSubscription_EmployeeOrders_EmployeeOrderId",
                table: "PeriodicSubscription");

            migrationBuilder.DropIndex(
                name: "IX_PeriodicSubscription_EmployeeId_FormId_SubscriptionId",
                table: "PeriodicSubscription");

            migrationBuilder.DropIndex(
                name: "IX_PeriodicSubscription_EmployeeOrderId",
                table: "PeriodicSubscription");

            migrationBuilder.DropColumn(
                name: "EmployeeOrderId",
                table: "PeriodicSubscription");

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 24, 21, 1, 12, 191, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.CreateIndex(
                name: "IX_PeriodicSubscription_EmployeeId_FormId_SubscriptionId_CreditOrDebit",
                table: "PeriodicSubscription",
                columns: new[] { "EmployeeId", "FormId", "SubscriptionId", "CreditOrDebit" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PeriodicSubscription_EmployeeId_FormId_SubscriptionId_CreditOrDebit",
                table: "PeriodicSubscription");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeOrderId",
                table: "PeriodicSubscription",
                type: "int",
                nullable: true);

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
                name: "IX_PeriodicSubscription_EmployeeOrderId",
                table: "PeriodicSubscription",
                column: "EmployeeOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_PeriodicSubscription_EmployeeOrders_EmployeeOrderId",
                table: "PeriodicSubscription",
                column: "EmployeeOrderId",
                principalTable: "EmployeeOrders",
                principalColumn: "Id");
        }
    }
}
