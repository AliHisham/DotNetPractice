using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignmentDotNetPractice.DTO
{
    public class ProductToUpdate
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        public string ImgUrl { get; set; }

        public Guid CategoryId { get; set; }
    }
}
