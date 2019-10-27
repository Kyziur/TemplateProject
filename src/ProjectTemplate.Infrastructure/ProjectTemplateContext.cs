using Microsoft.EntityFrameworkCore;
using ProjectTemplate.Core.Domain;

namespace ProjectTemplate.Infrastructure
{
    public class ProjectTemplateContext : DbContext
    {
        public ProjectTemplateContext(DbContextOptions<ProjectTemplateContext> options) : base(options)
        {
        }

        public DbSet<Issue> Issues { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }
    }
}