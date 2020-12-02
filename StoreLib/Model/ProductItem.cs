using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StoreLib
{
    public class ProductItem
    {
        public int Id { get; set; }

        public string Serial { get; set; }

    }

    public class ProductItemEntityTypeConfiguration : IEntityTypeConfiguration<ProductItem>
    {
        public void Configure(EntityTypeBuilder<ProductItem> productItem)
        {
            productItem.Property<int>("CatalogItemId");
            productItem.HasKey(t => t.Id);
            productItem.HasOne<CatalogProvider>()
                .WithMany()
                .HasForeignKey("CatalogItemId");
        }
    }
}