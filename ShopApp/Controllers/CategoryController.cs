using ShopApp.Helpers.Constans;
using ShopApp.Helpers.Exceptions;
using ShopApp.Models;
using ShopApp.Services;
using ShopApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShopApp.Controllers
{
    internal class CategoryController
    {
        private readonly IBaseServices<Categorys> _category;
        public CategoryController()
        {
            _category = new BaseServices<Categorys>();
        }
        public void ExecuteCreate()
        {
            Console.WriteLine("Add Name");
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

            Categorys categorys = new()
            {
                Name = name
            };

            _category.Create(categorys);
            ConsoleColor.Green.WriteToConsole("Create Success: ");
        }

        public void ExecuteGetAll()
        {
            var result = _category.GetAll();
            if (result.Count == 0)
            {
                ConsoleColor.Red.WriteToConsole("No Category");
                return;
            }

            foreach (var item in result)
            {
                ConsoleColor.DarkYellow.WriteToConsole($"{item.Id} {item.Name} {item.CreatedDate} ");
            }
        }

        public void ExecuteGetById()
        {
            Console.WriteLine("Id Category");
            idCategory:  string idCategory = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(idCategory))
            {
                ConsoleColor.Red.WriteToConsole(ValidationMessage.InputRequired);
                goto idCategory;
            }
            string patternNumber = @"^\d+$";

            if (!Regex.IsMatch(idCategory, patternNumber))
            {
                ConsoleColor.Red.WriteToConsole(ValidationMessage.Format);
                goto idCategory;
            }

            bool isCorrectFormat = int.TryParse(idCategory, out int id);
            if (!isCorrectFormat)
            {
                ConsoleColor.Red.WriteToConsole(ValidationMessage.Format);
                goto idCategory;
            }
            
           var result = _category.GetById(i=>i.Id==id);
            Console.WriteLine(result.Name);
        }

        public void ExecuteDelete()
        {
            Console.WriteLine("Add Id delete");
        idCat: string idCategory = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(idCategory))
            {
                ConsoleColor.Red.WriteToConsole(ValidationMessage.InputRequired);
                goto idCat;
            }

            string patternNumber = @"^\d+$";

            if (!Regex.IsMatch(idCategory, patternNumber))
            {
                ConsoleColor.Red.WriteToConsole(ValidationMessage.Format);
                goto idCat;
            }
            bool isCorrectFormat = int.TryParse(idCategory, out int id);
            if (!isCorrectFormat)
            {
                ConsoleColor.Red.WriteToConsole(ValidationMessage.Format);
                goto idCat;
            }

            _category.Delete(id);
        }

        public void ExecuteUpdate()
        {
            Console.WriteLine("Id Category");
        idCategory: string idCategory = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(idCategory))
            {
                ConsoleColor.Red.WriteToConsole(ValidationMessage.InputRequired);
                goto idCategory;
            }

            string patternNumber = @"^\d+$";

            if (!Regex.IsMatch(idCategory, patternNumber))
            {
                ConsoleColor.Red.WriteToConsole(ValidationMessage.Format);
                goto idCategory;
            }

            bool isCorrectFormat = int.TryParse(idCategory, out int id);
            if (!isCorrectFormat)
            {
                ConsoleColor.Red.WriteToConsole(ValidationMessage.Format);
                goto idCategory;
            }

            var result = _category.GetById(i => i.Id == id);
            Console.WriteLine(result.Name);
            CategoryServices categoryServices = new();


            Console.WriteLine("Add Name");
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

            Categorys categorys = new()
            {
                Name = name
            };

            categoryServices.Update(id,categorys);
        }
    }
}
