using Microsoft.EntityFrameworkCore;

namespace quotingdojo.Models
{
    public class quotingdojoContext : DbContext
    {
        public quotingdojoContext(DbContextOptions<quotingdojoContext> options) : base(options) { }
        public DbSet<Author> authors { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Meta> metas { get; set; }
        public DbSet<Quote> quotes { get; set; }
        public DbSet<QuoteCategory> qcs { get; set; }
    }
}