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
            /*
            // 입력
            string input = Console.ReadLine(); 
            // Console.WriteLine(input);
            Console.WriteLine(input + input); // 문자열 연결 연산자
            Console.WriteLine("input" + "input");
            Console.WriteLine();

            // 자료형 변환
            // 강제로 자료형 변환
            var a = (int)10.0;
            var b = (float)10;
            var c = (double)10;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            // 다른 자료형을 숫자로 변환
            // 문자열을 숫자로 변환 -> 오류 발생
            string numberString = "52273";
            // int intString = (int)numberString; 

            // 문자열을 숫자로 변환 : Parse
            Console.WriteLine(int.Parse("52"));
            Console.WriteLine(long.Parse("273"));
            Console.WriteLine(float.Parse("52.273"));
            Console.WriteLine(double.Parse("52.273"));

            Console.WriteLine(double.Parse("52.273").GetType()); // . -> 연결 연산자

            Console.WriteLine(int.Parse("abc")); // 문자열 자체를 숫자로 변환 X

            // 다른 자료형을 문자열로 변환
            Console.WriteLine(52.ToString());
            Console.WriteLine((52).ToString());

            Console.WriteLine(52.273.ToString());
            Console.WriteLine((52.273).ToString());

            // 소숫점 제거
            double number = 52.273103;
            Console.WriteLine(number.ToString("0.0")); // 소숫점 한 자리까지
            Console.WriteLine(number.ToString("0.00")); // 소숫점 두 자리까지
            Console.WriteLine(number.ToString("0.000")); // 소숫점 세 자리까지

            // 숫자와 문자열 덧셈: 숫자가 자동으로 문자열 변환
            Console.WriteLine(52 + 273); // 덧셈 연산자
            Console.WriteLine("52" + 273); // 문자열 연결 연산자
            Console.WriteLine("52" + "273"); // 문자열 연결 연산자
            Console.WriteLine('a' + 'b'); // a: 97 + b: 98 = 195 아스키 코드

            // 문제) inch 단위를 입력받아 cm 단위를 구하는 코드를 작성하시오.
            // 1inch = 2.54cm
            Console.WriteLine("inch 단위를 입력하세요 : ");
            double inch = double.Parse(Console.ReadLine());
            Console.WriteLine(inch + "inch는 " + (inch * 2.54) + "cm입니다.");
            Console.WriteLine("{0}inch는 {1}cm입니다.",inch, inch * 2.54);
            Console.WriteLine($"{inch}inch는 {inch*2.54}cm입니다.");

            // 문제) kg 단위를 입력받아 pound 단위를 구하는 코드를 작성하시오.
            // 1kg = 2.20462pound
            Console.WriteLine("kg 단위를 입력하세요 : ");
            double kg = double.Parse(Console.ReadLine());
            Console.WriteLine(kg + "kg은 " + (kg*2.20462) + "pound입니다.");
            Console.WriteLine("{0}kg은 {1}pound입니다.", kg, kg * 2.20462);
            Console.WriteLine($"{kg}kg은 {kg * 2.20462}pound입니다.");

            // 문제) 원의 반지름을 입력받아 원의 둘레와 원의 넓이를 구하는 코드를 작성하시오.
            // 둘레 : 2 * radius * PI / 넓이 : radius * PI^2
            Console.WriteLine("반지름을 입력하세요 : ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("반지름 " + radius + "cm 원의 둘레는 " + (2 * radius * 3.14) + "㎠, 넓이는 " + (radius * 3.14 * 3.14) + "㎤입니다.");
            Console.WriteLine("반지름 {0}cm 원의 둘레는 {1}㎠, 넓이는 {2}㎤입니다.", radius, 2 * radius * 3.14, radius * 3.14 * 3.14);
            Console.WriteLine($"반지름 {radius}cm 원의 둘레는 {2 * radius * 3.14}㎠, 넓이는 {radius * 3.14 * 3.14}㎤입니다.");
            */

            // 삼항연산자
            Console.WriteLine("숫자를 입력하세요 : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number % 2 == 0 ? true : false);
            Console.WriteLine(number % 2 == 0 ? "짝수" : "홀수");

            string input = Console.ReadLine();
            int number1 = int.Parse((input));
        }
    }
}
