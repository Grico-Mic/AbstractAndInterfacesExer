using BeverageMaker;
using Polygons.Models;
using System;


namespace Polygons
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new RegularTriangle(10);
            Console.WriteLine(triangle.CalculatePerimeter());
            Console.WriteLine(triangle.CalculateArea());

            var square = new Square(10);
            Console.WriteLine(square.CalculatePerimeter());
            Console.WriteLine(square.CalculateArea());

            Console.WriteLine();

            var teaMaker = new TeaMaker();
            teaMaker.ServedBeverage();
            Console.WriteLine();
            var coffeMaker = new CoffeMaker();
            coffeMaker.ServedBeverage();

            Console.WriteLine("Please choose option");
            Console.WriteLine("Insert 1 for tea or 2 for coffe");
            var userInput = Console.ReadLine();

            var maker = BeverageMakerFactory.CreateBeverageMaker(userInput);
            

            
            maker.ServedBeverage();


        }
    }
}
