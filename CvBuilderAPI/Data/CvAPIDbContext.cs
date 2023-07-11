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

    }
}
