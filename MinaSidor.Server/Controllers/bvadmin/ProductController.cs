using Core.DataCore;
using Microsoft.AspNetCore.Mvc;
using Service.Bvadmin.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MinaSidor.Server.Controllers.bvadmin
    {
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
        {
        private readonly IProduct _productService;

        public ProductController(IProduct productService)
            {
            _productService = productService;
            }

        [HttpGet("{productId}")]
        public async Task<ActionResult<Product>> GetProduct(int productId)
            {
            var product = await _productService.getProduct(productId);
            if (product == null)
                {
                return NotFound();
                }
            return product;
            }
        [HttpGet("GetProducts")]
        public async Task<ActionResult<List<Product>>> GetProducts()
            {
            var product = await _productService.getProducts();
            if (product == null)
                {
                return NotFound();
                }
            return product;
            }

        [HttpPost]
        public async Task<ActionResult<bool>> CreateProduct(Product product)
            {
            var result = await _productService.createProduct(product);
            if (result)
                {
                return Ok(true);
                }
            return BadRequest();
            }

        [HttpPut("{productId}")]
        public async Task<ActionResult<bool>> UpdateProduct(int productId, Product product)
            {
            if (productId != product.Id)
                {
                return BadRequest();
                }

            var result = await _productService.updateProduct(product);
            if (result)
                {
                return Ok(true);
                }
            return NotFound();
            }

        [HttpDelete("{productId}")]
        public async Task<ActionResult<bool>> DeleteProduct(int productId)
            {
            var result = await _productService.deleteProduct(productId);
            if (result)
                {
                return Ok(true);
                }
            return NotFound();
            }
        }
    }
