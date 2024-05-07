using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        class Test
        {
            // 인스턴스 메서드 생성과 사용
            public int Power(int x) { return x * x; }
        }
        class Calcurator
        {
            // 두개의 매개변수를 갖는 메서드
            public static int Plus(int a, int b) { return a + b; }
            public static int Minus(int a, int b) { return a - b; }
        }
        class Mymath
        {
            public static int Abs(int input)
            {
                if (input < 0) { return -input; }
                else { return input; }
            }
        }
        static void Main(string[] args)
        {
        Test test = new Test();
        Console.WriteLine(test.Power(10)); // 인스턴스 메서드
            Console.WriteLine(test.Power(20));
            // Console.WriteLine(Test.Power(10));

            int resultA = Calcurator.Plus(3, 5);
            Console.WriteLine(resultA);
            Console.WriteLine(Calcurator.Plus(3, 5));

            int resultB = Calcurator.Minus(7, 5);
            Console.WriteLine(resultB);

            Mymath mymath = new Mymath();
            // Console.WriteLine(mymath.Abs(-52));
            Console.WriteLine(Mymath.Abs(-52));
        }
    }
}
