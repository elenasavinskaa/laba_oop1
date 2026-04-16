using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class ProductExtensions
    {
        public static IEnumerable<FoodProduct> FindExpired(this IEnumerable<FoodProduct> products, DateTime now)
        {
            foreach (FoodProduct p in products)
                if (p.ExpirationDate < now)
                    yield return p;
        }
    }
}