using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    internal class Categorys : BaseEntity
    {
        public string Name { get; set; }

        public List<Products> Products { get; set; }
    }
}
