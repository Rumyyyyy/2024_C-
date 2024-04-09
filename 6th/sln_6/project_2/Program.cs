using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // 배열 : 같은 데이터 타입을 가진 데이터 집합 (고정)
            int[] alphas = { 10, 20, 30};

        foreach (int i in alphas) { Console.WriteLine(i); }
            // alphas[3] = 40;
            Console.WriteLine();

            // 리스트 : 같은 데이터 타입을 가진 데이터들의 집합 (가변)
            List<int> list = new List<int>(); // 생성자
            list.Add(10);
            list.Add(20);
            list.Add(30);
                
            foreach(var i in list) { Console.WriteLine(i); }
            
            List<int> list = new List<int>() { 15, 25, 35 };
            list.Add(40);
            list.Add(50);
            list.Add(60);

            foreach (var i in list) { Console.WriteLine(i); }
            Console.WriteLine();

            list.Remove(50); // 값 삭제
            list.RemoveAt(4); // 인덱스 번호로 값 삭제
            list.Insert(0, 5); // 0번 인덱스에 5 추가
            foreach (var i in list) { Console.WriteLine(i); }
            Console.WriteLine();
            */

            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }
            foreach (int i in list) { Console.WriteLine(i); }
            Console.WriteLine();

            list.RemoveAt(2);
            foreach (int i in list) { Console.WriteLine(i); }
            Console.WriteLine();

            list.Insert(2, 2);
            foreach (int i in list) { Console.WriteLine(i); }
            Console.WriteLine();

            // AraayList: 배열과 달리 컬렉션을 생성할 때 용량을 미리 지정할
            // 필요 없이 필요에 다라 자동으로 그 용량이 늘어나거나 줄어든다.
            ArrayList lists = new ArrayList();
            lists.Add(10);
            lists.Add(20);
            lists.Add(30);
            lists.Add(40);
            lists.Add(50);

            foreach(int i in lists) { Console.WriteLine(i); }
            Console.WriteLine();

            lists.Remove(30);
            lists.RemoveAt(2);
            lists.Insert(2, 25);
            foreach (int i in lists) { Console.WriteLine(i); }
            Console.WriteLine();
        }
    }
}
