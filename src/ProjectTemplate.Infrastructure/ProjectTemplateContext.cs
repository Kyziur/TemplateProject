using Microsoft.EntityFrameworkCore;
using ProjectTemplate.Core.Domain;

namespace ProjectTemplate.Infrastructure
{
    public class ProjectTemplateContext : DbContext
    {
        public ProjectTemplateContext(DbContextOptions<ProjectTemplateContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }
    }
}