using System;


namespace BeverageMaker

{
    public class TeaMaker : BeverageMaker
    {
        protected override void AddBeverage()
        {
            Console.WriteLine("Add tea");
        }
    }
}
