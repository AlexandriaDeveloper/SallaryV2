using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeOrderType3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrders_Form_FormId",
                table: "EmployeeOrders");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeOrders_FormId",
                table: "EmployeeOrders");

            migrationBuilder.DropColumn(
                name: "FormId",
                table: "EmployeeOrders");

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 254, DateTimeKind.Local).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 254, DateTimeKind.Local).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1009,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1010,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1011,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1012,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1013,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1014,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1015,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1016,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2001,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2002,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2003,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2004,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2005,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2006,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2007,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2008,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2009,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3001,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3002,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3003,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3004,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3005,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3006,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3007,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 4000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 4001,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 5000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 254, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 254, DateTimeKind.Local).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 254, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 254, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 254, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 254, DateTimeKind.Local).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 254, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 254, DateTimeKind.Local).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 254, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 253, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "VacationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 254, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "VacationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 254, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "VacationType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 254, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "VacationType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 12, 22, 18, 4, 254, DateTimeKind.Local).AddTicks(7939));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FormId",
                table: "EmployeeOrders",
                type: "int",
                nullable: true);

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
                name: "IX_EmployeeOrders_FormId",
                table: "EmployeeOrders",
                column: "FormId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrders_Form_FormId",
                table: "EmployeeOrders",
                column: "FormId",
                principalTable: "Form",
                principalColumn: "Id");
        }
    }
}
