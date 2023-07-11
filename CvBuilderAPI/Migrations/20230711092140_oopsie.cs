using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CvBuilderAPI.Migrations
{
    public partial class oopsie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certificate_Resumes_ResumeId",
                table: "Certificate");

            migrationBuilder.DropForeignKey(
                name: "FK_LanguageResume_Language_LanguagesLanguageId",
                table: "LanguageResume");

            migrationBuilder.DropForeignKey(
                name: "FK_LocationResume_Location_LocationsLocationId",
                table: "LocationResume");

            migrationBuilder.DropForeignKey(
                name: "FK_PesronalInfo_Resumes_ResumeId",
                table: "PesronalInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeTemplate_Template_TemplatesTemplateId",
                table: "ResumeTemplate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Template",
                table: "Template");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PesronalInfo",
                table: "PesronalInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Language",
                table: "Language");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Certificate",
                table: "Certificate");

            migrationBuilder.RenameTable(
                name: "Template",
                newName: "Templates");

            migrationBuilder.RenameTable(
                name: "PesronalInfo",
                newName: "PesronalInfos");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");

            migrationBuilder.RenameTable(
                name: "Language",
                newName: "Languages");

            migrationBuilder.RenameTable(
                name: "Certificate",
                newName: "Certificates");

            migrationBuilder.RenameIndex(
                name: "IX_PesronalInfo_ResumeId",
                table: "PesronalInfos",
                newName: "IX_PesronalInfos_ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_Certificate_ResumeId",
                table: "Certificates",
                newName: "IX_Certificates_ResumeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Templates",
                table: "Templates",
                column: "TemplateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PesronalInfos",
                table: "PesronalInfos",
                column: "PersonalinfoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Languages",
                table: "Languages",
                column: "LanguageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Certificates",
                table: "Certificates",
                column: "CertificateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Certificates_Resumes_ResumeId",
                table: "Certificates",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "ResumeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LanguageResume_Languages_LanguagesLanguageId",
                table: "LanguageResume",
                column: "LanguagesLanguageId",
                principalTable: "Languages",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationResume_Locations_LocationsLocationId",
                table: "LocationResume",
                column: "LocationsLocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PesronalInfos_Resumes_ResumeId",
                table: "PesronalInfos",
                column: "ResumeId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certificates_Resumes_ResumeId",
                table: "Certificates");

            migrationBuilder.DropForeignKey(
                name: "FK_LanguageResume_Languages_LanguagesLanguageId",
                table: "LanguageResume");

            migrationBuilder.DropForeignKey(
                name: "FK_LocationResume_Locations_LocationsLocationId",
                table: "LocationResume");

            migrationBuilder.DropForeignKey(
                name: "FK_PesronalInfos_Resumes_ResumeId",
                table: "PesronalInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_ResumeTemplate_Templates_TemplatesTemplateId",
                table: "ResumeTemplate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Templates",
                table: "Templates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PesronalInfos",
                table: "PesronalInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Languages",
                table: "Languages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Certificates",
                table: "Certificates");

            migrationBuilder.RenameTable(
                name: "Templates",
                newName: "Template");

            migrationBuilder.RenameTable(
                name: "PesronalInfos",
                newName: "PesronalInfo");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");

            migrationBuilder.RenameTable(
                name: "Languages",
                newName: "Language");

            migrationBuilder.RenameTable(
                name: "Certificates",
                newName: "Certificate");

            migrationBuilder.RenameIndex(
                name: "IX_PesronalInfos_ResumeId",
                table: "PesronalInfo",
                newName: "IX_PesronalInfo_ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_Certificates_ResumeId",
                table: "Certificate",
                newName: "IX_Certificate_ResumeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Template",
                table: "Template",
                column: "TemplateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PesronalInfo",
                table: "PesronalInfo",
                column: "PersonalinfoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Language",
                table: "Language",
                column: "LanguageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Certificate",
                table: "Certificate",
                column: "CertificateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Certificate_Resumes_ResumeId",
                table: "Certificate",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "ResumeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LanguageResume_Language_LanguagesLanguageId",
                table: "LanguageResume",
                column: "LanguagesLanguageId",
                principalTable: "Language",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationResume_Location_LocationsLocationId",
                table: "LocationResume",
                column: "LocationsLocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PesronalInfo_Resumes_ResumeId",
                table: "PesronalInfo",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "ResumeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResumeTemplate_Template_TemplatesTemplateId",
                table: "ResumeTemplate",
                column: "TemplatesTemplateId",
                principalTable: "Template",
                principalColumn: "TemplateId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
