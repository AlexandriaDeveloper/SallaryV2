using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Removeorderfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrders_Form_FormId",
                table: "EmployeeOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrders_OrderFiles_OrderFileId",
                table: "EmployeeOrders");

            migrationBuilder.DropTable(
                name: "OrderFiles");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeOrders_OrderFileId",
                table: "EmployeeOrders");

            migrationBuilder.AlterColumn<int>(
                name: "FormId",
                table: "EmployeeOrders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 200, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 200, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 0, 34, 56, 199, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrders_Form_FormId",
                table: "EmployeeOrders",
                column: "FormId",
                principalTable: "Form",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrders_Form_FormId",
                table: "EmployeeOrders");

            migrationBuilder.AlterColumn<int>(
                name: "FormId",
                table: "EmployeeOrders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "OrderFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderFiles", x => x.Id);
                });

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
                name: "IX_EmployeeOrders_OrderFileId",
                table: "EmployeeOrders",
                column: "OrderFileId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrders_Form_FormId",
                table: "EmployeeOrders",
                column: "FormId",
                principalTable: "Form",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrders_OrderFiles_OrderFileId",
                table: "EmployeeOrders",
                column: "OrderFileId",
                principalTable: "OrderFiles",
                principalColumn: "Id");
        }
    }
}
