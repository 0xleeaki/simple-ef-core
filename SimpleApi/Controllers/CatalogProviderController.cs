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

    public class CatalogProviderController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly ICatalogProviderService _catalogProviderService;

        public CatalogProviderController(IConfiguration config, ICatalogProviderService catalogProviderService)
        {
            _config = config;
            _catalogProviderService = catalogProviderService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var catalogProviders = _catalogProviderService.GetAll();
            return Ok(catalogProviders);
        }

        [HttpPost]
        public IActionResult Create(CatalogProvider catalogProvider)
        {
            try
            {
                _catalogProviderService.Create(catalogProvider);
                return Ok(catalogProvider);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Update(CatalogProvider catalogProvider)
        {
            try
            {
                _catalogProviderService.Update(catalogProvider);
                return Ok(catalogProvider);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _catalogProviderService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}