using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assignmentDotNetPractice.Entites;
using assignmentDotNetPractice.Db_Context;
using assignmentDotNetPractice.Repository;

namespace assignmentDotNetPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        
        CategoryRepository CategoryRepository;

        public CategoryController (CategoryRepository cr)
        {
            
            CategoryRepository = cr;
        }

        [HttpPost]
        public ActionResult insertCategories( Category c)
        {
            if (CategoryRepository.insertCategory(c))
            {
                return Ok("created succefully");
            }
            else
            {
                return StatusCode(400);
            }
        }
        [HttpGet]

        public ActionResult getAllCategories()
        {
            if (CategoryRepository.getAllCategories().Count > 0)
            {
                return Ok(new { categories = CategoryRepository.getAllCategories(), count = CategoryRepository.getAllCategories().Count, success = true });
            }

            else
            {
                return NotFound("no categroiess");
            }

        }

        //[HttpPost]
        //public void insertProduct(Product product)
        //{
        //    context.products.Add(product);
        //    context.SaveChanges();
        //}
    }
}
