using Microsoft.EntityFrameworkCore;
using Sport.Models;

namespace Sport.EFContext
{
    public class SportDbContext : DbContext
    {
        public DbSet<Complex> Complexes { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Person> Persones { get; set; }
        public SportDbContext(DbContextOptions<SportDbContext> options) : base (options) { }
       
    }
}
