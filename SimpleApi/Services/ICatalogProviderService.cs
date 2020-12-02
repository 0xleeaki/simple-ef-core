using System.Collections.Generic;
using StoreLib;

namespace SimpleApi
{
    public interface ICatalogProviderService
    {
        List<CatalogProvider> GetAll();
        CatalogProvider Create(CatalogProvider catalogProvider);
        CatalogProvider Update(CatalogProvider catalogProvider);
        bool Delete(int id);
    }
}