
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assignmentDotNetPractice.Entites;
using assignmentDotNetPractice.Db_Context;
using assignmentDotNetPractice.Repository;
using assignmentDotNetPractice.DTO;
using AutoMapper;

namespace assignmentDotNetPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        
        ProductRepository productRepository;
        IMapper _mapper;
        public ProductController( ProductRepository pr , IMapper mapper)
        {
            
            productRepository = pr;
            _mapper = mapper;
        }
        [HttpPost]
        public ActionResult insetProduct(Product p)
        {
            if (productRepository.insertProduct(p) == "success")
            {
                return Ok("created succefully");
            }
            else
            {
                return StatusCode(500, productRepository.insertProduct(p));
            }
        }


        [HttpGet]

        public ActionResult getAllProducts()
        {
            var count = productRepository.getAllProducts().Count;
            
            var Products = _mapper.Map<List<ProductToRead>>(productRepository.getAllProducts());
            if (count > 0)
            {
                return Ok(new { products = Products, count = count, success = true });
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]

        public ActionResult getOneProduct(Guid id)
        {
            var product = productRepository.getProductById(id);
            if (product != null)
            {
                return Ok(new { Name = product.Name, Price = product.Price, Quantity = product.Quantity, CategoryId = product.CategoryId });
            }
            else
            {
                return NotFound("not found");
            }
        }
        [HttpGet("/api/product/categoryId")]
        public ActionResult getByCategory(Guid categoryId)
        {
            var products = productRepository.getProductsByCategory(categoryId);

            if (products.Count > 0)
            {
                return Ok(new { products = products, success = true });
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("{id}")]
        public ActionResult updateProduct(Guid id , ProductToUpdate p)
        {
           var message= productRepository.updateProduct(id, p);
            if(message=="success")
            {
                return Ok("updated");
            }
            else
            {
                return BadRequest(message);
            }
        }
    }
}
