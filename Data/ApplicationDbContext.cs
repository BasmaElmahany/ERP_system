using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ERP_system.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Budget> Budget { get; set; }

        public DbSet<Center> Center { get; set; }

        public DbSet<Payment_order> Payment_order { get; set; }
        public DbSet<Proceed> Proceeds { get; set; }

        public DbSet<Village> Village { get; set; }

        public DbSet<Item> Items { get; set; }

    }
}
