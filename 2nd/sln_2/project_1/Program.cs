using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; // static  ==> 정적이라는 의미 static으로 선언한 변수는 '전역변수'

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)  // static이 있는 이유 : 부팅을 하게될 시 이미 메모리 공간이 할당되어 있어야 파일을 읽을 수 있는데 미리 메모리 할당을 해주기 위해 static을 붙인다.
        {
            System.Console.WriteLine(275); // 줄 바꿈 되는 쓰기
            Console.WriteLine(275);
            WriteLine(275);

           System.Console.Write(275); // 줄 바꿈 없는 쓰기
            Console.Write(275);
            Write(275);
            Console.WriteLine();

            Console.WriteLine("C# Programing");

            // 주석
            /* 여러줄 주석 */

            Console.WriteLine(4 % 3); // 1
            Console.WriteLine("A"); // 문자열
            Console.WriteLine('A'); // 문자
            Console.WriteLine("안녕" + "하세요"); // 문자열 연결 연산자
            Console.WriteLine('a' + 'b');  // 덧셈 연산자 -> 문자끼리는 연결할 수 없기에 ASCII 코드로 변환되어 계산됨

            // 이스케이프 문자
            Console.WriteLine("컴퓨터\t소프트웨어\t공학과"); // tab
            Console.WriteLine("컴퓨터\n소프트웨어\n공학과"); // 줄 바꿈

            // 문자 선택
            Console.WriteLine("안녕하세요."[0]); // 안 출력
            Console.WriteLine("안녕하세요."[1]); // 녕 출력

            // 참과 거짓
            // Console.WriteLine(52 = 273); // 대입(할당) 연산자
            Console.WriteLine(52 == 273);

            WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour); // OR 조건
            WriteLine(DateTime.Now.Hour < 3 && 8 < DateTime.Now.Hour); // AND 조건

            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine(c);

            float d = 12.345f;
            double e = 234.567;

            var g = 10;
            var h = 123.456;
        }
    }
}
