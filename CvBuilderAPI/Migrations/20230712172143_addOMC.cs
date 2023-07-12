using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CvBuilderAPI.Migrations
{
    public partial class addOMC : Migration
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
                name: "PK_LocationResume",
                table: "LocationResume");

            migrationBuilder.DropIndex(
                name: "IX_LocationResume_ResumesResumeId",
                table: "LocationResume");

            migrationBuilder.RenameColumn(
                name: "ResumesResumeId",
                table: "LocationResume",
                newName: "PairId");

            migrationBuilder.RenameColumn(
                name: "LocationsLocationId",
                table: "LocationResume",
                newName: "LocationId");

            migrationBuilder.AddColumn<int>(
                name: "ResumeId",
                table: "LocationResume",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LocationResume",
                table: "LocationResume",
                columns: new[] { "ResumeId", "LocationId" });

            migrationBuilder.CreateIndex(
                name: "IX_LocationResume_LocationId",
                table: "LocationResume",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_LocationResume_Locations_ResumeId",
                table: "LocationResume",
                column: "ResumeId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationResume_Resumes_LocationId",
                table: "LocationResume",
                column: "LocationId",
                principalTable: "Resumes",
                principalColumn: "ResumeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocationResume_Locations_ResumeId",
                table: "LocationResume");

            migrationBuilder.DropForeignKey(
                name: "FK_LocationResume_Resumes_LocationId",
                table: "LocationResume");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LocationResume",
                table: "LocationResume");

            migrationBuilder.DropIndex(
                name: "IX_LocationResume_LocationId",
                table: "LocationResume");

            migrationBuilder.DropColumn(
                name: "ResumeId",
                table: "LocationResume");

            migrationBuilder.RenameColumn(
                name: "PairId",
                table: "LocationResume",
                newName: "ResumesResumeId");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "LocationResume",
                newName: "LocationsLocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LocationResume",
                table: "LocationResume",
                columns: new[] { "LocationsLocationId", "ResumesResumeId" });

            migrationBuilder.CreateIndex(
                name: "IX_LocationResume_ResumesResumeId",
                table: "LocationResume",
                column: "ResumesResumeId");

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
