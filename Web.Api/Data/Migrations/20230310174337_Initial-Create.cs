using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bank",
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
                    table.PrimaryKey("PK_Bank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BudgetItems",
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
                    table.PrimaryKey("PK_BudgetItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Collection",
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
                    table.PrimaryKey("PK_Collection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinancialDataTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ParentFinancialDataTypeId = table.Column<int>(type: "int", nullable: true),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.PrimaryKey("PK_FinancialDataTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinancialDataTypes_FinancialDataTypes_ParentFinancialDataTypeId",
                        column: x => x.ParentFinancialDataTypeId,
                        principalTable: "FinancialDataTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FinancialYears",
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
                    table.PrimaryKey("PK_FinancialYears", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Form",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Details = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    FormDate = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FileNumber55 = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    FileNumber224 = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_Grades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grades_Grades_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Grades",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
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
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
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
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VacationType",
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
                    table.PrimaryKey("PK_VacationType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Branch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branch_Bank_BankId",
                        column: x => x.BankId,
                        principalTable: "Bank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MinimumSallary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MinimumSallary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MinimumSallary_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeBanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(22)", maxLength: 22, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeBanks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeBanks_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalId = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    TabCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    TegaraCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    CollageName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Section = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    EmployeeBankId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_EmployeeBanks_EmployeeBankId",
                        column: x => x.EmployeeBankId,
                        principalTable: "EmployeeBanks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeBasicFinancialData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    FinancialDataTypesId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeBasicFinancialData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeBasicFinancialData_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeBasicFinancialData_FinancialDataTypes_FinancialDataTypesId",
                        column: x => x.FinancialDataTypesId,
                        principalTable: "FinancialDataTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeBasicSallaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    FinancialYearId = table.Column<int>(type: "int", nullable: false),
                    BasicSallary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Wazifi = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Mokamel = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Taawidi = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeBasicSallaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeBasicSallaries_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeBasicSallaries_FinancialYears_FinancialYearId",
                        column: x => x.FinancialYearId,
                        principalTable: "FinancialYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeCollections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CollectionId = table.Column<int>(type: "int", nullable: false),
                    EmployeeOrderInCollection = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeCollections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeCollections_Collection_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "Collection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeCollections_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeOrderNumber = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeForms_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeForms_Form_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false),
                    StartFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmployeeGradeId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeGrades_EmployeeGrades_EmployeeGradeId",
                        column: x => x.EmployeeGradeId,
                        principalTable: "EmployeeGrades",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeGrades_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeGrades_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Details = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    CreditOrDebit = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeOrders_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeOrders_Form_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesPartTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                    table.PrimaryKey("PK_EmployeesPartTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeesPartTimes_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSubscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Details = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    SubscriptionId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSubscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeSubscriptions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeSubscriptions_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PeriodicSubscription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionId = table.Column<int>(type: "int", nullable: false),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreditOrDebit = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodicSubscription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PeriodicSubscription_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeriodicSubscription_Form_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeriodicSubscription_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
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
                        name: "FK_EmployeeFormCredit_EmployeeForms_EmployeeFormId",
                        column: x => x.EmployeeFormId,
                        principalTable: "EmployeeForms",
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
                        name: "FK_EmployeeFormDebit_EmployeeForms_EmployeeFormId",
                        column: x => x.EmployeeFormId,
                        principalTable: "EmployeeForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeOrderExecuations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BudgetItemId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployeeOrderId = table.Column<int>(type: "int", nullable: false),
                    SubscriptionId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeOrderExecuations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeOrderExecuations_BudgetItems_BudgetItemId",
                        column: x => x.BudgetItemId,
                        principalTable: "BudgetItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeOrderExecuations_EmployeeOrders_EmployeeOrderId",
                        column: x => x.EmployeeOrderId,
                        principalTable: "EmployeeOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeOrderExecuations_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeVacationType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Qunatity = table.Column<int>(type: "int", nullable: true),
                    VacationTypeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeOrderId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeVacationType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeVacationType_EmployeeOrders_EmployeeOrderId",
                        column: x => x.EmployeeOrderId,
                        principalTable: "EmployeeOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeVacationType_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeVacationType_VacationType_VacationTypeId",
                        column: x => x.VacationTypeId,
                        principalTable: "VacationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BudgetItems",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2077), null, null, null, null, "اجر وظيفى " },
                    { 2, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2078), null, null, null, null, "اجر مكمل" },
                    { 3, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2079), null, null, null, null, "أجر تعويضى" },
                    { 4, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2080), null, null, null, null, "جزاء" },
                    { 5, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2081), null, null, null, null, "إيرادات" },
                    { 6, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2082), null, null, null, null, "مرتدات" },
                    { 7, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2083), null, null, null, null, "أسترداد" }
                });

            migrationBuilder.InsertData(
                table: "Collection",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(257), null, null, null, null, "مرتبات بطاقات حكوميه" },
                    { 2, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(259), null, null, null, null, "مرتبات تحويلات بنكيه" }
                });

            migrationBuilder.InsertData(
                table: "FinancialDataTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "ParentFinancialDataTypeId", "ReservationDate" },
                values: new object[,]
                {
                    { 1000, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2130), null, null, null, null, "اجر وظيفى ", null, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2000, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2131), null, null, null, null, "اجر مكمل", null, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3000, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2132), null, null, null, null, "اجمالى الاجر ", null, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4000, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2133), null, null, null, null, "حافز تعويضى", null, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5000, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2159), null, null, null, null, "اجر الشامل", null, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "FinancialYears",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2105), null, null, null, null, "العام المالى 2017-2018" },
                    { 2, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2106), null, null, null, null, "العام المالى 2018-2019" },
                    { 3, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2107), null, null, null, null, "العام المالى 2020-2019" },
                    { 4, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2108), null, null, null, null, "العام المالى 2021-2020" },
                    { 5, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2109), null, null, null, null, "العام المالى 2022-2021" }
                });

            migrationBuilder.InsertData(
                table: "Form",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Details", "FileNumber224", "FileNumber55", "FormDate", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2045), null, null, "مرتبات شهر مارس", "1", "1", "2022-3", null, null },
                    { 2, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2048), null, null, "مرتبات شهر ابريل", "1", "1", "2022-4", null, null },
                    { 3, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2050), null, null, "مرتبات شهر مايو", "2", "2", "2022-5", null, null },
                    { 4, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2051), null, null, "مرتبات شهر يونيو", "3", "3", "2022-6", null, null }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "ParentId", "Priority" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2273), null, null, null, null, "الممتازة", null, null },
                    { 2, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2274), null, null, null, null, "العاليه", null, null },
                    { 3, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2275), null, null, null, null, "كبير", null, null },
                    { 4, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2276), null, null, null, null, "الاولى", null, null },
                    { 7, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2281), null, null, null, null, "الثانيه", null, null },
                    { 10, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2324), null, null, null, null, "الثالثه", null, null },
                    { 14, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2329), null, null, null, null, "الرابعه", null, null },
                    { 17, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2332), null, null, null, null, "الخامسه", null, null },
                    { 20, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2336), null, null, null, null, "السادسه", null, null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(1896), null, null, null, null, "غياب بدون إذن" },
                    { 2, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(1911), null, null, null, null, "امر عقاب جزاء عن الغياب بدون إذن" },
                    { 3, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(1913), null, null, null, null, "أمر عقاب خصم من مكافأة الامتحانات" },
                    { 4, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(1914), null, null, null, null, "أمر أستراداد مبلغ" },
                    { 5, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(1915), null, null, null, null, "أستقطاع مبلغ ثابت ايرادات" },
                    { 6, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(1916), null, null, null, null, "أستقطاع مبلغ ثابت مرتدات" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2248), null, null, null, null, "تأمين علاجى" },
                    { 2, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2250), null, null, null, null, "نقابه" },
                    { 3, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2250), null, null, null, null, "محمول شركة ETI" },
                    { 4, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2252), null, null, null, null, "محمول شركه سيجنال " },
                    { 5, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2253), null, null, null, null, "خزنه تك  " },
                    { 6, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2254), null, null, null, null, "نفقه  " }
                });

            migrationBuilder.InsertData(
                table: "VacationType",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(282), null, null, null, null, "اجازة بدون مرتب" },
                    { 2, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(284), null, null, null, null, "جزء من الوقت" },
                    { 3, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(284), null, null, null, null, "انتداب جزئى" },
                    { 4, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(286), null, null, null, null, "انتداب كلى" }
                });

            migrationBuilder.InsertData(
                table: "FinancialDataTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "ParentFinancialDataTypeId", "ReservationDate" },
                values: new object[,]
                {
                    { 1002, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2164), null, null, null, null, "الاساسى", 1000, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1003, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2166), null, null, null, null, "100% من الاساسى", 1000, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1004, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2170), null, null, null, null, "بدل حد ادنى", 1000, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1005, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2181), null, null, null, null, "علاوات غير مضمومه", 1000, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1006, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2183), null, null, null, null, "بدل علاوة اجتماعيه و منحة", 1000, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1007, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2184), null, null, null, null, "علاوة دوريه 2015", 1000, new DateTime(2015, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1008, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2186), null, null, null, null, "علاوة دوريه 2016", 1000, new DateTime(2016, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1009, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2187), null, null, null, null, "علاوة دوريه 2017", 1000, new DateTime(2017, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1010, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2189), null, null, null, null, "علاوة استثنائيه 2017", 1000, new DateTime(2017, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1011, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2190), null, null, null, null, "علاوة دوريه 2018", 1000, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1012, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2191), null, null, null, null, "علاوة استثنائيه 2018", 1000, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1013, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2193), null, null, null, null, "علاوة دوريه 2019", 1000, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1014, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2194), null, null, null, null, "علاوة دوريه 2020", 1000, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1015, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2195), null, null, null, null, "علاوة دوريه 2021", 1000, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1016, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2197), null, null, null, null, "علاوة دوريه 2022", 1000, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2001, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2207), null, null, null, null, "50% من الاساسى", 2000, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2002, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2208), null, null, null, null, "بدل جودة", 2000, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2003, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2213), null, null, null, null, "بدل حد ادنى", 2000, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2004, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2214), null, null, null, null, "2019 حافز", 2000, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2005, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2216), null, null, null, null, "2020 حافز", 2000, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2006, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2217), null, null, null, null, "2021 حافز", 2000, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2007, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2218), null, null, null, null, "2022 حافز", 2000, new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2008, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2219), null, null, null, null, "بدل غلاء معيشه 2022 ", 2000, new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2009, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2221), null, null, null, null, "حافز اضافى", 2000, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3001, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2198), null, null, null, null, "الاساسى", 3000, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3002, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2199), null, null, null, null, "علاوات غير مضمومه", 3000, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3003, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2200), null, null, null, null, "المنحة", 3000, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3004, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2202), null, null, null, null, "علاوة اجتماعيه", 3000, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3005, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2203), null, null, null, null, "علاوة اضافيه", 3000, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3006, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2204), null, null, null, null, "بدل عدوى", 3000, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3007, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2205), null, null, null, null, "150% من الاساسى", 3000, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4001, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2222), null, null, null, null, "حافز تعويضى 2016", 4000, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "ParentId", "Priority" },
                values: new object[,]
                {
                    { 5, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2279), null, null, null, null, "الاولى-أ", 4, 1 },
                    { 6, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2280), null, null, null, null, "الاولى-ب", 4, 2 },
                    { 8, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2282), null, null, null, null, "الثانيه-أ", 7, 1 },
                    { 9, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2323), null, null, null, null, "الثانيه-ب", 7, 2 },
                    { 11, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2325), null, null, null, null, "الثالثه-أ", 10, 1 },
                    { 12, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2327), null, null, null, null, "الثالثه-ب", 10, 2 },
                    { 13, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2328), null, null, null, null, "الثالثه-ج", 10, 3 },
                    { 15, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2330), null, null, null, null, "الرابعه-أ", 14, 1 },
                    { 16, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2331), null, null, null, null, "الرابعه-ب", 14, 2 },
                    { 18, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2333), null, null, null, null, "الخامسه-أ", 17, 1 },
                    { 19, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2335), null, null, null, null, "الخامسه-ب", 17, 2 },
                    { 21, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2337), null, null, null, null, "السادسه-أ", 20, 1 },
                    { 22, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 516, DateTimeKind.Local).AddTicks(2338), null, null, null, null, "السادسه-ب", 20, 2 }
                });

            migrationBuilder.InsertData(
                table: "MinimumSallary",
                columns: new[] { "Id", "Amount", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "GradeId", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, 170m, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(152), null, null, 1, null, null },
                    { 2, 170m, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(157), null, null, 2, null, null },
                    { 3, 170m, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(158), null, null, 3, null, null },
                    { 4, 255m, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(159), null, null, 4, null, null },
                    { 5, 300m, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(160), null, null, 7, null, null },
                    { 6, 340m, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(161), null, null, 10, null, null },
                    { 7, 385m, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(163), null, null, 14, null, null },
                    { 8, 400m, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(164), null, null, 17, null, null },
                    { 9, 400m, "Admin", new DateTime(2023, 3, 10, 19, 43, 35, 518, DateTimeKind.Local).AddTicks(193), null, null, 20, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branch_BankId",
                table: "Branch",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBanks_BranchId",
                table: "EmployeeBanks",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBasicFinancialData_EmployeeId_FinancialDataTypesId",
                table: "EmployeeBasicFinancialData",
                columns: new[] { "EmployeeId", "FinancialDataTypesId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBasicFinancialData_FinancialDataTypesId",
                table: "EmployeeBasicFinancialData",
                column: "FinancialDataTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBasicSallaries_EmployeeId_FinancialYearId",
                table: "EmployeeBasicSallaries",
                columns: new[] { "EmployeeId", "FinancialYearId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBasicSallaries_FinancialYearId",
                table: "EmployeeBasicSallaries",
                column: "FinancialYearId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCollections_CollectionId",
                table: "EmployeeCollections",
                column: "CollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCollections_EmployeeId_CollectionId",
                table: "EmployeeCollections",
                columns: new[] { "EmployeeId", "CollectionId" },
                unique: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeForms_EmployeeId_FormId",
                table: "EmployeeForms",
                columns: new[] { "EmployeeId", "FormId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeForms_FormId",
                table: "EmployeeForms",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeGrades_EmployeeGradeId",
                table: "EmployeeGrades",
                column: "EmployeeGradeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeGrades_EmployeeId_GradeId",
                table: "EmployeeGrades",
                columns: new[] { "EmployeeId", "GradeId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeGrades_GradeId",
                table: "EmployeeGrades",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrderExecuations_BudgetItemId",
                table: "EmployeeOrderExecuations",
                column: "BudgetItemId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrderExecuations_EmployeeOrderId",
                table: "EmployeeOrderExecuations",
                column: "EmployeeOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrderExecuations_SubscriptionId",
                table: "EmployeeOrderExecuations",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrders_EmployeeId",
                table: "EmployeeOrders",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrders_FormId",
                table: "EmployeeOrders",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrders_OrderId",
                table: "EmployeeOrders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeBankId",
                table: "Employees",
                column: "EmployeeBankId",
                unique: true,
                filter: "[EmployeeBankId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_NationalId",
                table: "Employees",
                column: "NationalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_TabCode",
                table: "Employees",
                column: "TabCode",
                unique: true,
                filter: "[TabCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesPartTimes_EmployeeId",
                table: "EmployeesPartTimes",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSubscriptions_EmployeeId_SubscriptionId",
                table: "EmployeeSubscriptions",
                columns: new[] { "EmployeeId", "SubscriptionId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSubscriptions_SubscriptionId",
                table: "EmployeeSubscriptions",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeVacationType_EmployeeId",
                table: "EmployeeVacationType",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeVacationType_EmployeeOrderId",
                table: "EmployeeVacationType",
                column: "EmployeeOrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeVacationType_VacationTypeId",
                table: "EmployeeVacationType",
                column: "VacationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialDataTypes_ParentFinancialDataTypeId",
                table: "FinancialDataTypes",
                column: "ParentFinancialDataTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_ParentId",
                table: "Grades",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_MinimumSallary_GradeId",
                table: "MinimumSallary",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_PeriodicSubscription_EmployeeId_FormId_SubscriptionId_CreditOrDebit",
                table: "PeriodicSubscription",
                columns: new[] { "EmployeeId", "FormId", "SubscriptionId", "CreditOrDebit" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PeriodicSubscription_FormId",
                table: "PeriodicSubscription",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_PeriodicSubscription_SubscriptionId",
                table: "PeriodicSubscription",
                column: "SubscriptionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeBasicFinancialData");

            migrationBuilder.DropTable(
                name: "EmployeeBasicSallaries");

            migrationBuilder.DropTable(
                name: "EmployeeCollections");

            migrationBuilder.DropTable(
                name: "EmployeeFormCredit");

            migrationBuilder.DropTable(
                name: "EmployeeFormDebit");

            migrationBuilder.DropTable(
                name: "EmployeeGrades");

            migrationBuilder.DropTable(
                name: "EmployeeOrderExecuations");

            migrationBuilder.DropTable(
                name: "EmployeesPartTimes");

            migrationBuilder.DropTable(
                name: "EmployeeSubscriptions");

            migrationBuilder.DropTable(
                name: "EmployeeVacationType");

            migrationBuilder.DropTable(
                name: "MinimumSallary");

            migrationBuilder.DropTable(
                name: "PeriodicSubscription");

            migrationBuilder.DropTable(
                name: "FinancialDataTypes");

            migrationBuilder.DropTable(
                name: "FinancialYears");

            migrationBuilder.DropTable(
                name: "Collection");

            migrationBuilder.DropTable(
                name: "EmployeeForms");

            migrationBuilder.DropTable(
                name: "BudgetItems");

            migrationBuilder.DropTable(
                name: "EmployeeOrders");

            migrationBuilder.DropTable(
                name: "VacationType");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Form");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "EmployeeBanks");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "Bank");
        }
    }
}
