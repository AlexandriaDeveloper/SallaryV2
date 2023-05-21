using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                name: "Qanon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qanon", x => x.Id);
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
                name: "FinancialDataTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ParentFinancialDataTypeId = table.Column<int>(type: "int", nullable: true),
                    QanonId = table.Column<int>(type: "int", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_FinancialDataTypes_Qanon_QanonId",
                        column: x => x.QanonId,
                        principalTable: "Qanon",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeBankAccounts",
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
                    table.PrimaryKey("PK_EmployeeBankAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeBankAccounts_Branch_BranchId",
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
                    QanonId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Employees_EmployeeBankAccounts_EmployeeBankId",
                        column: x => x.EmployeeBankId,
                        principalTable: "EmployeeBankAccounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employees_Qanon_QanonId",
                        column: x => x.QanonId,
                        principalTable: "Qanon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "FormEmployees",
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
                    table.PrimaryKey("PK_FormEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormEmployees_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormEmployees_Form_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegisterdEmployeeSubscriptions",
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
                    table.PrimaryKey("PK_RegisterdEmployeeSubscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegisterdEmployeeSubscriptions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegisterdEmployeeSubscriptions_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormEmployeeCredit",
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
                    table.PrimaryKey("PK_FormEmployeeCredit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormEmployeeCredit_FormEmployees_EmployeeFormId",
                        column: x => x.EmployeeFormId,
                        principalTable: "FormEmployees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormEmployeemDebit",
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
                    table.PrimaryKey("PK_FormEmployeemDebit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormEmployeemDebit_FormEmployees_EmployeeFormId",
                        column: x => x.EmployeeFormId,
                        principalTable: "FormEmployees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormEmployeeOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Details = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FormEmployeeId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    CreditOrDebit = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    SelectedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormEmployeeOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormEmployeeOrders_FormEmployees_FormEmployeeId",
                        column: x => x.FormEmployeeId,
                        principalTable: "FormEmployees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormEmployeeOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormEmployeeSubscription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionId = table.Column<int>(type: "int", nullable: false),
                    FormEmployeeId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_FormEmployeeSubscription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormEmployeeSubscription_FormEmployees_FormEmployeeId",
                        column: x => x.FormEmployeeId,
                        principalTable: "FormEmployees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormEmployeeSubscription_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormEmployeeVacation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qunatity = table.Column<int>(type: "int", nullable: true),
                    VacationId = table.Column<int>(type: "int", nullable: false),
                    FormEmployeeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormEmployeeVacation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormEmployeeVacation_FormEmployees_FormEmployeeId",
                        column: x => x.FormEmployeeId,
                        principalTable: "FormEmployees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormEmployeeVacation_Vacation_VacationId",
                        column: x => x.VacationId,
                        principalTable: "Vacation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormEmployeeOrderExecuations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BudgetItemId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FormEmployeeOrderId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormEmployeeOrderExecuations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormEmployeeOrderExecuations_BudgetItems_BudgetItemId",
                        column: x => x.BudgetItemId,
                        principalTable: "BudgetItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormEmployeeOrderExecuations_FormEmployeeOrders_FormEmployeeOrderId",
                        column: x => x.FormEmployeeOrderId,
                        principalTable: "FormEmployeeOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeVacationExecuation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BudgetItemId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FormEmployeeVacationId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeVacationExecuation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeVacationExecuation_BudgetItems_BudgetItemId",
                        column: x => x.BudgetItemId,
                        principalTable: "BudgetItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeVacationExecuation_FormEmployeeVacation_FormEmployeeVacationId",
                        column: x => x.FormEmployeeVacationId,
                        principalTable: "FormEmployeeVacation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BudgetItems",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7203), null, null, null, null, "اجر وظيفى " },
                    { 2, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7205), null, null, null, null, "اجر مكمل" },
                    { 3, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7206), null, null, null, null, "أجر تعويضى" },
                    { 4, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7207), null, null, null, null, "جزاء" },
                    { 5, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7208), null, null, null, null, "إيرادات" },
                    { 6, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7209), null, null, null, null, "مرتدات" },
                    { 7, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7210), null, null, null, null, "أسترداد" }
                });

            migrationBuilder.InsertData(
                table: "Collection",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 978, DateTimeKind.Local).AddTicks(4873), null, null, null, null, "مرتبات بطاقات حكوميه" },
                    { 2, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 978, DateTimeKind.Local).AddTicks(4875), null, null, null, null, "مرتبات تحويلات بنكيه" }
                });

            migrationBuilder.InsertData(
                table: "Form",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Details", "FileNumber224", "FileNumber55", "FormDate", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7176), null, null, "مرتبات شهر مارس", "1", "1", "2022-3", null, null },
                    { 2, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7179), null, null, "مرتبات شهر ابريل", "1", "1", "2022-4", null, null },
                    { 3, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7180), null, null, "مرتبات شهر مايو", "2", "2", "2022-5", null, null },
                    { 4, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7181), null, null, "مرتبات شهر يونيو", "3", "3", "2022-6", null, null }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "ParentId", "Priority" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7409), null, null, null, null, "الممتازة", null, null },
                    { 2, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7411), null, null, null, null, "العاليه", null, null },
                    { 3, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7412), null, null, null, null, "كبير", null, null },
                    { 4, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7413), null, null, null, null, "الاولى", null, null },
                    { 7, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7419), null, null, null, null, "الثانيه", null, null },
                    { 10, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7422), null, null, null, null, "الثالثه", null, null },
                    { 14, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7426), null, null, null, null, "الرابعه", null, null },
                    { 17, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7430), null, null, null, null, "الخامسه", null, null },
                    { 20, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7434), null, null, null, null, "السادسه", null, null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(6963), null, null, null, null, "غياب بدون إذن" },
                    { 2, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7038), null, null, null, null, "امر عقاب جزاء عن الغياب بدون إذن" },
                    { 3, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7040), null, null, null, null, "أمر عقاب خصم من مكافأة الامتحانات" },
                    { 4, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7041), null, null, null, null, "أمر أستراداد مبلغ" },
                    { 5, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7042), null, null, null, null, "أستقطاع مبلغ ثابت ايرادات" },
                    { 6, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7043), null, null, null, null, "أستقطاع مبلغ ثابت مرتدات" }
                });

            migrationBuilder.InsertData(
                table: "Qanon",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7235), null, null, null, null, "قانون الخدمه المدنيه 81" },
                    { 2, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7236), null, null, null, null, "قانون تنظيم الجامعات 49" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7384), null, null, null, null, "تأمين علاجى" },
                    { 2, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7386), null, null, null, null, "نقابه" },
                    { 3, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7387), null, null, null, null, "محمول شركة ETI" },
                    { 4, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7388), null, null, null, null, "محمول شركه سيجنال " },
                    { 5, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7389), null, null, null, null, "خزنه تك  " },
                    { 6, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7390), null, null, null, null, "نفقه  " }
                });

            migrationBuilder.InsertData(
                table: "Vacation",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 978, DateTimeKind.Local).AddTicks(4896), null, null, null, null, "اجازة بدون مرتب" },
                    { 2, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 978, DateTimeKind.Local).AddTicks(4897), null, null, null, null, "جزء من الوقت" },
                    { 3, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 978, DateTimeKind.Local).AddTicks(4898), null, null, null, null, "انتداب جزئى" },
                    { 4, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 978, DateTimeKind.Local).AddTicks(4899), null, null, null, null, "انتداب كلى" }
                });

            migrationBuilder.InsertData(
                table: "FinancialDataTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "ParentFinancialDataTypeId", "QanonId", "ReservationDate" },
                values: new object[,]
                {
                    { 1000, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7256), null, null, null, null, "اجر وظيفى ", null, 1, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2000, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7258), null, null, null, null, "اجر مكمل", null, 1, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3000, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7260), null, null, null, null, "اجمالى الاجر ", null, 1, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4000, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7261), null, null, null, null, "حافز تعويضى", null, 1, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5000, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7262), null, null, null, null, "اجر الشامل", null, 1, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "ParentId", "Priority" },
                values: new object[,]
                {
                    { 5, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7416), null, null, null, null, "الاولى-أ", 4, 1 },
                    { 6, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7418), null, null, null, null, "الاولى-ب", 4, 2 },
                    { 8, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7420), null, null, null, null, "الثانيه-أ", 7, 1 },
                    { 9, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7421), null, null, null, null, "الثانيه-ب", 7, 2 },
                    { 11, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7423), null, null, null, null, "الثالثه-أ", 10, 1 },
                    { 12, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7424), null, null, null, null, "الثالثه-ب", 10, 2 },
                    { 13, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7426), null, null, null, null, "الثالثه-ج", 10, 3 },
                    { 15, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7428), null, null, null, null, "الرابعه-أ", 14, 1 },
                    { 16, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7429), null, null, null, null, "الرابعه-ب", 14, 2 },
                    { 18, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7431), null, null, null, null, "الخامسه-أ", 17, 1 },
                    { 19, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7432), null, null, null, null, "الخامسه-ب", 17, 2 },
                    { 21, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7435), null, null, null, null, "السادسه-أ", 20, 1 },
                    { 22, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7436), null, null, null, null, "السادسه-ب", 20, 2 }
                });

            migrationBuilder.InsertData(
                table: "MinimumSallary",
                columns: new[] { "Id", "Amount", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "GradeId", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, 170m, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 978, DateTimeKind.Local).AddTicks(4777), null, null, 1, null, null },
                    { 2, 170m, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 978, DateTimeKind.Local).AddTicks(4785), null, null, 2, null, null },
                    { 3, 170m, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 978, DateTimeKind.Local).AddTicks(4786), null, null, 3, null, null },
                    { 4, 255m, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 978, DateTimeKind.Local).AddTicks(4787), null, null, 4, null, null },
                    { 5, 300m, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 978, DateTimeKind.Local).AddTicks(4788), null, null, 7, null, null },
                    { 6, 340m, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 978, DateTimeKind.Local).AddTicks(4790), null, null, 10, null, null },
                    { 7, 385m, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 978, DateTimeKind.Local).AddTicks(4791), null, null, 14, null, null },
                    { 8, 400m, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 978, DateTimeKind.Local).AddTicks(4792), null, null, 17, null, null },
                    { 9, 400m, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 978, DateTimeKind.Local).AddTicks(4793), null, null, 20, null, null }
                });

            migrationBuilder.InsertData(
                table: "FinancialDataTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "ParentFinancialDataTypeId", "QanonId", "ReservationDate" },
                values: new object[,]
                {
                    { 1002, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7264), null, null, null, null, "الاساسى", 1000, 1, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1003, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7266), null, null, null, null, "100% من الاساسى", 1000, 1, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1004, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7267), null, null, null, null, "بدل حد ادنى", 1000, 1, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1005, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7274), null, null, null, null, "علاوات غير مضمومه", 1000, 1, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1006, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7275), null, null, null, null, "بدل علاوة اجتماعيه و منحة", 1000, 1, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1007, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7281), null, null, null, null, "علاوة دوريه 2015", 1000, 1, new DateTime(2015, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1008, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7295), null, null, null, null, "علاوة دوريه 2016", 1000, 1, new DateTime(2016, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1009, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7297), null, null, null, null, "علاوة دوريه 2017", 1000, 1, new DateTime(2017, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1010, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7298), null, null, null, null, "علاوة استثنائيه 2017", 1000, 1, new DateTime(2017, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1011, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7300), null, null, null, null, "علاوة دوريه 2018", 1000, 1, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1012, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7301), null, null, null, null, "علاوة استثنائيه 2018", 1000, 1, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1013, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7302), null, null, null, null, "علاوة دوريه 2019", 1000, 1, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1014, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7304), null, null, null, null, "علاوة دوريه 2020", 1000, 1, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1015, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7305), null, null, null, null, "علاوة دوريه 2021", 1000, 1, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1016, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7307), null, null, null, null, "علاوة دوريه 2022", 1000, 1, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2001, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7318), null, null, null, null, "50% من الاساسى", 2000, 1, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2002, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7339), null, null, null, null, "بدل جودة", 2000, 1, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2003, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7346), null, null, null, null, "بدل حد ادنى", 2000, 1, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2004, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7348), null, null, null, null, "2019 حافز", 2000, 1, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2005, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7349), null, null, null, null, "2020 حافز", 2000, 1, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2006, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7350), null, null, null, null, "2021 حافز", 2000, 1, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2007, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7352), null, null, null, null, "2022 حافز", 2000, 1, new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2008, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7353), null, null, null, null, "بدل غلاء معيشه 2022 ", 2000, 1, new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2009, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7355), null, null, null, null, "حافز اضافى", 2000, 1, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3001, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7308), null, null, null, null, "الاساسى", 3000, 1, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3002, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7310), null, null, null, null, "علاوات غير مضمومه", 3000, 1, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3003, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7311), null, null, null, null, "المنحة", 3000, 1, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3004, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7312), null, null, null, null, "علاوة اجتماعيه", 3000, 1, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3005, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7314), null, null, null, null, "علاوة اضافيه", 3000, 1, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3006, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7315), null, null, null, null, "بدل عدوى", 3000, 1, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3007, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7317), null, null, null, null, "150% من الاساسى", 3000, 1, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4001, "Admin", new DateTime(2023, 4, 10, 1, 7, 55, 976, DateTimeKind.Local).AddTicks(7356), null, null, null, null, "حافز تعويضى 2016", 4000, 1, new DateTime(2015, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branch_BankId",
                table: "Branch",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBankAccounts_BranchId",
                table: "EmployeeBankAccounts",
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
                name: "IX_EmployeeCollections_CollectionId",
                table: "EmployeeCollections",
                column: "CollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCollections_EmployeeId_CollectionId",
                table: "EmployeeCollections",
                columns: new[] { "EmployeeId", "CollectionId" },
                unique: true);

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
                name: "IX_Employees_QanonId",
                table: "Employees",
                column: "QanonId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_TabCode",
                table: "Employees",
                column: "TabCode",
                unique: true,
                filter: "[TabCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeVacationExecuation_BudgetItemId",
                table: "EmployeeVacationExecuation",
                column: "BudgetItemId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeVacationExecuation_FormEmployeeVacationId",
                table: "EmployeeVacationExecuation",
                column: "FormEmployeeVacationId");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialDataTypes_ParentFinancialDataTypeId",
                table: "FinancialDataTypes",
                column: "ParentFinancialDataTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialDataTypes_QanonId",
                table: "FinancialDataTypes",
                column: "QanonId");

            migrationBuilder.CreateIndex(
                name: "IX_FormEmployeeCredit_EmployeeFormId",
                table: "FormEmployeeCredit",
                column: "EmployeeFormId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormEmployeemDebit_EmployeeFormId",
                table: "FormEmployeemDebit",
                column: "EmployeeFormId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormEmployeeOrderExecuations_BudgetItemId",
                table: "FormEmployeeOrderExecuations",
                column: "BudgetItemId");

            migrationBuilder.CreateIndex(
                name: "IX_FormEmployeeOrderExecuations_FormEmployeeOrderId",
                table: "FormEmployeeOrderExecuations",
                column: "FormEmployeeOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_FormEmployeeOrders_FormEmployeeId",
                table: "FormEmployeeOrders",
                column: "FormEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_FormEmployeeOrders_OrderId",
                table: "FormEmployeeOrders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_FormEmployees_EmployeeId_FormId",
                table: "FormEmployees",
                columns: new[] { "EmployeeId", "FormId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormEmployees_FormId",
                table: "FormEmployees",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormEmployeeSubscription_FormEmployeeId_SubscriptionId_CreditOrDebit",
                table: "FormEmployeeSubscription",
                columns: new[] { "FormEmployeeId", "SubscriptionId", "CreditOrDebit" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormEmployeeSubscription_SubscriptionId",
                table: "FormEmployeeSubscription",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormEmployeeVacation_FormEmployeeId",
                table: "FormEmployeeVacation",
                column: "FormEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_FormEmployeeVacation_VacationId",
                table: "FormEmployeeVacation",
                column: "VacationId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_ParentId",
                table: "Grades",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_MinimumSallary_GradeId",
                table: "MinimumSallary",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterdEmployeeSubscriptions_EmployeeId_SubscriptionId",
                table: "RegisterdEmployeeSubscriptions",
                columns: new[] { "EmployeeId", "SubscriptionId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RegisterdEmployeeSubscriptions_SubscriptionId",
                table: "RegisterdEmployeeSubscriptions",
                column: "SubscriptionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeBasicFinancialData");

            migrationBuilder.DropTable(
                name: "EmployeeCollections");

            migrationBuilder.DropTable(
                name: "EmployeeGrades");

            migrationBuilder.DropTable(
                name: "EmployeeVacationExecuation");

            migrationBuilder.DropTable(
                name: "FormEmployeeCredit");

            migrationBuilder.DropTable(
                name: "FormEmployeemDebit");

            migrationBuilder.DropTable(
                name: "FormEmployeeOrderExecuations");

            migrationBuilder.DropTable(
                name: "FormEmployeeSubscription");

            migrationBuilder.DropTable(
                name: "MinimumSallary");

            migrationBuilder.DropTable(
                name: "RegisterdEmployeeSubscriptions");

            migrationBuilder.DropTable(
                name: "FinancialDataTypes");

            migrationBuilder.DropTable(
                name: "Collection");

            migrationBuilder.DropTable(
                name: "FormEmployeeVacation");

            migrationBuilder.DropTable(
                name: "BudgetItems");

            migrationBuilder.DropTable(
                name: "FormEmployeeOrders");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "Vacation");

            migrationBuilder.DropTable(
                name: "FormEmployees");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Form");

            migrationBuilder.DropTable(
                name: "EmployeeBankAccounts");

            migrationBuilder.DropTable(
                name: "Qanon");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "Bank");
        }
    }
}
