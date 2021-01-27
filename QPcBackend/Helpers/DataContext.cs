using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using QPcBackend.Entities;


namespace QPcBackend.Helpers
{
    public class DataContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<PCPart> PCPart { get; set; }

        
        
   /*      protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        
            modelBuilder.Entity<GreyhoundRaceResult>()
            .HasKey(c => new {c.RaceId,c.UserId});

        }  */  

        private readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("QsPcApiDatabase"));
           
        }
    }
}