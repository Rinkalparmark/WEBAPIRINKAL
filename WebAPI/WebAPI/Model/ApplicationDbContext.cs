using Microsoft.EntityFrameworkCore;

namespace WebAPI.Model
{
    public partial class ApplicationDbContext : DbContext
    {
        private readonly  IConfiguration _configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("BloggingDatabase"));
        }

        public DbSet<Emp> emp { get; set; }
    }
}
