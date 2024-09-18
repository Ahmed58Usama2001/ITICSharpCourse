namespace Delegates;

public class RectHelper
{
    public static void GetArea(double width,double height)
    {
        var area = width * height;

        Console.WriteLine($"Area = {width} * {height} = {area}");
    }
    
    public static void GetPerimeter(double width,double height)
    {
        var Perimeter = (width + height)*2;

        Console.WriteLine($"Perimeter = ({width} + {height}) * 2 = {Perimeter}");
    }
}
