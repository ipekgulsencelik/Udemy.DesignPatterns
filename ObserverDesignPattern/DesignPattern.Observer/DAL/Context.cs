using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Observer.DAL
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MSI;database=ObserverDesignPatternDB;integrated security=true;trusted_connection=true;encrypt=false");
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<UserProcess> UserProcesses { get; set; }
    }
}
