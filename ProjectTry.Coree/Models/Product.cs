using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTry.Coree.Models
{
    public class Product
    {
   

            public required int Id { get; set; }
            public int? CategoryId { get; set; }
            public required string Name { get; set; }
            public string? Description { get; set; }
            public int Price { get; set; }
            public float Quantity { get; set; }
            public required string Unit { get; set; }

            //public Category? Category { get; set; }


    }

}
