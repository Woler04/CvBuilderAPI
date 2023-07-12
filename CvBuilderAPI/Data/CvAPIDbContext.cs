using CvBuilderAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CvBuilderAPI.Data
{
    public class CvAPIDbContext : DbContext
    {
        public CvAPIDbContext(DbContextOptions<CvAPIDbContext> options) : base(options)
        { }

        public DbSet<Resume> Resumes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<PersonalInfo> PesronalInfos { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Template> Templates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnBuildLocationResume(modelBuilder);
            OnBuildLanguageResume(modelBuilder);
            OnBuildResumeTemplate(modelBuilder);
            OnBuildResumeSkill(modelBuilder);
        }

        private void OnBuildLocationResume(ModelBuilder modelBuilder) {
            modelBuilder.Entity<LocationResume>()
                    .HasKey(lr => new { lr.ResumeId, lr.LocationId });

            modelBuilder.Entity<LocationResume>()
                .HasOne(lr => lr.Location)
                .WithMany(lr => lr.Resumes)
                .HasForeignKey(lr => lr.ResumeId);

            modelBuilder.Entity<LocationResume>()
                .HasOne(lr => lr.Resume)
                .WithMany(lr => lr.Locations)
                .HasForeignKey(lr => lr.LocationId);
        }

        private void OnBuildLanguageResume(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LanguageResume>()
                    .HasKey(lar => new { lar.ResumeId, lar.LanguageId });

            modelBuilder.Entity<LanguageResume>()
                .HasOne(lar => lar.Language)
                .WithMany(lar => lar.Resumes)
                .HasForeignKey(lar => lar.ResumeId);

            modelBuilder.Entity<LanguageResume>()
                .HasOne(lar => lar.Resume)
                .WithMany(lar => lar.Languages)
                .HasForeignKey(lar => lar.LanguageId);
        }

        private void OnBuildResumeTemplate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ResumeTemplate>()
                    .HasKey(tr => new { tr.ResumeId, tr.TemplateId });

            modelBuilder.Entity<ResumeTemplate>()
                .HasOne(tr => tr.Template)
                .WithMany(tr => tr.Resumes)
                .HasForeignKey(tr => tr.ResumeId);

            modelBuilder.Entity<ResumeTemplate>()
                .HasOne(tr => tr.Resume)
                .WithMany(tr => tr.Templates)
                .HasForeignKey(tr => tr.TemplateId);
        }

        private void OnBuildResumeSkill(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ResumeSkill>()
                    .HasKey(tr => new { tr.ResumeId, tr.SkillId });

            modelBuilder.Entity<ResumeSkill>()
                .HasOne(tr => tr.Skill)
                .WithMany(tr => tr.Resumes)
                .HasForeignKey(tr => tr.ResumeId);

            modelBuilder.Entity<ResumeSkill>()
                .HasOne(tr => tr.Resume)
                .WithMany(tr => tr.Skills)
                .HasForeignKey(tr => tr.SkillId);
        }

    }

}