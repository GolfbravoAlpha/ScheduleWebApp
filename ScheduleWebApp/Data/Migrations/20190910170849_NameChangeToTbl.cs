using Microsoft.EntityFrameworkCore.Migrations;

namespace ScheduleWebApp.Data.Migrations
{
    public partial class NameChangeToTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleDateAndTimes_Staffs_staffId",
                table: "ScheduleDateAndTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleDateAndTimes_Students_studentId",
                table: "ScheduleDateAndTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_staffHoursWorkeds_Staffs_staffId",
                table: "staffHoursWorkeds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_staffHoursWorkeds",
                table: "staffHoursWorkeds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ScheduleDateAndTimes",
                table: "ScheduleDateAndTimes");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "StudentTbl");

            migrationBuilder.RenameTable(
                name: "Staffs",
                newName: "StaffTbl");

            migrationBuilder.RenameTable(
                name: "staffHoursWorkeds",
                newName: "staffHoursWorkedTbl");

            migrationBuilder.RenameTable(
                name: "ScheduleDateAndTimes",
                newName: "ScheduleDateAndTimeTbl");

            migrationBuilder.RenameIndex(
                name: "IX_staffHoursWorkeds_staffId",
                table: "staffHoursWorkedTbl",
                newName: "IX_staffHoursWorkedTbl_staffId");

            migrationBuilder.RenameIndex(
                name: "IX_ScheduleDateAndTimes_studentId",
                table: "ScheduleDateAndTimeTbl",
                newName: "IX_ScheduleDateAndTimeTbl_studentId");

            migrationBuilder.RenameIndex(
                name: "IX_ScheduleDateAndTimes_staffId",
                table: "ScheduleDateAndTimeTbl",
                newName: "IX_ScheduleDateAndTimeTbl_staffId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentTbl",
                table: "StudentTbl",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaffTbl",
                table: "StaffTbl",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_staffHoursWorkedTbl",
                table: "staffHoursWorkedTbl",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ScheduleDateAndTimeTbl",
                table: "ScheduleDateAndTimeTbl",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleDateAndTimeTbl_StaffTbl_staffId",
                table: "ScheduleDateAndTimeTbl",
                column: "staffId",
                principalTable: "StaffTbl",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleDateAndTimeTbl_StudentTbl_studentId",
                table: "ScheduleDateAndTimeTbl",
                column: "studentId",
                principalTable: "StudentTbl",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_staffHoursWorkedTbl_StaffTbl_staffId",
                table: "staffHoursWorkedTbl",
                column: "staffId",
                principalTable: "StaffTbl",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleDateAndTimeTbl_StaffTbl_staffId",
                table: "ScheduleDateAndTimeTbl");

            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleDateAndTimeTbl_StudentTbl_studentId",
                table: "ScheduleDateAndTimeTbl");

            migrationBuilder.DropForeignKey(
                name: "FK_staffHoursWorkedTbl_StaffTbl_staffId",
                table: "staffHoursWorkedTbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentTbl",
                table: "StudentTbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaffTbl",
                table: "StaffTbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_staffHoursWorkedTbl",
                table: "staffHoursWorkedTbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ScheduleDateAndTimeTbl",
                table: "ScheduleDateAndTimeTbl");

            migrationBuilder.RenameTable(
                name: "StudentTbl",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "StaffTbl",
                newName: "Staffs");

            migrationBuilder.RenameTable(
                name: "staffHoursWorkedTbl",
                newName: "staffHoursWorkeds");

            migrationBuilder.RenameTable(
                name: "ScheduleDateAndTimeTbl",
                newName: "ScheduleDateAndTimes");

            migrationBuilder.RenameIndex(
                name: "IX_staffHoursWorkedTbl_staffId",
                table: "staffHoursWorkeds",
                newName: "IX_staffHoursWorkeds_staffId");

            migrationBuilder.RenameIndex(
                name: "IX_ScheduleDateAndTimeTbl_studentId",
                table: "ScheduleDateAndTimes",
                newName: "IX_ScheduleDateAndTimes_studentId");

            migrationBuilder.RenameIndex(
                name: "IX_ScheduleDateAndTimeTbl_staffId",
                table: "ScheduleDateAndTimes",
                newName: "IX_ScheduleDateAndTimes_staffId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_staffHoursWorkeds",
                table: "staffHoursWorkeds",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ScheduleDateAndTimes",
                table: "ScheduleDateAndTimes",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleDateAndTimes_Staffs_staffId",
                table: "ScheduleDateAndTimes",
                column: "staffId",
                principalTable: "Staffs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleDateAndTimes_Students_studentId",
                table: "ScheduleDateAndTimes",
                column: "studentId",
                principalTable: "Students",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_staffHoursWorkeds_Staffs_staffId",
                table: "staffHoursWorkeds",
                column: "staffId",
                principalTable: "Staffs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
