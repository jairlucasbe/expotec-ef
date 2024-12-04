using Microsoft.EntityFrameworkCore;
using expotec_ef.Models;
using expotec_ef.Modules.BusinessExecutives.Models;

namespace expotec_ef.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<BusinessExecutive> BusinessExecutives { get; set; }
        public DbSet<Confirmation> Confirmations { get; set; }
        public DbSet<Participant> Participants { get; set; }
    }
}
