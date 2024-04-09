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
            // 배열을 초기화하는 방법 4가지
            // 첫번째 방법
            int[] scores = new int[5];
            scores[0] = 86;
            scores[1] = 74;
            scores[2] = 81;
            scores[3] = 95;
            scores[4] = 67;

            // 두번째 방법
            int[] scores2 = new int[5] { 86, 74, 81, 95, 67 };

            // 세번째 방법
            int[] scores3 = new int[] { 86, 74, 81, 95, 67 };

            // 네번째 방법
            int[] scores4 = { 86, 74, 81, 95, 67 };

            foreach (var score in scores) { Console.WriteLine(score); }

            int sum = 0;
            foreach (var score in scores2)
            {
                sum += score;
            }
            Console.WriteLine(sum);
            int average  = sum/scores2.Length;
            Console.WriteLine(average);
            Console.WriteLine($"Average Score: {average}");
        }
    }
}
