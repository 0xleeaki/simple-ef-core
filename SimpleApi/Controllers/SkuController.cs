using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using StoreLib;
using SimpleApi;

namespace SimpleApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class SkuController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly ISkuService _skuService;

        public SkuController(IConfiguration config, ISkuService skuService)
        {
            _config = config;
            _skuService = skuService;
        }

        [HttpGet]
        public List<Sku> Get()
        {
            return _skuService.GetListSku();
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return true;
        }

        [HttpPost]
        public IActionResult Create(Sku newSku)
        {
            return Accepted();
        }
    }
}