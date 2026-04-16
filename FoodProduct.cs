using System;

namespace ConsoleApp1
{
    public class FoodProduct : Product
    {
        private string _name;
        private DateTime _expirationDate;
        private string _category;

        public FoodProduct(int article, string name, double price, DateTime expirationDate, string category)
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

        public override void ApplyDiscount(double percent)
        {
            if (percent > 30)
            {
                percent = 30;
                Console.WriteLine("Для продуктов максимум 30%");
            }
            base.ApplyDiscount(percent);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Продукт: {_name}, Цена: {Price}, Годен до: {_expirationDate.ToShortDateString()}");
        }
    }
}