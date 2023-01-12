using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebApı_2.Models;

namespace WebApı_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController :ControllerBase
    {
       
        [HttpGet]
        public IActionResult Get()
        {

            return  Ok(ProductManage.Products);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = ProductManage.Get(id);   
            if (product == null)
            {
                return BadRequest();//NotFound()//400-404 
            }
            return Ok(product);
        }
        [HttpPost]  
        public IActionResult Post([FromBody] Product product)
        {
            if (ModelState.IsValid)
            {
                ProductManage.Add(product);
                //return Ok(product);
                return CreatedAtAction("Get", new { id = product.Id }, product);
            }
            return BadRequest();
        }
        [HttpPut]
        public IActionResult Put([FromBody] Product product)
        {
            var p = ProductManage.Get(product.Id);
            if (ModelState.IsValid)
            {
                p.Name = product.Name;
                p.Stock = product.Stock;
                p.Price = product.Price;
                return Ok(product);
            }
            return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var product = ProductManage.Get(id);
            if (product == null)
                return NotFound("ürün bulunamadı");

            ProductManage.Delete(product);
            return Ok();
        }


    }
}
