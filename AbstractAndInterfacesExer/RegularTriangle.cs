using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterfacesExer
{
    public class RegularTriangle : RegularPoligon
    {
        public RegularTriangle(int sideLenght) : base(sideLenght,3)
        {

        }
        public override double CalculateArea()
        {
            return SideLenght * SideLenght * Math.Sqrt(3) / 4;
        }
    }
}
