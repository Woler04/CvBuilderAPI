using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CvBuilderAPI.Migrations
{
    public partial class skillaresume : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillId);
                });

            migrationBuilder.CreateTable(
                name: "ResumeSkill",
                columns: table => new
                {
                    ResumesResumeId = table.Column<int>(type: "int", nullable: false),
                    SkillsSkillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeSkill", x => new { x.ResumesResumeId, x.SkillsSkillId });
                    table.ForeignKey(
                        name: "FK_ResumeSkill_Resumes_ResumesResumeId",
                        column: x => x.ResumesResumeId,
                        principalTable: "Resumes",
                        principalColumn: "ResumeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResumeSkill_Skills_SkillsSkillId",
                        column: x => x.SkillsSkillId,
                        principalTable: "Skills",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResumeSkill_SkillsSkillId",
                table: "ResumeSkill",
                column: "SkillsSkillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResumeSkill");

            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
