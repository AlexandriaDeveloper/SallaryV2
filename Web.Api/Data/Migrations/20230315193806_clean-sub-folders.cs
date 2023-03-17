using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class cleansubfolders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeBasicSallaries_FinancialYears_FinancialYearId",
                table: "EmployeeBasicSallaries");

            migrationBuilder.DropTable(
                name: "EmployeesPartTimes");

            migrationBuilder.DropTable(
                name: "FinancialYears");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeBasicSallaries_FinancialYearId",
                table: "EmployeeBasicSallaries");

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 4, 0, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 4, 0, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1009,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1010,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1011,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1012,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1013,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1014,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1015,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1016,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2001,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2002,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2003,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2004,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2005,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2006,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2007,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2008,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2009,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3001,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3002,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3003,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3004,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3005,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3006,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3007,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 4000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 4001,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 5000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 4, 0, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 4, 0, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 4, 0, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 4, 0, DateTimeKind.Local).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 4, 0, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 4, 0, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 4, 0, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 4, 0, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 4, 0, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 3, 998, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Vacation",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 4, 0, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "Vacation",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 4, 0, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Vacation",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 4, 0, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Vacation",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 38, 4, 0, DateTimeKind.Local).AddTicks(2244));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeesPartTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EndAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartFrom = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesPartTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeesPartTimes_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinancialYears",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialYears", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 713, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 713, DateTimeKind.Local).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1009,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1010,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1011,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1012,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1013,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1014,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1015,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1016,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2001,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2002,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2003,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2004,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2005,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2006,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2007,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2008,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2009,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3001,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3002,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3003,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3004,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3005,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3006,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3007,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 4000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 4001,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 5000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.InsertData(
                table: "FinancialYears",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1626), null, null, null, null, "العام المالى 2017-2018" },
                    { 2, "Admin", new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1628), null, null, null, null, "العام المالى 2018-2019" },
                    { 3, "Admin", new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1629), null, null, null, null, "العام المالى 2020-2019" },
                    { 4, "Admin", new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1630), null, null, null, null, "العام المالى 2021-2020" },
                    { 5, "Admin", new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1631), null, null, null, null, "العام المالى 2022-2021" }
                });

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 713, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 713, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 713, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 713, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 713, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 713, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 713, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 713, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 713, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "Vacation",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 713, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Vacation",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 713, DateTimeKind.Local).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "Vacation",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 713, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "Vacation",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 713, DateTimeKind.Local).AddTicks(9644));

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBasicSallaries_FinancialYearId",
                table: "EmployeeBasicSallaries",
                column: "FinancialYearId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesPartTimes_EmployeeId",
                table: "EmployeesPartTimes",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeBasicSallaries_FinancialYears_FinancialYearId",
                table: "EmployeeBasicSallaries",
                column: "FinancialYearId",
                principalTable: "FinancialYears",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
