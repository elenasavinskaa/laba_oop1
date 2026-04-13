
using ConsoleApp1;

FoodProduct milk = new FoodProduct(101, "Молоко", 80, new DateTime(2024, 12, 31), "молочка");
FoodProduct chicken = new FoodProduct(102, "Курица", 350, new DateTime(2024, 11, 20), "мясо");

ElectronicsProduct phone = new ElectronicsProduct(201, "Galaxy S21", 50000, 24, "Samsung");
ElectronicsProduct laptop = new ElectronicsProduct(202, "MacBook", 150000, 36, "Apple");

ClothingProduct tshirt = new ClothingProduct(301, "Футболка", 1500, "M", "Хлопок");
ClothingProduct coat = new ClothingProduct(302, "Пальто", 8000, "L", "Шерсть");


Console.WriteLine("1.Обработка продуктов питания");
DiscountProcessor<FoodProduct> foodProc = new DiscountProcessor<FoodProduct>();
foodProc.AddProduct(milk);
foodProc.AddProduct(chicken);
Console.WriteLine($"Всего обработано товаров: {DiscountProcessor<FoodProduct>.Count}");

foodProc.ApplyDiscountToAll(40);
foodProc.PrintDiscountedPrices();


List<FoodProduct> cheapFood = foodProc.FindByPriceRange(0, 100);
Console.WriteLine($"\nПродукты до 100 руб: {cheapFood.Count}");


Console.WriteLine("\n2.Обработка электроники");
DiscountProcessor<ElectronicsProduct> techProc = new DiscountProcessor<ElectronicsProduct>();
techProc.AddProduct(phone);
techProc.AddProduct(laptop);
techProc.ApplyDiscountToAll(25);
techProc.PrintDiscountedPrices();


Console.WriteLine("\n3.Обработка одежды");
DiscountProcessor<ClothingProduct> clothProc = new DiscountProcessor<ClothingProduct>();
clothProc.AddProduct(tshirt);
clothProc.AddProduct(coat);
clothProc.ApplyDiscountToAll(10);
clothProc.PrintDiscountedPrices();


Console.WriteLine("\nВся информация");
foodProc.ShowAll();
techProc.ShowAll();
clothProc.ShowAll();

Console.ReadKey();