using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Helpers.Exceptions
{
    internal class DataNotFoundException : Exception
    {
        public DataNotFoundException(string message) : base (message)
        {
            
        }
    }
}
