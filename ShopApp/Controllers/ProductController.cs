using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopApp.Models;
using ShopApp.Services.Interfaces;
using ShopApp.Services;

namespace ShopApp.Controllers
{
    internal class ProductController
    {
        //private readonly IBaseServices<Products> _product;
        //public ProductController()
        //{
        //    _product = new BaseServices<Products>();
        //}

        //public void ExecuteCreate()
        //{
        //    Console.WriteLine("Add Name");
        //Name: string name = Console.ReadLine();
        //    if (string.IsNullOrWhiteSpace(name))
        //    {
        //        Console.WriteLine("Input Required");
        //        goto Name;
        //    }

        //    Categorys categorys = new()
        //    {
        //        Name = name
        //    };

        //    _product.Create(categorys);
        //}

        //public void ExecuteGetAll()
        //{
        //    var result = _category.GetAll();
        //    if (result.Count == 0)
        //    {
        //        Console.WriteLine("No category");
        //        return;
        //    }

        //    foreach (var item in result)
        //    {
        //        Console.WriteLine($"{item.Id} {item.Name}");
        //    }
        //}

        //public void ExecuteGetById()
        //{
        //    Console.WriteLine("Id Category");
        //idCategory: string idCategory = Console.ReadLine();
        //    if (string.IsNullOrWhiteSpace(idCategory))
        //    {
        //        Console.WriteLine("Input required");
        //        goto idCategory;
        //    }

        //    bool isCorrectFormat = int.TryParse(idCategory, out int id);
        //    if (!isCorrectFormat)
        //    {
        //        Console.WriteLine("----");
        //        goto idCategory;
        //    }

        //    var result = _category.GetById(i => i.Id == id);
        //    Console.WriteLine(result.Name);
        //}

        //public void ExecuteDelete()
        //{
        //    Console.WriteLine("Add Id delete");
        //idCat: string idCategory = Console.ReadLine();
        //    if (string.IsNullOrWhiteSpace(idCategory))
        //    {
        //        Console.WriteLine("Input Requiered");
        //        goto idCat;
        //    }
        //    bool isCorrectFormat = int.TryParse(idCategory, out int id);
        //    if (!isCorrectFormat)
        //    {
        //        Console.WriteLine("----");
        //        goto idCat;
        //    }

        //    _category.Delete(id);
        //}
    }
}
