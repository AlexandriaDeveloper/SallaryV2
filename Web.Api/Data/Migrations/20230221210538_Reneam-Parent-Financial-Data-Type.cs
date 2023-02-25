using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class ReneamParentFinancialDataType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FinancialDataTypes_FinancialDataTypes_FinancialDataTypesId",
                table: "FinancialDataTypes");

            migrationBuilder.RenameColumn(
                name: "FinancialDataTypesId",
                table: "FinancialDataTypes",
                newName: "ParentFinancialDataTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_FinancialDataTypes_FinancialDataTypesId",
                table: "FinancialDataTypes",
                newName: "IX_FinancialDataTypes_ParentFinancialDataTypeId");

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
                keyValue: 5000,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.InsertData(
                table: "FinancialDataTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "ParentFinancialDataTypeId", "ReservationDate" },
                values: new object[] { 4001, "Admin", new DateTime(2023, 2, 21, 23, 5, 36, 40, DateTimeKind.Local).AddTicks(4109), null, null, null, null, "حافز تعويضى 2016", 4000, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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

            migrationBuilder.AddForeignKey(
                name: "FK_FinancialDataTypes_FinancialDataTypes_ParentFinancialDataTypeId",
                table: "FinancialDataTypes",
                column: "ParentFinancialDataTypeId",
                principalTable: "FinancialDataTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FinancialDataTypes_FinancialDataTypes_ParentFinancialDataTypeId",
                table: "FinancialDataTypes");

            migrationBuilder.DeleteData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 4001);

            migrationBuilder.RenameColumn(
                name: "ParentFinancialDataTypeId",
                table: "FinancialDataTypes",
                newName: "FinancialDataTypesId");

            migrationBuilder.RenameIndex(
                name: "IX_FinancialDataTypes_ParentFinancialDataTypeId",
                table: "FinancialDataTypes",
                newName: "IX_FinancialDataTypes_FinancialDataTypesId");

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 396, DateTimeKind.Local).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 396, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2000,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2001,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2002,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2003,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2004,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2005,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2006,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2007,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2008,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2009,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3000,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3001,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3002,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3003,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3004,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3005,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3006,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3007,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 4000,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 5000,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 396, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 396, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 396, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 396, DateTimeKind.Local).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 396, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 396, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 396, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 396, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 396, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.AddForeignKey(
                name: "FK_FinancialDataTypes_FinancialDataTypes_FinancialDataTypesId",
                table: "FinancialDataTypes",
                column: "FinancialDataTypesId",
                principalTable: "FinancialDataTypes",
                principalColumn: "Id");
        }
    }
}
