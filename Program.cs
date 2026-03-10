using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ПРИМЕР РАБОТЫ С КЛАССОМ FoodProduct ===\n");

            // 1. СОЗДАНИЕ ОБЪЕКТОВ
            Console.WriteLine("1. СОЗДАНИЕ ПРОДУКТОВ:");
            Console.WriteLine("------------------------");

            // Объект 1: через конструктор по умолчанию + свойства
            FoodProduct product1 = new FoodProduct();
            product1.Article = 101;
            product1.Name = "Молоко";
            product1.Price = 80;
            product1.ExpirationDate = new DateTime(2024, 12, 31);
            product1.Category = "молочка";

            // Объект 2: через конструктор с параметрами
            FoodProduct product2 = new FoodProduct(
                102,
                "Курица",
                350,
                new DateTime(2024, 11, 20),
                "мясо"
            );

            // Объект 3: через конструктор с параметрами
            FoodProduct product3 = new FoodProduct(
                103,
                "Помидоры",
                120,
                new DateTime(2024, 10, 15),
                "овощи"
            );

            Console.WriteLine("Продукт 1:");
            Console.WriteLine($"  Артикул: {product1.Article}");
            Console.WriteLine($"  Название: {product1.Name}");
            Console.WriteLine($"  Цена: {product1.Price} руб.");
            Console.WriteLine($"  Срок годности: {product1.ExpirationDate.ToShortDateString()}");
            Console.WriteLine($"  Категория: {product1.Category}");
            Console.WriteLine();

            Console.WriteLine("Продукт 2:");
            Console.WriteLine($"  Артикул: {product2.Article}");
            Console.WriteLine($"  Название: {product2.Name}");
            Console.WriteLine($"  Цена: {product2.Price} руб.");
            Console.WriteLine($"  Срок годности: {product2.ExpirationDate.ToShortDateString()}");
            Console.WriteLine($"  Категория: {product2.Category}");
            Console.WriteLine();

            Console.WriteLine("Продукт 3:");
            Console.WriteLine($"  Артикул: {product3.Article}");
            Console.WriteLine($"  Название: {product3.Name}");
            Console.WriteLine($"  Цена: {product3.Price} руб.");
            Console.WriteLine($"  Срок годности: {product3.ExpirationDate.ToShortDateString()}");
            Console.WriteLine($"  Категория: {product3.Category}");
            Console.WriteLine();

            // 2. ПРОВЕРКА СРОКА ГОДНОСТИ (метод с out параметрами)
            Console.WriteLine("2. ПРОВЕРКА СРОКА ГОДНОСТИ:");
            Console.WriteLine("------------------------------");

            bool expired;
            int days;

            Console.WriteLine("Проверка продукта 1:");
            product1.CheckExpiration(out expired, out days);

            Console.WriteLine("\nПроверка продукта 2:");
            product2.CheckExpiration(out expired, out days);

            Console.WriteLine("\nПроверка продукта 3:");
            product3.CheckExpiration(out expired, out days);

            // 3. ПРИМЕНЕНИЕ СКИДОК (метод с params параметрами)
            Console.WriteLine("\n3. ПРИМЕНЕНИЕ СЕЗОННЫХ СКИДОК:");
            Console.WriteLine("----------------------------------");

            // Передаем несколько сезонов
            product2.ApplySeasonalDiscount("лето", "осень");

            // Передаем один сезон
            product3.ApplySeasonalDiscount("лето");

            // 4. ОБНОВЛЕНИЕ ЦЕНЫ (метод с ref параметром)
            Console.WriteLine("\n4. ОБНОВЛЕНИЕ ЦЕНЫ:");
            Console.WriteLine("----------------------");

            decimal newPriceForProduct1 = 95;
            product1.UpdatePrice(ref newPriceForProduct1);

            // 5. ИТОГОВАЯ ИНФОРМАЦИЯ
            Console.WriteLine("\n5. ИТОГОВАЯ ИНФОРМАЦИЯ О ПРОДУКТАХ:");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine($"Продукт 1: {product1.Name} - {product1.Price} руб. (годен до {product1.ExpirationDate.ToShortDateString()})");
            Console.WriteLine($"Продукт 2: {product2.Name} - {product2.Price} руб. (годен до {product2.ExpirationDate.ToShortDateString()})");
            Console.WriteLine($"Продукт 3: {product3.Name} - {product3.Price} руб. (годен до {product3.ExpirationDate.ToShortDateString()})");

            Console.WriteLine("\nПрограмма завершена. Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}