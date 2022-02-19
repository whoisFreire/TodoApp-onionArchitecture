using Microsoft.EntityFrameworkCore;
using TodoApp.Domain.EntityMapper;
namespace TodoApp.Infrastructure.Context
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TodoMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
