using System;

public enum TriangleKind
{
    Equilateral,
    Isosceles,
    Scalene
}

public static class Triangle
{
    public static TriangleKind Kind(decimal side1, decimal side2, decimal side3)
    {
        // throw new NotImplementedException("You need to implement this function.");

        // Console.WriteLine("side 1: " + side1);
        // Console.WriteLine("side 2: " + side2);
        // Console.WriteLine("side 3: " + side3);

        if(!(side1 + side2 > side3) || !(side1 + side3 > side2) || !(side2 + side3 > side1))
            throw new TriangleException();

        if (side1 > 0 && side2 > 0 && side3 > 0)
        {
            if (side1 == side2 && side2 == side3)
                return TriangleKind.Equilateral;
            else if (side1 != side2 && side1 != side3 && side2 != side3)
                return TriangleKind.Scalene;
            else if ((side1 == side2 && side1 != side3) ||
                    (side2 == side3 && side2 != side1) ||
                    (side1 == side3 && side1 != side2))
                return TriangleKind.Isosceles;
     
        }

        throw new TriangleException();
    }


   
}


public class TriangleException : Exception { }