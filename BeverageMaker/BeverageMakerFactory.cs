using System;
using System.Collections.Generic;
using System.Text;

namespace BeverageMaker
{
    public class BeverageMakerFactory
    {
        public IBeverageMaker CreateBeverageMaker(string userInput)
        {
            IBeverageMaker maker = null;
            if (userInput == "1")
            {
                maker = new TeaMaker();

            }
            else if (userInput == "2")
            {
                maker = new CoffeMaker();

            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
           return maker;
        }
    }
}
