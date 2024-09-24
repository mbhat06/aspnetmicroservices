using Catalog.API.Entities;
using Catalog.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<CatalogController> _logger;

        public CatalogController(IProductRepository productRepository, ILogger<CatalogController> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Product>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await _productRepository.GetProducts());
        }

        [HttpGet("{id:length(24)}", Name = "GetProduct")]
        public async Task<IActionResult> GetProductById(string id)
        {
            var product = await _productRepository.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpGet("[action]/{category}", Name = nameof(GetProductsByCategory))]
        public async Task<IActionResult> GetProductsByCategory(string category)
        {
            var products = await _productRepository.GetProductsByCategory(category);
            if (products == null)
            {
                return NotFound();
            }

            return Ok(products);
        }

        [HttpGet("[action]/{name}", Name = nameof(GetProductsByName))]
        public async Task<IActionResult> GetProductsByName(string name)
        {
            var products = await _productRepository.GetProductsByName(name);
            if (products == null)
            {
                return NotFound();
            }

            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product)
        {
            await _productRepository.CreateProduct(product);

            return CreatedAtRoute(nameof(GetProductById), new { id = product.Id }, product);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(Product product)
        {
            return Ok(await _productRepository.UpdateProduct(product));
        }

        [HttpDelete("{id:length(24)}", Name = "DeleProduct")]
        public async Task<IActionResult> DeleProduct(string id)
        {
            return Ok(await _productRepository.DeleteProduct(id));
        }
    }
}
