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
            int score1 = 80;
            int score2 = 90;
            int score3 = 85;
            int average = (score1 + score2 + score3) / 3;
            Console.WriteLine("average : "+average);
            Console.WriteLine("average : {0}", average);
            Console.WriteLine($"average : {average}");
        }
    }
}
