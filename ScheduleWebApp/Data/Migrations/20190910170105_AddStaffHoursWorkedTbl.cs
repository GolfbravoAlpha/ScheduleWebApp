using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ScheduleWebApp.Data.Migrations
{
    public partial class AddStaffHoursWorkedTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "staffHoursWorkeds",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    startDateAndTime = table.Column<DateTime>(nullable: false),
                    endDateAndTime = table.Column<DateTime>(nullable: false),
                    staffId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staffHoursWorkeds", x => x.id);
                    table.ForeignKey(
                        name: "FK_staffHoursWorkeds_Staffs_staffId",
                        column: x => x.staffId,
                        principalTable: "Staffs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_staffHoursWorkeds_staffId",
                table: "staffHoursWorkeds",
                column: "staffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "staffHoursWorkeds");
        }
    }
}
