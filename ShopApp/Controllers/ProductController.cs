using ShopApp.Data;
using ShopApp.Helpers.Constans;
using ShopApp.Helpers.Exceptions;
using ShopApp.Models;
using ShopApp.Services;
using ShopApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShopApp.Controllers
{
    internal class ProductController
    {
        private readonly IProductServices _product;
        public ProductController()
        {
            _product = new ProductServices();
        }
        public void ExecuteCreate()
        {
            Console.WriteLine("Add Name");

        Name:
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                ConsoleColor.Red.WriteToConsole(ValidationMessage.InputRequired);
                goto Name;
            }

            if (!Regex.IsMatch(name, @"^[a-zA-ZğüşıöçĞÜŞİÖÇ\s]+$"))
                goto Name;

            Console.WriteLine("Add Price");
            string priceInput = Console.ReadLine();

            if (!double.TryParse(priceInput, out double price))
                goto Name;

            Console.WriteLine("Add Description");
        Desc:
            string desc = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(desc))
                goto Desc;

            Console.WriteLine("Enter Category Id");
            string catInput = Console.ReadLine();

            if (!int.TryParse(catInput, out int categoryId))
            {
                ConsoleColor.Red.WriteToConsole("Invalid Category Id");
                return;
            }


            var product = new Products
            {
                Name = name,
                Price = price,
                Description = desc,
                CategoryId = categoryId,
            };

            _product.Create(product);

            ConsoleColor.Green.WriteToConsole("Product created");
        }

        public void ExecuteGetAll()
        {
            var result = _product.GetAll();
            if (result.Count == 0)
            {
                ConsoleColor.Red.WriteToConsole("Not Found Product");
                return;
            }

            foreach (var item in result)
            {
                ConsoleColor.DarkYellow.WriteToConsole($"{item.Id} {item.Name} {item.Price} {item.Description} {item.CreatedDate} {item.CategoryId} {item.Category}");
            }
        }

        public void ExecuteGetById()
        {
            Console.WriteLine("Id Product");
        idProduct: string idProduct = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(idProduct))
            {
                ConsoleColor.Red.WriteToConsole(ValidationMessage.InputRequired);
                goto idProduct;
            }
            string patternNumber = @"^\d+$";

            if (!Regex.IsMatch(idProduct, patternNumber))
            {
                ConsoleColor.Red.WriteToConsole(ValidationMessage.Format);
                goto idProduct;
            }

            bool isCorrectFormat = int.TryParse(idProduct, out int id);
            if (!isCorrectFormat)
            {
                ConsoleColor.Red.WriteToConsole(ValidationMessage.Format);
                goto idProduct;
            }

            var result = _product.GetById(i => i.Id == id);
            ConsoleColor.DarkYellow.WriteToConsole(result.Id + " " + result.Name + " " + result.Price + " " + result.Description + " " + result.CreatedDate);
        }

        public void ExecuteDelete()
        {
            Console.WriteLine("Add Id Delete");
        idPro: string idProduct = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(idProduct))
            {
                ConsoleColor.Red.WriteToConsole(ValidationMessage.InputRequired);
                goto idPro;
            }

            string patternNumber = @"^\d+$";

            if (!Regex.IsMatch(idProduct, patternNumber))
            {
                ConsoleColor.Red.WriteToConsole(ValidationMessage.Format);
                goto idPro;
            }
            bool isCorrectFormat = int.TryParse(idProduct, out int id);
            if (!isCorrectFormat)
            {
                ConsoleColor.Red.WriteToConsole(ValidationMessage.Format);
                goto idPro;
            }

            _product.Delete(id);
        }

        public void ExecuteUpdate()
        {
            Console.WriteLine("Id Product");
        idProduct: string idProduct = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(idProduct))
            {
                ConsoleColor.Red.WriteToConsole(ValidationMessage.InputRequired);
                goto idProduct;
            }

            string patternNumber = @"^\d+$";

            if (!Regex.IsMatch(idProduct, patternNumber))
            {
                ConsoleColor.Red.WriteToConsole(ValidationMessage.Format);
                goto idProduct;
            }

            bool isCorrectFormat = int.TryParse(idProduct, out int id);
            if (!isCorrectFormat)
            {
                ConsoleColor.Red.WriteToConsole(ValidationMessage.Format);
                goto idProduct;
            }

            var result = _product.GetById(i => i.Id == id);
            ConsoleColor.DarkYellow.WriteToConsole(result.Id + " " + result.Name + " " + result.Price + " " + result.Description + " " + result.CreatedDate);
            ProductServices productServices = new();


            Console.WriteLine("Name add");
        Name: string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                ConsoleColor.Red.WriteToConsole(ValidationMessage.InputRequired);
                goto Name;
            }
            string pattern = @"^[a-zA-ZğüşıöçĞÜŞİÖÇ]+$";
            if (!Regex.IsMatch(name, pattern))
            {
                ConsoleColor.Gray.WriteToConsole(ValidationMessage.Format);
                goto Name;
            }
            Console.WriteLine("Add Price Product");
        Price: string price = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(price))
            {
                ConsoleColor.Red.WriteToConsole(ValidationMessage.InputRequired);
                goto Price;
            }
            string patternNumberr = @"^-?\d+([\.,]\d+)?$";

            if (!Regex.IsMatch(price, patternNumberr))
            {
                ConsoleColor.Red.WriteToConsole(ValidationMessage.Format);
                goto Price;
            }

            bool isCorrectFormatt = double.TryParse(price, out double pricee);
            if (!isCorrectFormatt)
            {
                ConsoleColor.Red.WriteToConsole(ValidationMessage.Format);
                goto Price;
            }

            Console.WriteLine("Add Description");
        Descripton: string description = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(description))
            {
                ConsoleColor.Red.WriteToConsole(ValidationMessage.InputRequired);
                goto Name;
            }
            string patternn = @"^[a-zA-ZğüşıöçĞÜŞİÖÇ]+$";
            if (!Regex.IsMatch(description, patternn))
            {
                ConsoleColor.Gray.WriteToConsole(ValidationMessage.Format);
                goto Descripton;
            }

            Products products = new()
            {
                Name = name,
                Price = pricee,
                Description = description,
            };

            productServices.Update(id, products);
        }
    }
}
