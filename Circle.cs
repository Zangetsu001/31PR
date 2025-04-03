using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paraektezche
{
    class Circle:Figure 
    {
        private double radius;
        public Circle(double radius) : base("Circle")
        {
            this.radius = radius;
        }
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public override double Area()
        {
            return Math.PI * radius * radius;
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Radius = {radius}, Area = {Area()}, Perimeter = {Perimeter()}");
        }
    }
}
