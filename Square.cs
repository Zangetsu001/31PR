using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paraektezche
{
    class Square : Rectangle
    {
        public Square(double side) : base(side, side)
        {
            base.Name = "Square";  
        }

        public override void Print()
        {
            base.Print();
        }
    }
}
