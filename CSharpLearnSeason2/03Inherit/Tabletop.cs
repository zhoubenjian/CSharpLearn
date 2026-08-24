using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Inherit
{
    internal class Tabletop : Rectangle
    {
        private const double PRICE = 69.9;
        public double Cost { get; set; }


        public Tabletop(double length, double width) : base(length, width)
        {
        }


        public double GetCost()
        {
            return GetArea() * PRICE;
        }


        public void Display()
        {
            base.Display();
            Console.WriteLine($"成本：{GetCost()}");
        }
    }
}
