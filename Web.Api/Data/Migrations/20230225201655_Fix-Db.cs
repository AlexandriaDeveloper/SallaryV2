using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EmployeeBasicFinancialData_EmployeeId",
                table: "EmployeeBasicFinancialData");

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 802, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 802, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2000,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2001,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2002,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2003,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2004,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2005,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2006,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2007,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2008,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2009,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3000,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3001,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3002,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3003,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3004,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3005,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3006,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3007,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 4000,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 4001,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 5000,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6016));

            migrationBuilder.InsertData(
                table: "FinancialDataTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "ParentFinancialDataTypeId", "ReservationDate" },
                values: new object[,]
                {
                    { 1007, "Admin", new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6047), null, null, null, null, "علاوة دوريه 2015", 1000, new DateTime(2015, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1008, "Admin", new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6048), null, null, null, null, "علاوة دوريه 2016", 1000, new DateTime(2016, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1009, "Admin", new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6050), null, null, null, null, "علاوة دوريه 2017", 1000, new DateTime(2017, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1010, "Admin", new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6051), null, null, null, null, "علاوة دوريه 2017", 1000, new DateTime(2017, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1011, "Admin", new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6052), null, null, null, null, "علاوة دوريه 2018", 1000, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1012, "Admin", new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6054), null, null, null, null, "علاوة استثنائيه 2018", 1000, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1013, "Admin", new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6055), null, null, null, null, "علاوة دوريه 2019", 1000, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1014, "Admin", new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6057), null, null, null, null, "علاوة دوريه 2020", 1000, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1015, "Admin", new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6058), null, null, null, null, "علاوة دوريه 2021", 1000, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1016, "Admin", new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6059), null, null, null, null, "علاوة دوريه 2022", 1000, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 802, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 802, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 802, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 802, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 802, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 802, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 802, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 802, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 802, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 25, 22, 16, 52, 800, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBasicFinancialData_EmployeeId_FinancialDataTypesId",
                table: "EmployeeBasicFinancialData",
                columns: new[] { "EmployeeId", "FinancialDataTypesId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EmployeeBasicFinancialData_EmployeeId_FinancialDataTypesId",
                table: "EmployeeBasicFinancialData");

            migrationBuilder.DeleteData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 42, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 42, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2000,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2001,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2002,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2003,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2004,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2005,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2006,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2007,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2008,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2009,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3000,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3001,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3002,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3003,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3004,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3005,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3006,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3007,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 4000,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 4001,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 5000,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 42, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 42, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 42, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 42, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 42, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 42, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 42, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 42, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 42, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBasicFinancialData_EmployeeId",
                table: "EmployeeBasicFinancialData",
                column: "EmployeeId");
        }
    }
}
