using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace assignmentDotNetPractice.Entites
{
    public class Product
    {
        public Guid Id { get; set; }

        public int Price { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public string ImgUrl { get; set; }




        [Display(Name = "CategoryId")]
        public virtual Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}
