using System;

namespace ConsoleApp1
{
    abstract class Product : IDiscountable
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
                _price = _price - (_price * percent / 100);
                Console.WriteLine($"Цена после скидки: {_price}");
            }
        }

        public abstract void DisplayInfo();
    }
}