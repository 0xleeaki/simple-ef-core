using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StoreLib
{
    public class Sku
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }

    public class SkuEntityTypeConfiguration : IEntityTypeConfiguration<Sku>
    {
        public void Configure(EntityTypeBuilder<Sku> sku)
        {
            sku.Property<int>("CatalogItemId");
            sku.HasKey(t => t.Id);
            sku.HasOne<CatalogItem>()
                .WithMany()
                .HasForeignKey("CatalogItemId");
        }
    }
}