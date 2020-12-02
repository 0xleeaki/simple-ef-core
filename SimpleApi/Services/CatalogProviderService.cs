using System.Collections.Generic;
using StoreLib;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace SimpleApi
{
    public class CatalogProviderService : ICatalogProviderService
    {
        private readonly StoreContext _storeContext;

        public CatalogProviderService(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        public List<CatalogProvider> GetAll()
        {
            var catalogProviders = _storeContext.CatalogProvider.OrderBy(c => c.Id);
            return catalogProviders.ToList<CatalogProvider>();
        }

        public CatalogProvider Create(CatalogProvider catalogProvider)
        {
            _storeContext.CatalogProvider.Add(catalogProvider);
            _storeContext.SaveChanges();
            return catalogProvider;
        }

        public CatalogProvider Update(CatalogProvider newCatalogProvider)
        {
            var catalogProvider = _storeContext.CatalogProvider.Where(c => c.Id == newCatalogProvider.Id).FirstOrDefault();
            catalogProvider.Cost = newCatalogProvider.Cost;
            catalogProvider.Name = newCatalogProvider.Name;
            _storeContext.SaveChanges();
            return newCatalogProvider;
        }

        public bool Delete(int id)
        {
            var catalogProvider = _storeContext.CatalogProvider.Where(c => c.Id == id).FirstOrDefault();
            _storeContext.CatalogProvider.Remove(catalogProvider);
            _storeContext.SaveChanges();
            return true;
        }
    }
}