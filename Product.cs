using System;

namespace ConsoleApp1
{
    public abstract class Product : IDiscountable
    {
        private int _article;
        private double _price;

        public Product(int article, double price)
        {
            _article = article;
            _price = price;
        }

        public int Article
        {
            get { return _article; }
            set { _article = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public virtual void ApplyDiscount(double percent)
        {
            if (percent > 0 && percent <= 100)
            {
                _price -= _price * percent / 100;  
                Console.WriteLine($"Цена после скидки: {_price}");
            }
        }

        public abstract void DisplayInfo();

        public static bool operator ==(Product a, Product b)
        {
            if (a is null && b is null) return true;
            if (a is null || b is null) return false;
            return a.Article == b.Article;
        }

        public static bool operator !=(Product a, Product b)
        {
            return !(a == b);
        }
    }
}