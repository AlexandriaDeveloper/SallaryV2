using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeOrderType2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrders_Orders_OrderId",
                table: "EmployeeOrders");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeOrderType_OrderId",
                table: "EmployeeOrderType");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeOrders_OrderId",
                table: "EmployeeOrders");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "EmployeeOrders");

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 26, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 26, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1009,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1010,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1011,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1012,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1013,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1014,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1015,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1016,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2001,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2002,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2003,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2004,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2005,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2006,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2007,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2008,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2009,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3001,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3002,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3003,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3004,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3005,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3006,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3007,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 4000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 4001,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 5000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 26, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 26, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 26, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 26, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 26, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 26, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 26, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 26, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 26, DateTimeKind.Local).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 24, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "VacationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 26, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "VacationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 26, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "VacationType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 26, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "VacationType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 13, 59, 26, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrderType_OrderId",
                table: "EmployeeOrderType",
                column: "OrderId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EmployeeOrderType_OrderId",
                table: "EmployeeOrderType");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "EmployeeOrders",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 704, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 704, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1009,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1010,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1011,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1012,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1013,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1014,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1015,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1016,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2001,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2002,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2003,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2004,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2005,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2006,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2007,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2008,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2009,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3001,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3002,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3003,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3004,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3005,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3006,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3007,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 4000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 4001,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 5000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 704, DateTimeKind.Local).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 704, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 704, DateTimeKind.Local).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 704, DateTimeKind.Local).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 704, DateTimeKind.Local).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 704, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 704, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 704, DateTimeKind.Local).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 704, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 702, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "VacationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 704, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "VacationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 704, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "VacationType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 704, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "VacationType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 21, 57, 19, 704, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrderType_OrderId",
                table: "EmployeeOrderType",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrders_OrderId",
                table: "EmployeeOrders",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrders_Orders_OrderId",
                table: "EmployeeOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
