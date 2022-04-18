using Core.Entities.OderAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            // throw new NotImplementedException();
            builder.OwnsOne(i => i.ItemOrdered, io => {io.WithOwner();});
            builder.Property(i => i.Price) 
                .HasColumnType("decimal(18,2)");
        }
    }
}