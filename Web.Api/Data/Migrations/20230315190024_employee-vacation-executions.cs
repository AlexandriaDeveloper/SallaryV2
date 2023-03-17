using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class employeevacationexecutions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeVacationType_Employees_EmployeeId",
                table: "EmployeeVacationType");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeVacationType_VacationType_VacationTypeId",
                table: "EmployeeVacationType");

            migrationBuilder.DropTable(
                name: "VacationType");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeVacationType_EmployeeId",
                table: "EmployeeVacationType");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "EmployeeVacationType");

            migrationBuilder.RenameColumn(
                name: "VacationTypeId",
                table: "EmployeeVacationType",
                newName: "VacationId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeVacationType_VacationTypeId",
                table: "EmployeeVacationType",
                newName: "IX_EmployeeVacationType_VacationId");

            migrationBuilder.CreateTable(
                name: "EmployeeVacationTypeExecuation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BudgetItemId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployeeVacationTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeVacationTypeExecuation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeVacationTypeExecuation_BudgetItems_BudgetItemId",
                        column: x => x.BudgetItemId,
                        principalTable: "BudgetItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeVacationTypeExecuation_EmployeeVacationType_EmployeeVacationTypeId",
                        column: x => x.EmployeeVacationTypeId,
                        principalTable: "EmployeeVacationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vacation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacation", x => x.Id);
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

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 15, 21, 0, 22, 712, DateTimeKind.Local).AddTicks(1631));

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

            migrationBuilder.InsertData(
                table: "Vacation",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 3, 15, 21, 0, 22, 713, DateTimeKind.Local).AddTicks(9641), null, null, null, null, "اجازة بدون مرتب" },
                    { 2, "Admin", new DateTime(2023, 3, 15, 21, 0, 22, 713, DateTimeKind.Local).AddTicks(9642), null, null, null, null, "جزء من الوقت" },
                    { 3, "Admin", new DateTime(2023, 3, 15, 21, 0, 22, 713, DateTimeKind.Local).AddTicks(9643), null, null, null, null, "انتداب جزئى" },
                    { 4, "Admin", new DateTime(2023, 3, 15, 21, 0, 22, 713, DateTimeKind.Local).AddTicks(9644), null, null, null, null, "انتداب كلى" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeVacationTypeExecuation_BudgetItemId",
                table: "EmployeeVacationTypeExecuation",
                column: "BudgetItemId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeVacationTypeExecuation_EmployeeVacationTypeId",
                table: "EmployeeVacationTypeExecuation",
                column: "EmployeeVacationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeVacationType_Vacation_VacationId",
                table: "EmployeeVacationType",
                column: "VacationId",
                principalTable: "Vacation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeVacationType_Vacation_VacationId",
                table: "EmployeeVacationType");

            migrationBuilder.DropTable(
                name: "EmployeeVacationTypeExecuation");

            migrationBuilder.DropTable(
                name: "Vacation");

            migrationBuilder.RenameColumn(
                name: "VacationId",
                table: "EmployeeVacationType",
                newName: "VacationTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeVacationType_VacationId",
                table: "EmployeeVacationType",
                newName: "IX_EmployeeVacationType_VacationTypeId");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "EmployeeVacationType",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VacationType",
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
                    table.PrimaryKey("PK_VacationType", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "VacationType",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 3, 15, 12, 27, 3, 160, DateTimeKind.Local).AddTicks(8472), null, null, null, null, "اجازة بدون مرتب" },
                    { 2, "Admin", new DateTime(2023, 3, 15, 12, 27, 3, 160, DateTimeKind.Local).AddTicks(8473), null, null, null, null, "جزء من الوقت" },
                    { 3, "Admin", new DateTime(2023, 3, 15, 12, 27, 3, 160, DateTimeKind.Local).AddTicks(8474), null, null, null, null, "انتداب جزئى" },
                    { 4, "Admin", new DateTime(2023, 3, 15, 12, 27, 3, 160, DateTimeKind.Local).AddTicks(8475), null, null, null, null, "انتداب كلى" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeVacationType_EmployeeId",
                table: "EmployeeVacationType",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeVacationType_Employees_EmployeeId",
                table: "EmployeeVacationType",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeVacationType_VacationType_VacationTypeId",
                table: "EmployeeVacationType",
                column: "VacationTypeId",
                principalTable: "VacationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
