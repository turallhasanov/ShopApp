using ShopApp.Controllers;
using ShopApp.Helpers.Constans;
using ShopApp.Helpers.Enums;
using ShopApp.Helpers.Exceptions;

CategoryController categoryController = new();
ProductController productController = new();


while (true)
{
    var menu = new Dictionary<int, string>
{
    {1, "Create Product"}, {2, "Delete Product"}, {3, "Update Product"}, {4, "GetAll Product"}, {5, "GetById Product"},
    {6, "Create Category"}, {7, "Delete Category"}, {8, "Update Category"}, {9, "GetAll Category"}, {10, "GetById Category"}
};
    ConsoleColor.Red.WriteToConsole("--- PRODUCT OPERATIONS ---");
    foreach (var item in menu.Where(x => x.Key <= 5))
        ConsoleColor.DarkBlue.WriteToConsole($"{item.Key} - {item.Value}");

    ConsoleColor.Red.WriteToConsole("\n--- CATEGORY OPERATIONS ---");
    foreach (var item in menu.Where(x => x.Key > 5))
    ConsoleColor.DarkGreen.WriteToConsole($"{item.Key} - {item.Value}");

    ConsoleColor.Red.WriteToConsole("\nSelect Operation: ");
    
Shop: string shop = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(shop))
    {
        ConsoleColor.Red.WriteToConsole(ValidationMessage.InputRequired);
        goto Shop;
    }
    bool isCorrectFormat = int.TryParse(shop, out int shopid);
    if (!isCorrectFormat)
    {
        ConsoleColor.Red.WriteToConsole(ValidationMessage.InputRequired);
        goto Shop;
    }
    switch (shopid)
    {
        case (int)Operations.CreateProduct:
            productController.ExecuteCreate();
            break;
        case (int)Operations.DeleteProduct:
            productController.ExecuteDelete();
            break;
        case (int)Operations.UpdateProduct:
            productController.ExecuteUpdate();
            break;
        case (int)Operations.GetAllProduct:
            productController.ExecuteGetAll();
            break;
        case (int)Operations.GetByIdProduct:
            productController.ExecuteGetById();
            break;
        case (int)Operations.CreateCategory:
            categoryController.ExecuteCreate();
            break;
        case (int)Operations.DeleteCategory:
            categoryController.ExecuteDelete();
            break;
        case (int)Operations.UpdateCategory:
            categoryController.ExecuteUpdate();
            break;
        case (int)Operations.GetAllCategory:
            categoryController.ExecuteGetAll();
            break;
        case (int)Operations.GetByIdCategory:
            categoryController.ExecuteGetById();
            break;
        default:
            ConsoleColor.Red.WriteToConsole(ValidationMessage.InputRequired);
            break;
    }

}