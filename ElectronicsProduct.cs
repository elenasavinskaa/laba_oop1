using System;

namespace ConsoleApp1
{
    class ElectronicsProduct : Product
    {
        private string _name;
        private int _warrantyMonths;
        private string _brand;

        public ElectronicsProduct(int article, string name, double price, int warrantyMonths, string brand)
            : base(article, price)
        {
            _name = name;
            _warrantyMonths = warrantyMonths;
            _brand = brand;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override void ApplyDiscount(double percent)
        {
            if (percent > 15)
            {
                percent = 15;
                Console.WriteLine("Для электроники максимум 15%");
            }
            base.ApplyDiscount(percent);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Электроника: {_brand} {_name}, Цена: {Price}, Гарантия: {_warrantyMonths} мес.");
        }
    }
}