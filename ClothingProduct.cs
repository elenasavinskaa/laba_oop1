using System;

namespace ConsoleApp1
{
    class ClothingProduct : Product
    {
        private string _name;
        private string _size;
        private string _material;

        public ClothingProduct(int article, string name, double price, string size, string material)
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

        public override void ApplyDiscount(double percent)
        {
            if (_size == "XL" || _size == "XXL")
            {
                percent = percent + 5;
                Console.WriteLine($"Размер {_size} +5% скидка");
            }
            base.ApplyDiscount(percent);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Одежда: {_name}, Цена: {Price}, Размер: {_size}, Материал: {_material}");
        }
    }
}