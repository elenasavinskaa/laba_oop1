//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    abstract class Product : IDiscountable
//    {
//        private int _article;
//        private decimal _price;

//        public Product()
//        {
//            _article = 0;
//            _price = 0;
//        }

//        public Product(int article, decimal price)
//        {
//            _article = article;
//            _price = price;
//        }

//        public int Article
//        {
//            get { return _article; }
//            set { _article = value; }
//        }

//        public decimal Price
//        {
//            get { return _price; }
//            set
//            {
//                if (value >= 0)
//                    _price = value;
//                else
//                    Console.WriteLine("Цена не может быть отрицательной!");
//            }
//        }

//        public virtual void ApplyDiscount(double percent)
//        {
//            if (percent > 0 && percent <= 100)
//            {
//                decimal discountAmount = _price * (decimal)(percent / 100);
//                _price -= discountAmount;
//                Console.WriteLine($"Базовая скидка {percent}% применена. Новая цена: {_price} руб.");
//            }
//            else
//            {
//                Console.WriteLine("Процент скидки должен быть от 1 до 100");
//            }
//        }

//        public abstract void DisplayInfo();

//        protected virtual string GetProtectedInfo()
//        {
//            return $"Артикул: {_article}";
//        }
//    }
//}
