using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ElectronicsProduct : Product
    {
        private string _name;
        private int _warrantyMonths;
        private string _brand;

        public ElectronicsProduct() : base()
        {
            _name = "Неизвестно";
            _warrantyMonths = 12;
            _brand = "Неизвестно";
        }

        public ElectronicsProduct(int article, string name, decimal price, int warrantyMonths, string brand)
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

        public int WarrantyMonths
        {
            get { return _warrantyMonths; }
            set
            {
                if (value >= 0)
                    _warrantyMonths = value;
                else
                    Console.WriteLine("Гарантия не может быть отрицательной!");
            }
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public override void ApplyDiscount(double percent)
        {
            Console.WriteLine($"Электроника: {_brand} {_name}");

            double maxDiscount = 15;

            if (percent > maxDiscount)
            {
                Console.WriteLine($"Скидка {percent}% превышает максимальную {maxDiscount}% для электроники. Устанавливаем {maxDiscount}%");
                percent = maxDiscount;
            }

            base.ApplyDiscount(percent);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Электроника:");
            Console.WriteLine($"  Артикул: {Article}");
            Console.WriteLine($"  Бренд: {_brand}");
            Console.WriteLine($"  Название: {_name}");
            Console.WriteLine($"  Цена: {Price} руб.");
            Console.WriteLine($"  Гарантия: {_warrantyMonths} месяцев");
        }

        public void ExtendWarranty(int months)
        {
            _warrantyMonths += months;
            Console.WriteLine($"Гарантия увеличена на {months} месяцев. Теперь гарантия: {_warrantyMonths} месяцев");
        }

        protected override string GetProtectedInfo()
        {
            return base.GetProtectedInfo() + $", Бренд: {_brand}, Модель: {_name}";
        }

        public void ShowProtectedInfo()
        {
            Console.WriteLine(GetProtectedInfo());
        }
    }
}
