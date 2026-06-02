using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopApp.Models;

namespace ShopApp.Data
{
    internal class AppDbContext<T>
    {
        public static List<T> datas = new List<T>();
       
    }
}
