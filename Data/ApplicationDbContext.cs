using Microsoft.EntityFrameworkCore;
using WebAPIV8.Models.Entities;

namespace WebAPIV8.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
