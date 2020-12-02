using Microsoft.EntityFrameworkCore;

namespace StoreLib
{
    public class StoreContext : DbContext
    {
        public DbSet<Sku> Sku { get; set; }

        public DbSet<CatalogItem> CatalogItem { get; set; }

        public DbSet<CatalogProvider> CatalogProvider { get; set; }

        public DbSet<ProductItem> ProductItem { get; set; }

        public StoreContext(DbContextOptions options) : base(options)
        {

        }

        // protected override void OnConfiguring(DbContextOptionsBuilder options)
        //     => options.UseSqlite("Data Source=./Day2/store.db");

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.ApplyConfiguration<Sku>(new SkuEntityTypeConfiguration());
            model.ApplyConfiguration<CatalogItem>(new CatalogItemEntityTypeConfiguration());
            model.ApplyConfiguration<CatalogProvider>(new CatalogProviderEntityTypeConfiguration());
            model.ApplyConfiguration<ProductItem>(new ProductItemEntityTypeConfiguration());
        }
    }
}