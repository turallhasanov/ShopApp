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
    internal class BaseServices<T> : IBaseServices<T> where T : BaseEntity
    {
        private readonly AppDbContext<T> _appDbContext;
        public BaseServices()
        {
            _appDbContext = new AppDbContext<T>();
        }
        public static int idCount = 1;
        
        public void Create(T data)
        {
            data.Id = idCount++;
            AppDbContext<T>.datas.Add(data);
        }

        public void Delete(int id)
        {
            var result = AppDbContext<T>.datas.FirstOrDefault(m => m.Id == id);
           AppDbContext<T>.datas.Remove(result);
        }

        public List<T> GetAll()
        {
            return AppDbContext<T>.datas;
        }

        public T GetById(Func<T, bool> func)
        {
            return AppDbContext<T>.datas.FirstOrDefault(func);
        }

    }
}
