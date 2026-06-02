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
    internal class CategoryServices : BaseServices<Categorys>,ICategoryServices
    {
        private readonly AppDbContext<Categorys> _appDbContext;
        public CategoryServices()
        {
            _appDbContext = new AppDbContext<Categorys>();
        }
        public void Update(int id, Categorys categorys)
        {
            try
            {
                var result = AppDbContext<Categorys>.datas.FirstOrDefault(m => m.Id == id);
                if (result is null)
                {
                    throw new DataNotFoundException("Data Not Found");
                }
                if (!string.IsNullOrWhiteSpace(categorys.Name))
                {
                    result.Name = categorys.Name;
                }
                if (!string.IsNullOrWhiteSpace(categorys.Name))
                {
                    result.Name = categorys.Name;
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
