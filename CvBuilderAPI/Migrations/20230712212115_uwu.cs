using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CvBuilderAPI.Migrations
{
    public partial class uwu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResumeSkill_Resumes_SkillId",
                table: "ResumeSkill");

            migrationBuilder.DropIndex(
                name: "IX_ResumeSkill_SkillId",
                table: "ResumeSkill");

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeSkill_Resumes_ResumeId",
                table: "ResumeSkill",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "ResumeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResumeSkill_Resumes_ResumeId",
                table: "ResumeSkill");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeSkill_SkillId",
                table: "ResumeSkill",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeSkill_Resumes_SkillId",
                table: "ResumeSkill",
                column: "SkillId",
                principalTable: "Resumes",
                principalColumn: "ResumeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
