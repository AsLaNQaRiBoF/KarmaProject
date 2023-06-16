using FirstProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        DbSet<DealsOfWeek> dealsOfWeeks { get; set; }
        DbSet<Latest_Products> latest_Products { get; set; }
    }
}
