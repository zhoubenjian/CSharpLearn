using System;
using System.Collections.Generic;
using System.Text;

namespace _05OperatorOverload
{
    internal class Box
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }


        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }


        /// <summary>
        /// 体积计算
        /// </summary>
        /// <returns></returns>
        public double Volume()
        {
            return Length * Width * Height;
        }

        /// <summary>
        /// 运算符(+)重载
        /// Overload the + operator to add two Box objects together
        /// </summary>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static Box operator +(Box b, Box c)
        {
            return new Box(b.Length + c.Length, b.Width + c.Width, b.Height + c.Height);
        }
    }
}
