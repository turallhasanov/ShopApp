using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    internal class Products : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }

        public Categorys Category { get; set; }
    }
}
