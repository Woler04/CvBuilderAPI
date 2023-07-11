using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CvBuilderAPI.Migrations
{
    public partial class template : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Template",
                columns: table => new
                {
                    TemplateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemplateFilePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Template", x => x.TemplateId);
                });

            migrationBuilder.CreateTable(
                name: "ResumeTemplate",
                columns: table => new
                {
                    ResumesResumeId = table.Column<int>(type: "int", nullable: false),
                    TemplatesTemplateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeTemplate", x => new { x.ResumesResumeId, x.TemplatesTemplateId });
                    table.ForeignKey(
                        name: "FK_ResumeTemplate_Resumes_ResumesResumeId",
                        column: x => x.ResumesResumeId,
                        principalTable: "Resumes",
                        principalColumn: "ResumeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResumeTemplate_Template_TemplatesTemplateId",
                        column: x => x.TemplatesTemplateId,
                        principalTable: "Template",
                        principalColumn: "TemplateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResumeTemplate_TemplatesTemplateId",
                table: "ResumeTemplate",
                column: "TemplatesTemplateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResumeTemplate");

            migrationBuilder.DropTable(
                name: "Template");
        }
    }
}
