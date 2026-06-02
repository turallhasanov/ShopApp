using ShopApp.Controllers;

CategoryController categoryController = new();

categoryController.ExecuteCreate();
Console.WriteLine("---------------");
categoryController.ExecuteGetAll();
Console.WriteLine("---------------");
categoryController.ExecuteUpdate();
categoryController.ExecuteGetAll();
