using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TopologyDomain.Model;

namespace TopologyDataAccess.DbContext
{
    public class PlaceSetMapping : IEntityTypeConfiguration<PlaceSet>
    {
        public void Configure(EntityTypeBuilder<PlaceSet> builder)
        {
            builder
                //.HasBaseType<BaseEntity>()
                .ToTable("PlaceSets", "Topology")
                .HasIndex(i => i.Name).HasName("PlaceSets_NameIX");

            builder.HasMany(p => p.Places).WithOne(i => i.PlaceSet).HasForeignKey("PlaceSetId").HasPrincipalKey(p => p.Id);

            builder.Property(p => p.Location).HasColumnType("Geometry");

        }
    }
}
