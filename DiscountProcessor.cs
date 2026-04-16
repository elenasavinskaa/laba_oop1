using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class DiscountProcessor<T> where T : Product, IDiscountable
    {
        private List<T> _products = new List<T>(); 
        public static int Count = 0;

        public void AddProduct(T product)
        {
            _products.Add(product);
            Count++;
        }

        public void ApplyDiscountToAll(double percent)
        {
            foreach (T product in _products)
                product.ApplyDiscount(percent);
        }

        public List<T> FindByPriceRange(double min, double max)
        {
            List<T> result = new List<T>();
            foreach (T product in _products)
                if (product.Price >= min && product.Price <= max)
                    result.Add(product);
            return result;
        }

        public void PrintDiscountedPrices()
        {
            foreach (T product in _products)
                Console.WriteLine($"Цена: {product.Price}");
        }

        public void ShowAll()
        {
            foreach (T product in _products)
                product.DisplayInfo();
        }

        public static DiscountProcessor<T> operator +(DiscountProcessor<T> a, DiscountProcessor<T> b)
        {
            DiscountProcessor<T> result = new DiscountProcessor<T>();
            foreach (T p in a._products) result.AddProduct(p);
            foreach (T p in b._products) result.AddProduct(p);
            return result;
        }
    }
}