using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopApp.Data;
using ShopApp.Models;
using ShopApp.Services.Interfaces;

namespace ShopApp.Services
{
    internal class ProductServices : BaseServices<Products>,IProductServices
    {
        private readonly AppDbContext<Products> _appDbContext;
        public ProductServices()
        {
            _appDbContext = new AppDbContext<Products>();
        }
        public void Update(int id, Products products)
        {
            var result = AppDbContext<Products>.datas.FirstOrDefault(m => m.Id == id);

            //if (result == null)
            //{
            //excesption elave et
            //}
            if (!string.IsNullOrWhiteSpace(products.Name))
            {
                result.Name = products.Name;
            }

            if (!string.IsNullOrWhiteSpace(products.Description))
            {
                result.Description = products.Description;
            }
            if (products.Price != -1)
            {
                result.Price = products.Price;
            }
            
            
        }
    }
}
