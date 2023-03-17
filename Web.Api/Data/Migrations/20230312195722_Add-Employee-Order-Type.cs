using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeOrderType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrderExecuations_EmployeeOrders_EmployeeOrderId",
                table: "EmployeeOrderExecuations");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrderExecuations_Subscriptions_SubscriptionId",
                table: "EmployeeOrderExecuations");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrders_Form_FormId",
                table: "EmployeeOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrders_Orders_OrderId",
                table: "EmployeeOrders");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeOrderExecuations_SubscriptionId",
                table: "EmployeeOrderExecuations");

            migrationBuilder.DropColumn(
                name: "CreditOrDebit",
                table: "EmployeeOrders");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "EmployeeOrders");

            migrationBuilder.DropColumn(
                name: "SubscriptionId",
                table: "EmployeeOrderExecuations");

            migrationBuilder.RenameColumn(
                name: "EmployeeOrderId",
                table: "EmployeeOrderExecuations",
                newName: "EmployeeOrderTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeOrderExecuations_EmployeeOrderId",
                table: "EmployeeOrderExecuations",
                newName: "IX_EmployeeOrderExecuations_EmployeeOrderTypeId");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "EmployeeOrders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FormId",
                table: "EmployeeOrders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "EmployeeOrderType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    EmployeeOrderId = table.Column<int>(type: "int", nullable: false),
                    CreditOrDebit = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeOrderType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeOrderType_EmployeeOrders_EmployeeOrderId",
                        column: x => x.EmployeeOrderId,
                        principalTable: "EmployeeOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeOrderType_Form_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeOrderType_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_EmployeeOrderType_EmployeeOrderId",
                table: "EmployeeOrderType",
                column: "EmployeeOrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrderType_FormId",
                table: "EmployeeOrderType",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrderType_OrderId",
                table: "EmployeeOrderType",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrderExecuations_EmployeeOrderType_EmployeeOrderTypeId",
                table: "EmployeeOrderExecuations",
                column: "EmployeeOrderTypeId",
                principalTable: "EmployeeOrderType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrders_Form_FormId",
                table: "EmployeeOrders",
                column: "FormId",
                principalTable: "Form",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrders_Orders_OrderId",
                table: "EmployeeOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrderExecuations_EmployeeOrderType_EmployeeOrderTypeId",
                table: "EmployeeOrderExecuations");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrders_Form_FormId",
                table: "EmployeeOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrders_Orders_OrderId",
                table: "EmployeeOrders");

            migrationBuilder.DropTable(
                name: "EmployeeOrderType");

            migrationBuilder.RenameColumn(
                name: "EmployeeOrderTypeId",
                table: "EmployeeOrderExecuations",
                newName: "EmployeeOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeOrderExecuations_EmployeeOrderTypeId",
                table: "EmployeeOrderExecuations",
                newName: "IX_EmployeeOrderExecuations_EmployeeOrderId");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "EmployeeOrders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FormId",
                table: "EmployeeOrders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreditOrDebit",
                table: "EmployeeOrders",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "EmployeeOrders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionId",
                table: "EmployeeOrderExecuations",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1002,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1003,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1004,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1005,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1006,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1007,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1008,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1009,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1010,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1011,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1012,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1013,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1014,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1015,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 1016,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2001,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2002,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2003,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2004,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2005,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2006,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2007,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2008,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 2009,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3001,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3002,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3003,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3004,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3005,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3006,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 3007,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 4000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 4001,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "FinancialDataTypes",
                keyColumn: "Id",
                keyValue: 5000,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "MinimumSallary",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "VacationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "VacationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "VacationType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "VacationType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrderExecuations_SubscriptionId",
                table: "EmployeeOrderExecuations",
                column: "SubscriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrderExecuations_EmployeeOrders_EmployeeOrderId",
                table: "EmployeeOrderExecuations",
                column: "EmployeeOrderId",
                principalTable: "EmployeeOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrderExecuations_Subscriptions_SubscriptionId",
                table: "EmployeeOrderExecuations",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrders_Form_FormId",
                table: "EmployeeOrders",
                column: "FormId",
                principalTable: "Form",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrders_Orders_OrderId",
                table: "EmployeeOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
