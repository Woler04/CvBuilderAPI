using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CvBuilderAPI.Migrations
{
    public partial class messing3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocationResume_Locations_LocationsLocationId",
                table: "LocationResume");

            migrationBuilder.DropForeignKey(
                name: "FK_LocationResume_Resumes_ResumesResumeId",
                table: "LocationResume");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");

            migrationBuilder.RenameColumn(
                name: "ResumesResumeId",
                table: "LocationResume",
                newName: "ResumeId");

            migrationBuilder.RenameColumn(
                name: "LocationsLocationId",
                table: "LocationResume",
                newName: "LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_LocationResume_ResumesResumeId",
                table: "LocationResume",
                newName: "IX_LocationResume_ResumeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_LocationResume_Location_LocationId",
                table: "LocationResume",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationResume_Resumes_ResumeId",
                table: "LocationResume",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "ResumeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocationResume_Location_LocationId",
                table: "LocationResume");

            migrationBuilder.DropForeignKey(
                name: "FK_LocationResume_Resumes_ResumeId",
                table: "LocationResume");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");

            migrationBuilder.RenameColumn(
                name: "ResumeId",
                table: "LocationResume",
                newName: "ResumesResumeId");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "LocationResume",
                newName: "LocationsLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_LocationResume_ResumeId",
                table: "LocationResume",
                newName: "IX_LocationResume_ResumesResumeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_LocationResume_Locations_LocationsLocationId",
                table: "LocationResume",
                column: "LocationsLocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationResume_Resumes_ResumesResumeId",
                table: "LocationResume",
                column: "ResumesResumeId",
                principalTable: "Resumes",
                principalColumn: "ResumeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
