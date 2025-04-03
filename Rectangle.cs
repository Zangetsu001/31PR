using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paraektezche
{
    public class Rectangle : Figure
    {
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2) : base("Rectangle")
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double Side1
        {
            get
            { 
                return side1; 
            }
            set 
            {
                side1 = value;
            }
        }

        public double Side2
        {
            get
            { 
                return side2; 
            }
            set
            {
                side2 = value; 
            }
        }

        public override double Area()
        {
            return side1 * side2;
        }

        public override double Perimeter()
        {
            return 2 * (side1 + side2);
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Сторона 1 = {side1}, Сторона 2 = {side2}, Area = {Area()}, Perimeter = {Perimeter()}");
        }
    }


}

