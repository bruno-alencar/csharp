using System;

public static class Squares
{
    public static int SquareOfSums(int max)
    {
        // throw new NotImplementedException("You need to implement this function.");
        
        int valor = 0;
        for(int i = 1; i <= max; i ++)
        {
            valor += i;
        }

        return valor * valor;
    }

    public static int SumOfSquares(int max)
    {
        // throw new NotImplementedException("You need to implement this function.");
        
        int valor = 0;
        for(int i = 1; i <= max; i++)
        {
            valor += i * i;
        }

        return valor;
    }

    public static int DifferenceOfSquares(int max)
    {
        // throw new NotImplementedException("You need to implement this function.");

        return SquareOfSums(max) - SumOfSquares(max);
    }
}