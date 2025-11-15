using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace a.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AR_DB",
                columns: table => new
                {
                    AR_ReserveNum = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AR_NameOrg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AR_ActivityTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AR_Venue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AR_DateSet = table.Column<int>(type: "int", nullable: false),
                    AR_DateNeeded = table.Column<DateOnly>(type: "date", nullable: false),
                    AR_TimeFrom = table.Column<TimeOnly>(type: "time", nullable: false),
                    AR_TimeTo = table.Column<TimeOnly>(type: "time", nullable: false),
                    AR_Participants = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AR_Speaker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AR_PurposeObj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AR_EquipF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AR_NatureAct = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AR_SourceFund = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AR_Approval1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AR_Approval2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AR_Approval3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AR_Approval4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AR_Approval5 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AR_DB", x => x.AR_ReserveNum);
                });

            migrationBuilder.CreateTable(
                name: "GP_DB",
                columns: table => new
                {
                    GP_Num = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GP_App4sch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GP_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GP_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GP_Date = table.Column<DateOnly>(type: "date", nullable: false),
                    GP_Classification = table.Column<DateOnly>(type: "date", nullable: false),
                    GP_Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GP_Course = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GP_Year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GP_PlateNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GP_DateExpiration = table.Column<DateOnly>(type: "date", nullable: false),
                    GP_Vehicle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GP_Marker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GP_Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GP_LoadnRegis = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    GP_Approval1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GP_Approval2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GP_Approval3 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GP_DB", x => x.GP_Num);
                });

            migrationBuilder.CreateTable(
                name: "L_DB",
                columns: table => new
                {
                    L_Num = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    L_StuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    L_StuID = table.Column<long>(type: "bigint", nullable: false),
                    LockerCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    L_Semester = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    L_ContactNumber = table.Column<int>(type: "int", nullable: false),
                    L_LoadnRegis = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    L_Approval = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_DB", x => x.L_Num);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AR_DB");

            migrationBuilder.DropTable(
                name: "GP_DB");

            migrationBuilder.DropTable(
                name: "L_DB");
        }
    }
}
