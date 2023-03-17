using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateemployeeordertype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EmployeeOrderType_OrderId",
                table: "EmployeeOrderType");

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 160, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 160, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1009,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1010,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1011,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1012,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1013,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1014,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1015,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1016,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2001,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2002,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2003,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2004,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2005,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2006,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2007,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2008,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2009,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3001,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3002,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3003,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3004,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3005,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3006,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3007,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 4000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 4001,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 5000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(948));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 160, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 160, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 160, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 160, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 160, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 160, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 160, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 160, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 160, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 159, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "VacationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 160, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "VacationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 160, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "VacationType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 160, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "VacationType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 12, 27, 3, 160, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrderType_OrderId",
                table: "EmployeeOrderType",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EmployeeOrderType_OrderId",
                table: "EmployeeOrderType");

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

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrderType_OrderId",
                table: "EmployeeOrderType",
                column: "OrderId",
                unique: true);
        }
    }
}
