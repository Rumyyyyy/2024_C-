using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 복합 대입 연산자
            int output = 0;
            output += 52; // output = output + 52;
            Console.WriteLine(output);
            output *= 52; // output = output * 52;
            Console.WriteLine(output);

            //  + (문자열 연결 연산자)
            String input = "Hello ";
            input += "World~";
            Console.WriteLine(input);

            // 증감 연산자
            int number1 = 10;
            /*
            number1++;
            Console.WriteLine(number1); // 11
            number1--;
            Console.WriteLine(number1); // 10
            ++number1;
            Console.WriteLine(number1); // 11
            --number1;
            Console.WriteLine(number1); // 10
            */

            int number2 = 20;
            /*
            Console.WriteLine(number2); // 20
            Console.WriteLine(number2++); // 20
            Console.WriteLine(number2--); // 21
            Console.WriteLine(number2); // 20

            Console.WriteLine(++number2); // 21
            Console.WriteLine(--number2); // 20
            Console.WriteLine(number2); // 20
            */

            int number3 = 30;
            /*
            number3++;
            number3--;
            Console.WriteLine(number3); // 30

            ++number3;
            --number3;
            Console.WriteLine(number3); // 30
            */

            // 자료형
            int _int = 0;
            long _long = 552273103365;
            float _float = 52.273f;
            double _double = 52.273;
            char _char = '글';
            String _string = "문자열";

            Console.WriteLine(_int.GetType());
            Console.WriteLine(_string.GetType());

            // var : 자료형을 자동으로 지정
            var numberA = 100;
            var numberB = 100.13F;
            var numberC = 100.13;
        }
    }
}
