using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TopologyDomain.Model;

namespace TopologyDataAccess.DbContext
{
    public class SortedPlaceMapping : IEntityTypeConfiguration<SortedPlace>
    {
        public void Configure(EntityTypeBuilder<SortedPlace> builder)
        {
            builder
                //.HasBaseType<BaseEntity>()
                .ToTable("SortedPlaces", "Topology");

            builder.HasOne(p => p.Place).WithMany().HasForeignKey("PlaceId");

        }
    }
}
