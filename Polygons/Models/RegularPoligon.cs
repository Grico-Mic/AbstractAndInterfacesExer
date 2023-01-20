

namespace Polygons.Models
{
    public abstract class RegularPoligon
    {
        public RegularPoligon(int sideLenght, int sideNumber)
        {
            SideLenght = sideLenght;
            SideNumber = sideNumber;

        }
        public int SideLenght { get; set; }
        public int SideNumber { get; set; }

        public int CalculatePerimeter()
        {
            return SideLenght * SideNumber;
        }

        public abstract double CalculateArea();


    }
}
