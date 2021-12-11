using Microsoft.EntityFrameworkCore;
using CGApiChallenge.Model;

namespace CGApiChallenge.Data
{
    public class CGApiChallengeContext : DbContext
    {
        public CGApiChallengeContext (DbContextOptions<CGApiChallengeContext> options)
            : base(options)
        {
        }

        public DbSet<Trainer> Trainer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trainer>().HasData(
                new Trainer {
                    Id = 1,
                    Email = "trainer@campgladiator.com",
                    Phone = "5125125120",
                    FirstName = "Fearless",
                    LastName = "Contender"
                }
            );
        }
    }
}
