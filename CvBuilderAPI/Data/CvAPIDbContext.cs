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
                .WithMany(lar => lar.Resumesas)
                .HasForeignKey(lar => lar.ResumeId);

            modelBuilder.Entity<LanguageResume>()
                .HasOne(lar => lar.Resume)
                .WithMany(lar => lar.Languages)
                .HasForeignKey(lar => lar.LanguageId);

        }

    }

}