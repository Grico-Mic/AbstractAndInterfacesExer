

namespace Polygons
{
    public interface IRegularPolygon
    {
        int SideLenght { get; set; }
        int SideNumber { get; set; }
        int CalculatePerimeter();
        double CalculateArea();

    }
}
