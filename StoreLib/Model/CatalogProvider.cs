using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StoreLib
{
    public class CatalogProvider
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Cost { get; set; }
    }

    public class CatalogProviderEntityTypeConfiguration : IEntityTypeConfiguration<CatalogProvider>
    {
        public void Configure(EntityTypeBuilder<CatalogProvider> catalogProvider)
        {
            catalogProvider.HasKey(t => t.Id);
        }
    }
}