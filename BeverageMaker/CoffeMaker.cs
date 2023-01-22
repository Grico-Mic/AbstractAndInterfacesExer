using System;

namespace BeverageMaker
{
    public class CoffeMaker : BeverageMaker
    {
        protected override void AddBeverage()
        {
            Console.WriteLine("Add coffe");
        }
    }
} 
