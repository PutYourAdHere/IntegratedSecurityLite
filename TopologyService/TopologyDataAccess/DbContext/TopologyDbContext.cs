using Microsoft.EntityFrameworkCore;

namespace TopologyDataAccess.DbContext
{
    public class TopologyDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public TopologyDbContext(DbContextOptions<TopologyDbContext> options) : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlaceMapping());
            modelBuilder.ApplyConfiguration(new PlaceSetMapping());
            modelBuilder.ApplyConfiguration(new SortedPlaceMapping());
        }
    }
}
