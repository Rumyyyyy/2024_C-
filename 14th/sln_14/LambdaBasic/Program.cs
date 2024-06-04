using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaBasic
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
            // 람다 : 계산법에서는 모든 것이 함수로 되어있다.
            // 함수의 정의와 변수, 함수의 적용으로 이루어진다.
            // 람다식은 익명 메서드를 만들기 위해 사용
            // 람다식으로 만든 익명 메서드는 무명함수라고 부른다.
            // 메서드는 입력(매개변수)과 출력(반환값)을 가지고 있다.
            // 매개변수 목록 => 식 
            // => 입력 연산자 : 매개변수를 전달하는 역할
            List<Product> list = new List<Product>()
            {
                new Product(){Name = "감자", Price = 3000},
                new Product(){Name = "고구마", Price = 4000},
                new Product(){Name = "호박", Price = 2000},
                new Product(){Name = "당근", Price = 3500},
                new Product(){Name = "연근", Price = 2500}
            };
            // Sort() 메서드의 매개 변수로 람다를 지정
            list.Sort((a, b) => { return a.Name.CompareTo(b.Name); });

            // 간단한 형태의 람다
            list.Sort((a, b) => a.Name.CompareTo(b.Name));

            // 출력
            foreach (Product p in list) { Console.WriteLine(p.Name + " : " + p.Price); }
        }
    }
}
