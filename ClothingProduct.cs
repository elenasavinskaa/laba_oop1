using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClothingProduct : Product
    {
        private string _name;
        private string _size;
        private string _material;

        public ClothingProduct() : base()
        {
            _name = "Неизвестно";
            _size = "M";
            _material = "Неизвестно";
        }

        public ClothingProduct(int article, string name, decimal price, string size, string material)
            : base(article, price)
        {
            _name = name;
            _size = size;
            _material = material;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public string Material
        {
            get { return _material; }
            set { _material = value; }
        }

        public override void ApplyDiscount(double percent)
        {
            Console.WriteLine($"Одежда: {_name}, размер {_size}");

            if (_size == "XS" || _size == "XL" || _size == "XXL")
            {
                Console.WriteLine($"Для размера {_size} дополнительная скидка 5%!");
                percent += 5;
            }

            base.ApplyDiscount(percent);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Одежда:");
            Console.WriteLine($"  Артикул: {Article}");
            Console.WriteLine($"  Название: {_name}");
            Console.WriteLine($"  Цена: {Price} руб.");
            Console.WriteLine($"  Размер: {_size}");
            Console.WriteLine($"  Материал: {_material}");
        }

        public bool IsSizeAvailable(string neededSize)
        {
            return _size == neededSize;
        }

        protected override string GetProtectedInfo()
        {
            return base.GetProtectedInfo() + $", Название: {_name}, Размер: {_size}";
        }

        public void ShowProtectedInfo()
        {
            Console.WriteLine(GetProtectedInfo());
        }
    }
}
