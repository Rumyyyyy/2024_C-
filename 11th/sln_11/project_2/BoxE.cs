using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class BoxE
    {
        // 간단한 속성 생성 방법
        private int width; // 인스턴스 변수(필드)
        public int Width { get; set; } // 속성

        private int height;
        public int Height { get; set; }

        public int Area() { return this.width * this.height; } // 인스턴스 메서드
        public BoxE(int width, int height) // 생성자
        {
            if (width > 0 && height > 0)
            {
                Width =width; 
                Height = height;
            }
            else
            {
                Console.WriteLine("너비와 높이 값을 자연수로 넣어주세요");
            }
        }
    }
}
