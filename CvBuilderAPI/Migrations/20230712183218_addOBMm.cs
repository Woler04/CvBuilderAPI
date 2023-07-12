using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CvBuilderAPI.Migrations
{
    public partial class addOBMm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LanguageResume_Languages_LanguagesLanguageId",
                table: "LanguageResume");

            migrationBuilder.DropForeignKey(
                name: "FK_LanguageResume_Resumes_ResumesResumeId",
                table: "LanguageResume");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeTemplate_Resumes_ResumesResumeId",
                table: "ResumeTemplate");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeTemplate_Templates_TemplatesTemplateId",
                table: "ResumeTemplate");

            migrationBuilder.DropColumn(
                name: "PairId",
                table: "LocationResume");

            migrationBuilder.RenameColumn(
                name: "TemplatesTemplateId",
                table: "ResumeTemplate",
                newName: "TemplateId");

            migrationBuilder.RenameColumn(
                name: "ResumesResumeId",
                table: "ResumeTemplate",
                newName: "ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_ResumeTemplate_TemplatesTemplateId",
                table: "ResumeTemplate",
                newName: "IX_ResumeTemplate_TemplateId");

            migrationBuilder.RenameColumn(
                name: "ResumesResumeId",
                table: "LanguageResume",
                newName: "LanguageId");

            migrationBuilder.RenameColumn(
                name: "LanguagesLanguageId",
                table: "LanguageResume",
                newName: "ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_LanguageResume_ResumesResumeId",
                table: "LanguageResume",
                newName: "IX_LanguageResume_LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_LanguageResume_Languages_ResumeId",
                table: "LanguageResume",
                column: "ResumeId",
                principalTable: "Languages",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LanguageResume_Resumes_LanguageId",
                table: "LanguageResume",
                column: "LanguageId",
                principalTable: "Resumes",
                principalColumn: "ResumeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeTemplate_Resumes_TemplateId",
                table: "ResumeTemplate",
                column: "TemplateId",
                principalTable: "Resumes",
                principalColumn: "ResumeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeTemplate_Templates_ResumeId",
                table: "ResumeTemplate",
                column: "ResumeId",
                principalTable: "Templates",
                principalColumn: "TemplateId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LanguageResume_Languages_ResumeId",
                table: "LanguageResume");

            migrationBuilder.DropForeignKey(
                name: "FK_LanguageResume_Resumes_LanguageId",
                table: "LanguageResume");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeTemplate_Resumes_TemplateId",
                table: "ResumeTemplate");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeTemplate_Templates_ResumeId",
                table: "ResumeTemplate");

            migrationBuilder.RenameColumn(
                name: "TemplateId",
                table: "ResumeTemplate",
                newName: "TemplatesTemplateId");

            migrationBuilder.RenameColumn(
                name: "ResumeId",
                table: "ResumeTemplate",
                newName: "ResumesResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_ResumeTemplate_TemplateId",
                table: "ResumeTemplate",
                newName: "IX_ResumeTemplate_TemplatesTemplateId");

            migrationBuilder.RenameColumn(
                name: "LanguageId",
                table: "LanguageResume",
                newName: "ResumesResumeId");

            migrationBuilder.RenameColumn(
                name: "ResumeId",
                table: "LanguageResume",
                newName: "LanguagesLanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_LanguageResume_LanguageId",
                table: "LanguageResume",
                newName: "IX_LanguageResume_ResumesResumeId");

            migrationBuilder.AddColumn<int>(
                name: "PairId",
                table: "LocationResume",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_LanguageResume_Languages_LanguagesLanguageId",
                table: "LanguageResume",
                column: "LanguagesLanguageId",
                principalTable: "Languages",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LanguageResume_Resumes_ResumesResumeId",
                table: "LanguageResume",
                column: "ResumesResumeId",
                principalTable: "Resumes",
                principalColumn: "ResumeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeTemplate_Resumes_ResumesResumeId",
                table: "ResumeTemplate",
                column: "ResumesResumeId",
                principalTable: "Resumes",
                principalColumn: "ResumeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeTemplate_Templates_TemplatesTemplateId",
                table: "ResumeTemplate",
                column: "TemplatesTemplateId",
                principalTable: "Templates",
                principalColumn: "TemplateId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
