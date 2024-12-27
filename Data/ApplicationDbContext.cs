using Microsoft.EntityFrameworkCore;
using CrudApi.Models;

namespace CrudApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; } = default!;

       
    }
}
