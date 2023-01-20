using System;


namespace BeverageMaker
{
    public abstract class BeverageMaker
    {
        public void ServedBeverage()
        {
            AddWater();
            AddOnStove();
            BoilingWater();
            AddBeverage();

            Console.WriteLine("The beverage is served");
        }
        private void AddWater()
        {
            Console.WriteLine("Add water");
        }
        private void AddOnStove()
        {
            Console.WriteLine("Add on stove");
        }

        private void BoilingWater()
        {
            Console.WriteLine("Tne water is boiled");
        }

        public abstract void AddBeverage();
        
       
    }
}
