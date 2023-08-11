using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTry.Coree.Models
{
    public class Category
    {

        public required int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

    }
}
