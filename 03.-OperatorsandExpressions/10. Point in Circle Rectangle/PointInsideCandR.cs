using System;

class PointInsideCandR
{
    static void Main()
    {
        double radious = 1.5 * 1.5;
        byte centerX = 1;
        byte centerY = 1;
        float coordinateX = float.Parse(Console.ReadLine());
        float coordinateY = float.Parse(Console.ReadLine());
        float pointsCoordinates = (float)((coordinateX - centerX) * (coordinateX - centerX) + (coordinateY - centerY) * (coordinateY - centerY));
        bool inCircle = radious - pointsCoordinates >= 0;
        bool inRectangle = coordinateX >= -1 && coordinateX <= 5 && coordinateY >= -1 && coordinateY <= 1;
        if (inCircle && inRectangle)
        {
            Console.WriteLine("inside circle inside rectangle");
        }
        if (inCircle && !inRectangle)
        {
            Console.WriteLine("inside circle outside rectangle");
        }
        if (!inCircle && inRectangle)
        {
            Console.WriteLine("outside circle inside rectangle");
        }
        if (!inCircle && !inRectangle)
        {
            Console.WriteLine("outside circle outside rectangle");
        }
    }
}