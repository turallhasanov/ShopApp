using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopApp.Models;

namespace ShopApp.Services.Interfaces
{
    internal interface IProductServices : IBaseServices<Products>
    {
        public void Update(int id, Products products);
    }
}
