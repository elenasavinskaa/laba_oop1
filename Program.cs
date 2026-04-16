
using ConsoleApp1;

Console.WriteLine("1. Проверка операторов == и !=");
FoodProduct a = new FoodProduct(1, "Молоко", 80, DateTime.Now, "молочка");
FoodProduct b = new FoodProduct(1, "Масло", 120, DateTime.Now, "молочка");
FoodProduct c = new FoodProduct(2, "Хлеб", 50, DateTime.Now, "хлеб");
Console.WriteLine($"  a (арт.1) == b (арт.1): {a == b}");
Console.WriteLine($"  a (арт.1) == c (арт.2): {a == c}");
Console.WriteLine();


Console.WriteLine("2. Проверка оператора +");
DiscountProcessor<FoodProduct> p1 = new DiscountProcessor<FoodProduct>();
p1.AddProduct(a);
DiscountProcessor<FoodProduct> p2 = new DiscountProcessor<FoodProduct>();
p2.AddProduct(c);
DiscountProcessor<FoodProduct> p3 = p1 + p2;
Console.WriteLine("  Объединённый процессор:");
p3.ShowAll();
Console.WriteLine();


Console.WriteLine("3. Проверка метода расширения FindExpired");
List<FoodProduct> list = new List<FoodProduct>
            {
                new FoodProduct(3, "Йогурт", 60, new DateTime(2024, 10, 1), "молочка"),
                new FoodProduct(4, "Сметана", 90, new DateTime(2024, 12, 31), "молочка")
            };
DateTime today = new DateTime(2024, 11, 1);
Console.WriteLine($"  Сегодня: {today:yyyy-MM-dd}");
foreach (var p in list.FindExpired(today))
{
    Console.WriteLine($"  Просрочен: {p.Name} (годен до {p.ExpirationDate:yyyy-MM-dd})");
}

Console.ReadKey();
        