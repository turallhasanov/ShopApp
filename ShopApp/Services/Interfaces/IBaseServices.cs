using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Services.Interfaces
{
    internal interface IBaseServices <T>
    {
        public void Create(T data);
        public void Delete(int id);
        public List<T> GetAll();
        public T GetById(Func<T, bool> func);

    }
}
