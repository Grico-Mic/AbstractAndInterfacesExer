using System;

namespace BeverageMaker
{
    public static  class BeverageMakerFactory
    {
        public static IBeverageMaker CreateBeverageMaker(string userInput)
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
