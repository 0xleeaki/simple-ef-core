using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StoreLib
{
    public class CatalogItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Cost { get; set; }

    }

    public class CatalogItemEntityTypeConfiguration : IEntityTypeConfiguration<CatalogItem>
    {
        public void Configure(EntityTypeBuilder<CatalogItem> catalogItem)
        {
            catalogItem.Property<int>("CatalogProviderId");
            catalogItem.HasKey(t => t.Id);
            catalogItem.HasOne<CatalogProvider>()
                .WithMany()
                .HasForeignKey("CatalogProviderId");
        }
    }
}