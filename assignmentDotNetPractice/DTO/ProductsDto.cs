using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignmentDotNetPractice.DTO
{
    public class ProductsDto
    {
        public int Price { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public string ImgUrl { get; set; }

        public int CategoryId { get; set; }
    }
}
