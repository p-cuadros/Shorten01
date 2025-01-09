using AppWeb05.Models;
using Microsoft.EntityFrameworkCore;

namespace AppWeb05.Models
{
    public class ShortContext : DbContext
    {
        public ShortContext(DbContextOptions<ShortContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("ShorDB");
        }
        public DbSet<UrlMapping> UrlMappings { get; set; }
    }
}