using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3
{
    internal class Program {
        static void Main(string[] args)
        {
            Cat kitty = new Cat("키티", "하얀색");  // new == 메모리 할당 연산자
            kitty.Meow();
            Console.WriteLine("{0} : {1}", kitty.Name, kitty.Color);
            Console.WriteLine();
            Cat nero = new Cat("네로", "검은색");
            nero.Meow();
            Console.WriteLine("{0} : {1}", nero.Name, nero.Color);
        }
    }
}
