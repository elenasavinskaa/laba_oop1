using ConsoleApp1;
using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    internal class FoodProduct : Product
    {
        private string _name;
        private DateTime _expirationDate;
        private string _category;

        public FoodProduct() : base()
        {
            _name = "Неизвестно";
            _expirationDate = DateTime.Now;
            _category = "Неизвестно";
        }

        public FoodProduct(int article, string name, decimal price, DateTime expirationDate, string category)
            : base(article, price)
        {
            _name = name;
            _expirationDate = expirationDate;
            _category = category;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public DateTime ExpirationDate
        {
            get { return _expirationDate; }
            set { _expirationDate = value; }
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public override void ApplyDiscount(double percent)
        {
            Console.WriteLine($"Продукт питания: {_name}");

            if (percent > 30)
            {
                Console.WriteLine($"Скидка {percent}% слишком велика для продуктов питания. Максимум 30%");
                percent = 30;
            }

            base.ApplyDiscount(percent);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Продукт питания:");
            Console.WriteLine($"  Артикул: {Article}");
            Console.WriteLine($"  Название: {_name}");
            Console.WriteLine($"  Цена: {Price} руб.");
            Console.WriteLine($"  Срок годности: {_expirationDate.ToShortDateString()}");
            Console.WriteLine($"  Категория: {_category}");
        }

        public void CheckExpiration(out bool isExpired, out int daysLeft)
        {
            daysLeft = (_expirationDate - DateTime.Now).Days;
            isExpired = daysLeft < 0;

            if (isExpired)
            {
                Console.WriteLine($"Товар '{_name}' ПРОСРОЧЕН на {Math.Abs(daysLeft)} дней!");
            }
            else if (daysLeft == 0)
            {
                Console.WriteLine($"Товар '{_name}' годен только сегодня!");
            }
            else
            {
                Console.WriteLine($"Товар '{_name}' годен еще {daysLeft} дней");
            }
        }

        public void ApplySeasonalDiscount(params string[] seasons)
        {
            Console.WriteLine($"\nПрименяем сезонные скидки для товара '{_name}':");
            decimal oldPrice = Price;

            foreach (string season in seasons)
            {
                if (season == "лето")
                {
                    Price = Price * 0.9m;
                    Console.WriteLine("  Летняя скидка: -10%");
                }
                else if (season == "зима")
                {
                    Price = Price * 0.85m;
                    Console.WriteLine("  Зимняя скидка: -15%");
                }
                else if (season == "весна")
                {
                    Price = Price * 0.95m;
                    Console.WriteLine("  Весенняя скидка: -5%");
                }
                else if (season == "осень")
                {
                    Price = Price * 0.88m;
                    Console.WriteLine("  Осенняя скидка: -12%");
                }
            }

            Console.WriteLine($"  Цена была: {oldPrice} руб.");
            Console.WriteLine($"  Цена стала: {Price} руб.");
        }

        public void UpdatePrice(ref decimal newPrice)
        {
            decimal oldPrice = Price;
            Price = newPrice;
            Console.WriteLine($"\nЦена товара '{_name}' обновлена:");
            Console.WriteLine($"  Было: {oldPrice} руб.");
            Console.WriteLine($"  Стало: {Price} руб.");
        }

        protected override string GetProtectedInfo()
        {
            return base.GetProtectedInfo() + $", Название: {_name}";
        }

        public void ShowProtectedInfo()
        {
            Console.WriteLine(GetProtectedInfo());
        }
    }
}