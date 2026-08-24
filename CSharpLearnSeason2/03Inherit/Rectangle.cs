using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Inherit
{
    internal class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }


        public Rectangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }


        public double GetArea()
        {
            return Length * Width;
        }


        public void Display()
        {
            Console.WriteLine("长度：{0}", Length);
            Console.WriteLine("宽度：{0}", Width);
            Console.WriteLine("面积：{0}", GetArea());
        }
    }
}
