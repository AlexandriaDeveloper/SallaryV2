using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class FullSallryForm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ta3widi",
                table: "EmployeeBasicSallaries",
                newName: "Taawidi");

            migrationBuilder.CreateTable(
                name: "EmployeeForm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeForm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeForm_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeForm_Form_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeFormCredit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeFormId = table.Column<int>(type: "int", nullable: false),
                    Wazifi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Mokamel = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Taawidi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WazifiReplacment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MokamelReplacment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaawidiReplacment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeFormCredit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeFormCredit_EmployeeForm_EmployeeFormId",
                        column: x => x.EmployeeFormId,
                        principalTable: "EmployeeForm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeFormDebit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeFormId = table.Column<int>(type: "int", nullable: false),
                    Gazzaa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Abscence = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Subscriptions = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Insurance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stamp = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeFormDebit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeFormDebit_EmployeeForm_EmployeeFormId",
                        column: x => x.EmployeeFormId,
                        principalTable: "EmployeeForm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeForm_EmployeeId",
                table: "EmployeeForm",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeForm_FormId",
                table: "EmployeeForm",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeFormCredit_EmployeeFormId",
                table: "EmployeeFormCredit",
                column: "EmployeeFormId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeFormDebit_EmployeeFormId",
                table: "EmployeeFormDebit",
                column: "EmployeeFormId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeFormCredit");

            migrationBuilder.DropTable(
                name: "EmployeeFormDebit");

            migrationBuilder.DropTable(
                name: "EmployeeForm");

            migrationBuilder.RenameColumn(
                name: "Taawidi",
                table: "EmployeeBasicSallaries",
                newName: "Ta3widi");

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 0, 39, 11, 404, DateTimeKind.Local).AddTicks(4940));
        }
    }
}
