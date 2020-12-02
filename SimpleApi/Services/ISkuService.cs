using System.Collections.Generic;
using StoreLib;

namespace SimpleApi
{
    public interface ISkuService
    {
        List<Sku> GetListSku();
    }
}