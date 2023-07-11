using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CvBuilderAPI.Migrations
{
    public partial class messing2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_Resumes_ResumeId",
                table: "Experiences");

            migrationBuilder.DropForeignKey(
                name: "FK_PesronalInfos_Resumes_ResumeId",
                table: "PesronalInfos");

            migrationBuilder.DropIndex(
                name: "IX_PesronalInfos_ResumeId",
                table: "PesronalInfos");

            migrationBuilder.DropIndex(
                name: "IX_Experiences_ResumeId",
                table: "Experiences");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PesronalInfos_ResumeId",
                table: "PesronalInfos",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_ResumeId",
                table: "Experiences",
                column: "ResumeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_Resumes_ResumeId",
                table: "Experiences",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "ResumeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PesronalInfos_Resumes_ResumeId",
                table: "PesronalInfos",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "ResumeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
