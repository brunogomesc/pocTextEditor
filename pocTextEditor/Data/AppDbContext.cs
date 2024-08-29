using Microsoft.EntityFrameworkCore;
using pocTextEditor.Models;

namespace pocTextEditor.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Document> Documents { get; set; }

    }
}
