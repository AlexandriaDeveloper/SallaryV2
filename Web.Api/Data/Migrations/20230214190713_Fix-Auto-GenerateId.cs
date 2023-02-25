using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixAutoGenerateId : Migration
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
                    FinancialDataTypesId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_FinancialDataTypes_FinancialDataTypes_FinancialDataTypesId",
                        column: x => x.FinancialDataTypesId,
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
                    OrderFileId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    CreditOrDebit = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    StartFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndAt = table.Column<DateTime>(type: "datetime2", nullable: true),
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

            migrationBuilder.InsertData(
                table: "BudgetItems",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6854), null, null, null, null, "اجر وظيفى " },
                    { 2, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6856), null, null, null, null, "اجر مكمل" },
                    { 3, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6858), null, null, null, null, "أجر تعويضى" },
                    { 4, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6859), null, null, null, null, "جزاء" },
                    { 5, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6860), null, null, null, null, "غياب" },
                    { 6, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6861), null, null, null, null, "رد مبلغ" },
                    { 7, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6864), null, null, null, null, "أستقطاع مبلغ من المرتب " }
                });

            migrationBuilder.InsertData(
                table: "Collection",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 396, DateTimeKind.Local).AddTicks(5883), null, null, null, null, "مرتبات بطاقات حكوميه" },
                    { 2, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 396, DateTimeKind.Local).AddTicks(5884), null, null, null, null, "مرتبات تحويلات بنكيه" }
                });

            migrationBuilder.InsertData(
                table: "FinancialDataTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FinancialDataTypesId", "ModifiedBy", "ModifiedDate", "Name", "ReservationDate" },
                values: new object[,]
                {
                    { 1000, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6913), null, null, null, null, null, "اجر وظيفى ", new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2000, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6915), null, null, null, null, null, "اجر مكمل", new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3000, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6916), null, null, null, null, null, "اجمالى الاجر ", new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4000, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6917), null, null, null, null, null, "حافز تعويضى", new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5000, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6918), null, null, null, null, null, "اجر الشامل", new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "FinancialYears",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6890), null, null, null, null, "العام المالى 2017-2018" },
                    { 2, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6891), null, null, null, null, "العام المالى 2018-2019" },
                    { 3, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6892), null, null, null, null, "العام المالى 2020-2019" },
                    { 4, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6893), null, null, null, null, "العام المالى 2021-2020" },
                    { 5, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6894), null, null, null, null, "العام المالى 2022-2021" }
                });

            migrationBuilder.InsertData(
                table: "Form",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Details", "FileNumber224", "FileNumber55", "FormDate", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6795), null, null, "مرتبات شهر مارس", "1", "1", "2022-3", null, null },
                    { 2, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6798), null, null, "مرتبات شهر ابريل", "1", "1", "2022-4", null, null },
                    { 3, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6799), null, null, "مرتبات شهر مايو", "2", "2", "2022-5", null, null },
                    { 4, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6828), null, null, "مرتبات شهر يونيو", "3", "3", "2022-6", null, null }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "ParentId", "Priority" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7042), null, null, null, null, "الممتازة", null, null },
                    { 2, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7044), null, null, null, null, "العاليه", null, null },
                    { 3, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7045), null, null, null, null, "كبير", null, null },
                    { 4, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7046), null, null, null, null, "الاولى", null, null },
                    { 7, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7051), null, null, null, null, "الثانيه", null, null },
                    { 10, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7055), null, null, null, null, "الثالثه", null, null },
                    { 14, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7059), null, null, null, null, "الرابعه", null, null },
                    { 17, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7063), null, null, null, null, "الخامسه", null, null },
                    { 20, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7066), null, null, null, null, "السادسه", null, null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6649), null, null, null, null, "غياب بدون إذن" },
                    { 2, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6663), null, null, null, null, "امر عقاب جزاء عن الغياب بدون إذن" },
                    { 3, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6664), null, null, null, null, "أمر عقاب خصم من مكافأة الامتحانات" },
                    { 4, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6665), null, null, null, null, "أجازة بدون مرتب" },
                    { 5, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6666), null, null, null, null, "أمر أستراداد مبلغ" },
                    { 6, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6667), null, null, null, null, "أستقطاع مبلغ ثابت" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6991), null, null, null, null, "تأمين علاجى" },
                    { 2, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6993), null, null, null, null, "نقابه" },
                    { 3, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6994), null, null, null, null, "محمول شركة ETI" },
                    { 4, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6995), null, null, null, null, "محمول شركه سيجنال " },
                    { 5, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6996), null, null, null, null, "خزنه تك  " },
                    { 6, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6996), null, null, null, null, "نفقه  " }
                });

            migrationBuilder.InsertData(
                table: "FinancialDataTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FinancialDataTypesId", "ModifiedBy", "ModifiedDate", "Name", "ReservationDate" },
                values: new object[,]
                {
                    { 1002, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6924), null, null, 1000, null, null, "الاساسى", new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1003, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6925), null, null, 1000, null, null, "100% من الاساسى", new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1004, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6929), null, null, 1000, null, null, "بدل حد ادنى", new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1005, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6944), null, null, 1000, null, null, "علاوات غير مضمومه", new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1006, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6945), null, null, 1000, null, null, "بدل علاوة اجتماعيه و منحة", new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2001, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6955), null, null, 2000, null, null, "50% من الاساسى", new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2002, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6957), null, null, 2000, null, null, "بدل جودة", new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2003, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6958), null, null, 2000, null, null, "بدل حد ادنى", new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2004, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6959), null, null, 2000, null, null, "2019 حافز", new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2005, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6961), null, null, 2000, null, null, "2020 حافز", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2006, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6963), null, null, 2000, null, null, "2021 حافز", new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2007, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6964), null, null, 2000, null, null, "2022 حافز", new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2008, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6965), null, null, 2000, null, null, "بدل غلاء معيشه 2022 ", new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2009, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6966), null, null, 2000, null, null, "حافز اضافى", new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3001, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6946), null, null, 3000, null, null, "الاساسى", new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3002, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6948), null, null, 3000, null, null, "علاوات غير مضمومه", new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3003, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6949), null, null, 3000, null, null, "المنحة", new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3004, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6950), null, null, 3000, null, null, "علاوة اجتماعيه", new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3005, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6951), null, null, 3000, null, null, "علاوة اضافيه", new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3006, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6953), null, null, 3000, null, null, "بدل عدوى", new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3007, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(6954), null, null, 3000, null, null, "150% من الاساسى", new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "ParentId", "Priority" },
                values: new object[,]
                {
                    { 5, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7049), null, null, null, null, "الاولى-أ", 4, 1 },
                    { 6, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7050), null, null, null, null, "الاولى-ب", 4, 2 },
                    { 8, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7052), null, null, null, null, "الثانيه-أ", 7, 1 },
                    { 9, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7054), null, null, null, null, "الثانيه-ب", 7, 2 },
                    { 11, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7056), null, null, null, null, "الثالثه-أ", 10, 1 },
                    { 12, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7057), null, null, null, null, "الثالثه-ب", 10, 2 },
                    { 13, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7058), null, null, null, null, "الثالثه-ج", 10, 3 },
                    { 15, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7060), null, null, null, null, "الرابعه-أ", 14, 1 },
                    { 16, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7062), null, null, null, null, "الرابعه-ب", 14, 2 },
                    { 18, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7064), null, null, null, null, "الخامسه-أ", 17, 1 },
                    { 19, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7065), null, null, null, null, "الخامسه-ب", 17, 2 },
                    { 21, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7067), null, null, null, null, "السادسه-أ", 20, 1 },
                    { 22, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 394, DateTimeKind.Local).AddTicks(7069), null, null, null, null, "السادسه-ب", 20, 2 }
                });

            migrationBuilder.InsertData(
                table: "MinimumSallary",
                columns: new[] { "Id", "Amount", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "GradeId", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, 170m, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 396, DateTimeKind.Local).AddTicks(5781), null, null, 1, null, null },
                    { 2, 170m, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 396, DateTimeKind.Local).AddTicks(5788), null, null, 2, null, null },
                    { 3, 170m, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 396, DateTimeKind.Local).AddTicks(5789), null, null, 3, null, null },
                    { 4, 255m, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 396, DateTimeKind.Local).AddTicks(5791), null, null, 4, null, null },
                    { 5, 300m, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 396, DateTimeKind.Local).AddTicks(5792), null, null, 7, null, null },
                    { 6, 340m, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 396, DateTimeKind.Local).AddTicks(5793), null, null, 10, null, null },
                    { 7, 385m, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 396, DateTimeKind.Local).AddTicks(5794), null, null, 14, null, null },
                    { 8, 400m, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 396, DateTimeKind.Local).AddTicks(5795), null, null, 17, null, null },
                    { 9, 400m, "Admin", new DateTime(2023, 2, 14, 21, 7, 11, 396, DateTimeKind.Local).AddTicks(5796), null, null, 20, null, null }
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
                name: "IX_EmployeeBasicFinancialData_EmployeeId",
                table: "EmployeeBasicFinancialData",
                column: "EmployeeId");

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
                name: "IX_FinancialDataTypes_FinancialDataTypesId",
                table: "FinancialDataTypes",
                column: "FinancialDataTypesId");

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
