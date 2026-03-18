
//using ConsoleApp1;

//Console.WriteLine("ЛАБОРАТОРНАЯ РАБОТА №2: НАСЛЕДОВАНИЕ И ИНТЕРФЕЙСЫ\n");

//            Console.WriteLine("1. ИНКАПСУЛЯЦИЯ И МОДИФИКАТОРЫ ДОСТУПА:");

//            FoodProduct milk = new FoodProduct(101, "Молоко", 80, new DateTime(2024, 12, 31), "молочка");

//            Console.WriteLine("public свойства доступны:");
//            Console.WriteLine($"  milk.Name = {milk.Name}");
//            milk.Name = "Молоко 2.5%";
//            Console.WriteLine($"  milk.Name после изменения = {milk.Name}");

//            Console.WriteLine("\nprotected метод доступен только внутри класса и наследников:");
//            Console.WriteLine("  Вызов protected метода через публичную обертку:");
//            milk.ShowProtectedInfo();

//            Console.WriteLine("\n  Поля private - напрямую не доступны!");
//            Console.WriteLine("  milk._name - так нельзя, ошибка компиляции!");
//            Console.WriteLine();

//            Console.WriteLine("2. СОЗДАНИЕ ОБЪЕКТОВ:");


//            FoodProduct food1 = new FoodProduct(101, "Молоко", 80, new DateTime(2024, 12, 31), "молочка");
//            FoodProduct food2 = new FoodProduct(102, "Курица", 350, new DateTime(2024, 11, 20), "мясо");

//            ElectronicsProduct phone = new ElectronicsProduct(201, "Galaxy S21", 50000, 24, "Samsung");
//            ElectronicsProduct laptop = new ElectronicsProduct(202, "MacBook Pro", 150000, 36, "Apple");

//            ClothingProduct tshirt = new ClothingProduct(301, "Футболка", 1500, "M", "Хлопок");
//            ClothingProduct jeans = new ClothingProduct(302, "Джинсы", 3500, "L", "Деним");

//            Console.WriteLine("\n3. ПОЛИМОРФИЗМ - ВЫЗОВ МЕТОДОВ ЧЕРЕЗ БАЗОВЫЙ ТИП:");

//            List<Product> products = new List<Product>();
//            products.Add(food1);
//            products.Add(food2);
//            products.Add(phone);
//            products.Add(laptop);
//            products.Add(tshirt);
//            products.Add(jeans);

//            Console.WriteLine("Применяем скидку 20% ко всем товарам через базовый тип Product:\n");

//            foreach (Product product in products)
//            {
//                product.ApplyDiscount(20);
//                Console.WriteLine();
//            }

//            Console.WriteLine("\n4. АБСТРАКТНЫЙ МЕТОД DisplayInfo (разная реализация):");

//            foreach (Product product in products)
//            {
//                product.DisplayInfo();
//                Console.WriteLine();
//            }

//            Console.WriteLine("\n5. РАЗНЫЕ РЕАЛИЗАЦИИ СКИДОК:");

//            Console.WriteLine("FoodProduct (максимум 30%):");
//            food1.ApplyDiscount(40);

//            Console.WriteLine("\nElectronicsProduct (максимум 15%):");
//            phone.ApplyDiscount(25);

//            Console.WriteLine("\nClothingProduct (зависит от размера):");
//            tshirt.ApplyDiscount(10);
//            jeans.ApplyDiscount(10);

//            ClothingProduct bigSize = new ClothingProduct(303, "Пальто", 8000, "XL", "Шерсть");
//            Console.WriteLine("\nОдежда с нестандартным размером XL:");
//            bigSize.ApplyDiscount(10);

//            Console.WriteLine("\n6. МЕТОДЫ ИЗ ПЕРВОЙ ЛАБОРАТОРНОЙ:");

//            Console.WriteLine("Проверка срока годности:");
//            bool expired;
//            int days;
//            food1.CheckExpiration(out expired, out days);

//            Console.WriteLine("\nСезонные скидки:");
//            food1.ApplySeasonalDiscount("лето", "осень");

//            Console.WriteLine("\nОбновление цены:");
//            decimal newPrice = 90;
//            food1.UpdatePrice(ref newPrice);

//            Console.WriteLine("\n7. СПЕЦИФИЧЕСКИЕ МЕТОДЫ КЛАССОВ:");

//            Console.WriteLine("ElectronicsProduct - продление гарантии:");
//            phone.ExtendWarranty(12);

//            Console.WriteLine("\nClothingProduct - проверка размера:");
//            Console.WriteLine($"Размер M доступен для футболки? {tshirt.IsSizeAvailable("M")}");
//            Console.WriteLine($"Размер XS доступен для футболки? {tshirt.IsSizeAvailable("XS")}");

//            Console.WriteLine("\nПрограмма завершена. Нажмите любую клавишу...");
//            Console.ReadKey();
  