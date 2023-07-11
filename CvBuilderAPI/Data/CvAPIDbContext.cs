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
    }
}
