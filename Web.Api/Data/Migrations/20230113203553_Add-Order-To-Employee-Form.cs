using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderToEmployeeForm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeForm_Employees_EmployeeId",
                table: "EmployeeForm");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeForm_Form_FormId",
                table: "EmployeeForm");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeFormCredit_EmployeeForm_EmployeeFormId",
                table: "EmployeeFormCredit");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeFormDebit_EmployeeForm_EmployeeFormId",
                table: "EmployeeFormDebit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeForm",
                table: "EmployeeForm");

            migrationBuilder.RenameTable(
                name: "EmployeeForm",
                newName: "EmployeeForms");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeForm_FormId",
                table: "EmployeeForms",
                newName: "IX_EmployeeForms_FormId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeForm_EmployeeId",
                table: "EmployeeForms",
                newName: "IX_EmployeeForms_EmployeeId");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeOrderNumber",
                table: "EmployeeForms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeForms",
                table: "EmployeeForms",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeFormCredit_EmployeeForms_EmployeeFormId",
                table: "EmployeeFormCredit",
                column: "EmployeeFormId",
                principalTable: "EmployeeForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeFormDebit_EmployeeForms_EmployeeFormId",
                table: "EmployeeFormDebit",
                column: "EmployeeFormId",
                principalTable: "EmployeeForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeForms_Employees_EmployeeId",
                table: "EmployeeForms",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeForms_Form_FormId",
                table: "EmployeeForms",
                column: "FormId",
                principalTable: "Form",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeFormCredit_EmployeeForms_EmployeeFormId",
                table: "EmployeeFormCredit");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeFormDebit_EmployeeForms_EmployeeFormId",
                table: "EmployeeFormDebit");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeForms_Employees_EmployeeId",
                table: "EmployeeForms");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeForms_Form_FormId",
                table: "EmployeeForms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeForms",
                table: "EmployeeForms");

            migrationBuilder.DropColumn(
                name: "EmployeeOrderNumber",
                table: "EmployeeForms");

            migrationBuilder.RenameTable(
                name: "EmployeeForms",
                newName: "EmployeeForm");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeForms_FormId",
                table: "EmployeeForm",
                newName: "IX_EmployeeForm_FormId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeForms_EmployeeId",
                table: "EmployeeForm",
                newName: "IX_EmployeeForm_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeForm",
                table: "EmployeeForm",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 13, 13, 55, 58, 810, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeForm_Employees_EmployeeId",
                table: "EmployeeForm",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeForm_Form_FormId",
                table: "EmployeeForm",
                column: "FormId",
                principalTable: "Form",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeFormCredit_EmployeeForm_EmployeeFormId",
                table: "EmployeeFormCredit",
                column: "EmployeeFormId",
                principalTable: "EmployeeForm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeFormDebit_EmployeeForm_EmployeeFormId",
                table: "EmployeeFormDebit",
                column: "EmployeeFormId",
                principalTable: "EmployeeForm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
