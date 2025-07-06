using Microsoft.EntityFrameworkCore;
using PermissionApi.Models;


namespace PermissionApi.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        }
        public DbSet<Office> Offices { get; set; }
    }
}
