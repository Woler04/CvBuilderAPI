﻿// <auto-generated />
using System;
using CvBuilderAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CvBuilderAPI.Migrations
{
    [DbContext(typeof(CvAPIDbContext))]
    [Migration("20230711091705_template")]
    partial class template
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CvBuilderAPI.Models.Certificate", b =>
                {
                    b.Property<int>("CertificateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CertificateId"), 1L, 1);

                    b.Property<string>("CertificateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IssuingOrganization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResumeId")
                        .HasColumnType("int");

                    b.HasKey("CertificateId");

                    b.HasIndex("ResumeId");

                    b.ToTable("Certificate");
                });

            modelBuilder.Entity("CvBuilderAPI.Models.Education", b =>
                {
                    b.Property<int>("EducationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EducationId"), 1L, 1);

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FieldOfStudy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstitutionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResumeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EducationId");

                    b.HasIndex("ResumeId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("CvBuilderAPI.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationId"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("CvBuilderAPI.Models.PersonalInfo", b =>
                {
                    b.Property<int>("PersonalinfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonalinfoId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResumeId")
                        .HasColumnType("int");

                    b.HasKey("PersonalinfoId");

                    b.HasIndex("ResumeId");

                    b.ToTable("PesronalInfo");
                });

            modelBuilder.Entity("CvBuilderAPI.Models.Resume", b =>
                {
                    b.Property<int>("ResumeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResumeId"), 1L, 1);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ResumeId");

                    b.HasIndex("UserId");

                    b.ToTable("Resumes");
                });

            modelBuilder.Entity("CvBuilderAPI.Models.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SkillId"), 1L, 1);

                    b.Property<string>("SkillName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkillId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("CvBuilderAPI.Models.Template", b =>
                {
                    b.Property<int>("TemplateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TemplateId"), 1L, 1);

                    b.Property<string>("TemplateFilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TemplateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TemplateId");

                    b.ToTable("Template");
                });

            modelBuilder.Entity("CvBuilderAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LocationResume", b =>
                {
                    b.Property<int>("LocationsLocationId")
                        .HasColumnType("int");

                    b.Property<int>("ResumesResumeId")
                        .HasColumnType("int");

                    b.HasKey("LocationsLocationId", "ResumesResumeId");

                    b.HasIndex("ResumesResumeId");

                    b.ToTable("LocationResume");
                });

            modelBuilder.Entity("ResumeSkill", b =>
                {
                    b.Property<int>("ResumesResumeId")
                        .HasColumnType("int");

                    b.Property<int>("SkillsSkillId")
                        .HasColumnType("int");

                    b.HasKey("ResumesResumeId", "SkillsSkillId");

                    b.HasIndex("SkillsSkillId");

                    b.ToTable("ResumeSkill");
                });

            modelBuilder.Entity("ResumeTemplate", b =>
                {
                    b.Property<int>("ResumesResumeId")
                        .HasColumnType("int");

                    b.Property<int>("TemplatesTemplateId")
                        .HasColumnType("int");

                    b.HasKey("ResumesResumeId", "TemplatesTemplateId");

                    b.HasIndex("TemplatesTemplateId");

                    b.ToTable("ResumeTemplate");
                });

            modelBuilder.Entity("CvBuilderAPI.Models.Certificate", b =>
                {
                    b.HasOne("CvBuilderAPI.Models.Resume", "Resume")
                        .WithMany("Certificates")
                        .HasForeignKey("ResumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resume");
                });

            modelBuilder.Entity("CvBuilderAPI.Models.Education", b =>
                {
                    b.HasOne("CvBuilderAPI.Models.Resume", "Resume")
                        .WithMany("Educations")
                        .HasForeignKey("ResumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resume");
                });

            modelBuilder.Entity("CvBuilderAPI.Models.PersonalInfo", b =>
                {
                    b.HasOne("CvBuilderAPI.Models.Resume", "Resume")
                        .WithMany()
                        .HasForeignKey("ResumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resume");
                });

            modelBuilder.Entity("CvBuilderAPI.Models.Resume", b =>
                {
                    b.HasOne("CvBuilderAPI.Models.User", "User")
                        .WithMany("Resumes")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LocationResume", b =>
                {
                    b.HasOne("CvBuilderAPI.Models.Location", null)
                        .WithMany()
                        .HasForeignKey("LocationsLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CvBuilderAPI.Models.Resume", null)
                        .WithMany()
                        .HasForeignKey("ResumesResumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ResumeSkill", b =>
                {
                    b.HasOne("CvBuilderAPI.Models.Resume", null)
                        .WithMany()
                        .HasForeignKey("ResumesResumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CvBuilderAPI.Models.Skill", null)
                        .WithMany()
                        .HasForeignKey("SkillsSkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ResumeTemplate", b =>
                {
                    b.HasOne("CvBuilderAPI.Models.Resume", null)
                        .WithMany()
                        .HasForeignKey("ResumesResumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CvBuilderAPI.Models.Template", null)
                        .WithMany()
                        .HasForeignKey("TemplatesTemplateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CvBuilderAPI.Models.Resume", b =>
                {
                    b.Navigation("Certificates");

                    b.Navigation("Educations");
                });

            modelBuilder.Entity("CvBuilderAPI.Models.User", b =>
                {
                    b.Navigation("Resumes");
                });
#pragma warning restore 612, 618
        }
    }
}
