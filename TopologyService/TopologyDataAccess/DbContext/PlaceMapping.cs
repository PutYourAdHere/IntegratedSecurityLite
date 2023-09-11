using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TopologyDomain.Model;

namespace TopologyDataAccess.DbContext
{
    public class PlaceMapping : IEntityTypeConfiguration<Place>
    {
        public void Configure(EntityTypeBuilder<Place> builder)
        {
            builder
                //.HasBaseType<BaseEntity>()
                .ToTable("Places", "Topology");
            
            builder.HasIndex(i => i.Name).HasName("Places_NameIX");

            builder.Property(p => p.Location).HasColumnType("Geometry");
        }
    }
}
