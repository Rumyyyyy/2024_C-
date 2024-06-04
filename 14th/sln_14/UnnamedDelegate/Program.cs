using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedDelegate
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>()
            {
                new Product(){Name = "감자", Price = 3000},
                new Product(){Name = "고구마", Price = 4000},
                new Product(){Name = "호박", Price = 2000},
                new Product(){Name = "당근", Price = 3500},
                new Product(){Name = "연근", Price = 2500}
            };

            // 무명 델리게이트로 정렬 방법 정의
            //list.Sort(delegate (Product a, Product b) { return a.Price.CompareTo(b.Price); });
            list.Sort(delegate (Product a, Product b) { return a.Name.CompareTo(b.Name); });


            // 출력
            foreach (Product p in list) { Console.WriteLine(p.Name + " : " + p.Price); }
        }
    }
}
