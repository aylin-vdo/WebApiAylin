
using System.Collections.Generic;
using System.Data.Entity;
using WebApiAylin.BD_aylin;

namespace WebApiAylin
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Producto> BD_aylin { get; set; }
    }

    
    
}
