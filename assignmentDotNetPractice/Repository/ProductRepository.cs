using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assignmentDotNetPractice.Db_Context;
using assignmentDotNetPractice.DTO;
using assignmentDotNetPractice.Entites;

namespace assignmentDotNetPractice.Repository
{
    public class ProductRepository
    {
        Context context;
        public ProductRepository(Context con)
        {
            context = con;
        }

        public string insertProduct(Product p)
        {
            try
            {
                context.products.Add(p);
                context.SaveChanges();
                return "success";
            }

            catch
            {
                return "internal server error";
            }
        }

        public List<Product> getAllProducts()
        {
           return context.products.ToList();
            
        }

        public Product getProductById(Guid id)
        {
            return context.products.Find(id);
        }

        public List<Product> getProductsByCategory(Guid id)
        {
            return context.products.Where(p => p.CategoryId == id).ToList();
        }

        public string updateProduct(Guid id , ProductToUpdate product)
        {
            var selectedProduct = context.products.Find(id);

            try
            {
                selectedProduct.Name = product.Name;
                selectedProduct.Price = product.Price;
                selectedProduct.ImgUrl = product.ImgUrl;
                selectedProduct.Quantity = product.Quantity;
                selectedProduct.CategoryId = product.CategoryId;
                context.SaveChanges();
                return "success";

            }

            catch 
            {
                return "internal server error";
            }
            
                              
            
           
            
        }

        
    }
}
