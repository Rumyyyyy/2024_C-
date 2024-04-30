using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine(rand.Next());
            Console.WriteLine(rand.Next());
            Console.WriteLine(rand.Next(10));
            Console.WriteLine(rand.Next(10));
            Console.WriteLine(rand.Next(0, 100));
            Console.WriteLine(rand.Next(0, 100));
            Console.WriteLine(rand.NextDouble());

            // 배열 생성
            int[] intArray = new int[3] { 10, 20, 30 };
            long[] longArray = new long[3] { 101, 102, 102 };
            string[] stringArray = new string[3] { "사과", "딸기", "참외" };

            foreach (var i in intArray) { Console.WriteLine(i); }
            Console.WriteLine();
            foreach( var i in longArray) { Console.WriteLine(longArray[i]); }
            Console.WriteLine();
            foreach ( var i in stringArray){ Console.WriteLine(i); }
            Console.WriteLine("Length : "+stringArray.Length);

            // List 클래스
            // List 클래스의 인스턴스 생성
            List<int> list1 = new List<int>();

            // 리스트에 요소 추가
            list1.Add(10);
            list1.Add(20);
            list1.Add(30);
            list1.Add(40);
            list1.Remove(20);
            list1.RemoveAt(0);
            foreach(var i in list1) { Console.WriteLine(i); }
            Console.WriteLine();

            // List 인스턴스 생성과 동시에 요소 추가
            List<int> list2 = new List<int> { 52, 273, 32, 64 };
            foreach(var i in list2) { Console.WriteLine(i); }
            Console.WriteLine("Count : " + list2.Count);

            // Math 클래서
            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Round(52.273));
            Console.WriteLine(Math.Max(52, 273));
            Console.WriteLine(Math.Min(52, 273));
            Console.WriteLine(Math.PI);
        }
    }
}
