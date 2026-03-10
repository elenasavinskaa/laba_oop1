//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class FoodProduct
//    {
//        // ПРИВАТНЫЕ ПОЛЯ (инкапсуляция)
//        private int _article;           // артикул
//        private string _name;            // название
//        private decimal _price;          // цена
//        private DateTime _expirationDate;// срок годности
//        private string _category;        // категория

//        // КОНСТРУКТОР 1: по умолчанию (без параметров)
//        public FoodProduct()
//        {
//            _article = 0;
//            _name = "Неизвестно";
//            _price = 0;
//            _expirationDate = DateTime.Now;
//            _category = "Неизвестно";
//        }

//        // КОНСТРУКТОР 2: с параметрами (обычные параметры)
//        public FoodProduct(int article, string name, decimal price, DateTime expirationDate, string category)
//        {
//            _article = article;
//            _name = name;
//            _price = price;
//            _expirationDate = expirationDate;
//            _category = category;
//        }

//        // СВОЙСТВА ДЛЯ ДОСТУПА К ПОЛЯМ (инкапсуляция)
//        public int Article
//        {
//            get { return _article; }
//            set { _article = value; }
//        }

//        public string Name
//        {
//            get { return _name; }
//            set { _name = value; }
//        }

//        public decimal Price
//        {
//            get { return _price; }
//            set { _price = value; }
//        }

//        public DateTime ExpirationDate
//        {
//            get { return _expirationDate; }
//            set { _expirationDate = value; }
//        }

//        public string Category
//        {
//            get { return _category; }
//            set { _category = value; }
//        }

//        // МЕТОД 1: проверить срок годности (используем out параметры)
//        public void CheckExpiration(out bool isExpired, out int daysLeft)
//        {
//            // Вычисляем сколько дней осталось
//            daysLeft = (_expirationDate - DateTime.Now).Days;

//            // Проверяем просрочен ли товар
//            isExpired = daysLeft < 0;

//            // Выводим результат
//            if (isExpired)
//            {
//                Console.WriteLine($"Товар '{_name}' ПРОСРОЧЕН на {Math.Abs(daysLeft)} дней!");
//            }
//            else if (daysLeft == 0)
//            {
//                Console.WriteLine($"Товар '{_name}' годен только сегодня!");
//            }
//            else
//            {
//                Console.WriteLine($"Товар '{_name}' годен еще {daysLeft} дней");
//            }
//        }

//        // МЕТОД 2: применить сезонную скидку (используем params)
//        public void ApplySeasonalDiscount(params string[] seasons)
//        {
//            Console.WriteLine($"\nПрименяем скидки для товара '{_name}':");
//            decimal oldPrice = _price;

//            // Проходим по всем переданным сезонам
//            foreach (string season in seasons)
//            {
//                if (season == "лето")
//                {
//                    _price = _price * 0.9m; // скидка 10%
//                    Console.WriteLine("  Летняя скидка: -10%");
//                }
//                else if (season == "зима")
//                {
//                    _price = _price * 0.85m; // скидка 15%
//                    Console.WriteLine("  Зимняя скидка: -15%");
//                }
//                else if (season == "весна")
//                {
//                    _price = _price * 0.95m; // скидка 5%
//                    Console.WriteLine("  Весенняя скидка: -5%");
//                }
//                else if (season == "осень")
//                {
//                    _price = _price * 0.88m; // скидка 12%
//                    Console.WriteLine("  Осенняя скидка: -12%");
//                }
//            }

//            Console.WriteLine($"  Цена была: {oldPrice} руб.");
//            Console.WriteLine($"  Цена стала: {_price} руб.");
//        }

//        // МЕТОД 3: обновить цену (используем ref параметр)
//        public void UpdatePrice(ref decimal newPrice)
//        {
//            decimal oldPrice = _price;
//            _price = newPrice;
//            Console.WriteLine($"\nЦена товара '{_name}' обновлена:");
//            Console.WriteLine($"  Было: {oldPrice} руб.");
//            Console.WriteLine($"  Стало: {_price} руб.");
//        }
//    }
//}
