using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopApp.Data;
using ShopApp.Helpers.Exceptions;
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
            
            try
            {
                var result = AppDbContext<Products>.datas.FirstOrDefault(m => m.Id == id);
                if (result == null)
                {
                    throw new DataNotFoundException("Data Not Found");
                }
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
                if (result == null)
                {
                    throw new DataNotFoundException("Data Not Found");
                }

            }
            catch (DataNotFoundException ex)
            {

                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
