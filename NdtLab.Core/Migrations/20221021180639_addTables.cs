using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NdtLab.Core.Migrations
{
    public partial class addTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Difficults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Difficults", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PipeLines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Distance = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PipeLines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pipings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Line = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Spool = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pipings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Qualifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reestrs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recipient = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reestrs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReferencesDocs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainDoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeldingDoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InspectionDoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QualityCriteria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferencesDocs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SteelStructures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Part = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SteelStructures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartTank = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Welders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stamp = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Welders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PipingId = table.Column<int>(type: "int", nullable: false),
                    SteelStructureId = table.Column<int>(type: "int", nullable: false),
                    TankId = table.Column<int>(type: "int", nullable: false),
                    PipeLineId = table.Column<int>(type: "int", nullable: false),
                    ReferencesDocId = table.Column<int>(type: "int", nullable: false),
                    DivisionId = table.Column<int>(type: "int", nullable: false),
                    QualificationId = table.Column<int>(type: "int", nullable: false),
                    Rebar = table.Column<bool>(type: "bit", nullable: true),
                    WeldingCompany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Object = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartObject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Draw = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryGOST = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Temperature = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_Divisions_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_PipeLines_PipeLineId",
                        column: x => x.PipeLineId,
                        principalTable: "PipeLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_Pipings_PipingId",
                        column: x => x.PipingId,
                        principalTable: "Pipings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_Qualifications_QualificationId",
                        column: x => x.QualificationId,
                        principalTable: "Qualifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_ReferencesDocs_ReferencesDocId",
                        column: x => x.ReferencesDocId,
                        principalTable: "ReferencesDocs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_SteelStructures_SteelStructureId",
                        column: x => x.SteelStructureId,
                        principalTable: "SteelStructures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_Tanks_TankId",
                        column: x => x.TankId,
                        principalTable: "Tanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Joints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestId = table.Column<int>(type: "int", nullable: false),
                    ReestrId = table.Column<int>(type: "int", nullable: false),
                    InspectionCompany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeldingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WeldingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConnectionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ElementOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ElementTwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradeOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradeTwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThicknessOne = table.Column<double>(type: "float", nullable: false),
                    ThicknessTwo = table.Column<double>(type: "float", nullable: false),
                    DiameterOne = table.Column<double>(type: "float", nullable: false),
                    DiameterTwo = table.Column<double>(type: "float", nullable: false),
                    WeldLength = table.Column<double>(type: "float", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Joints_Reestrs_ReestrId",
                        column: x => x.ReestrId,
                        principalTable: "Reestrs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Joints_Requests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Requests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DifficultJoints",
                columns: table => new
                {
                    DifficultId = table.Column<int>(type: "int", nullable: false),
                    JointId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DifficultJoints", x => new { x.JointId, x.DifficultId });
                    table.ForeignKey(
                        name: "FK_DifficultJoints_Difficults_DifficultId",
                        column: x => x.DifficultId,
                        principalTable: "Difficults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DifficultJoints_Joints_JointId",
                        column: x => x.JointId,
                        principalTable: "Joints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Inspections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JointId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReportNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Result = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inspections_Joints_JointId",
                        column: x => x.JointId,
                        principalTable: "Joints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WelderJoints",
                columns: table => new
                {
                    JointId = table.Column<int>(type: "int", nullable: false),
                    WelderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WelderJoints", x => new { x.WelderId, x.JointId });
                    table.ForeignKey(
                        name: "FK_WelderJoints_Joints_JointId",
                        column: x => x.JointId,
                        principalTable: "Joints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WelderJoints_Welders_WelderId",
                        column: x => x.WelderId,
                        principalTable: "Welders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "InspectionEmployees",
                columns: table => new
                {
                    InspectionId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectionEmployees", x => new { x.EmployeeId, x.InspectionId });
                    table.ForeignKey(
                        name: "FK_InspectionEmployees_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InspectionEmployees_Inspections_InspectionId",
                        column: x => x.InspectionId,
                        principalTable: "Inspections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DifficultJoints_DifficultId",
                table: "DifficultJoints",
                column: "DifficultId");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionEmployees_InspectionId",
                table: "InspectionEmployees",
                column: "InspectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Inspections_JointId",
                table: "Inspections",
                column: "JointId");

            migrationBuilder.CreateIndex(
                name: "IX_Joints_ReestrId",
                table: "Joints",
                column: "ReestrId");

            migrationBuilder.CreateIndex(
                name: "IX_Joints_RequestId",
                table: "Joints",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_DivisionId",
                table: "Requests",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_PipeLineId",
                table: "Requests",
                column: "PipeLineId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_PipingId",
                table: "Requests",
                column: "PipingId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_QualificationId",
                table: "Requests",
                column: "QualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ReferencesDocId",
                table: "Requests",
                column: "ReferencesDocId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_SteelStructureId",
                table: "Requests",
                column: "SteelStructureId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_TankId",
                table: "Requests",
                column: "TankId");

            migrationBuilder.CreateIndex(
                name: "IX_WelderJoints_JointId",
                table: "WelderJoints",
                column: "JointId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DifficultJoints");

            migrationBuilder.DropTable(
                name: "InspectionEmployees");

            migrationBuilder.DropTable(
                name: "WelderJoints");

            migrationBuilder.DropTable(
                name: "Difficults");

            migrationBuilder.DropTable(
                name: "Inspections");

            migrationBuilder.DropTable(
                name: "Welders");

            migrationBuilder.DropTable(
                name: "Joints");

            migrationBuilder.DropTable(
                name: "Reestrs");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "PipeLines");

            migrationBuilder.DropTable(
                name: "Pipings");

            migrationBuilder.DropTable(
                name: "Qualifications");

            migrationBuilder.DropTable(
                name: "ReferencesDocs");

            migrationBuilder.DropTable(
                name: "SteelStructures");

            migrationBuilder.DropTable(
                name: "Tanks");
        }
    }
}
