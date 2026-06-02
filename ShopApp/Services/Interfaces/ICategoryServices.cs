using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopApp.Models;

namespace ShopApp.Services.Interfaces
{
    internal interface ICategoryServices : IBaseServices<Categorys>
    {
        public void Update(int id, Categorys categorys);
    }
}
