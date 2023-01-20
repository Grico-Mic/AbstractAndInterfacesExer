


namespace Polygons.Models
{
    public class Square : RegularPoligon
    {
        public Square(int sideLenght) : base(sideLenght, 4)
        {

        }

        public override double CalculateArea()
        {
            return  SideLenght * SideLenght;
        }
    }
}
