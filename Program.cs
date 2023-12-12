using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritenance
{
    interface area1
    {
        void squareArea();
    }
    interface area2 
    {
        void rectangleArea();
    }
     class Area: area1, area2 
    {
        public void squareArea() 
        {
            Console.WriteLine("The area of a square is sides squared(s^2)");
        }

        public void rectangleArea() 
        {
            Console.WriteLine("The  area of a rectangle is length * breath(l*b)");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Area area = new Area();
            area.squareArea();
            area.rectangleArea();

            Console.ReadLine();
        }
    }
}
