using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        // throw new NotImplementedException("You need to implement this function.");
        ulong valor = 0;
        for(int i = 1 ; i <= n; i ++)
        {
            if(valor == 0)
                valor = 1;
            else
                valor = valor*2;
        }

        return valor;
    }

    public static ulong Total()
    {
        // throw new NotImplementedException("You need to implement this function.");
        ulong valor = 0;
        ulong total = 0;
        for(int i = 1 ; i <= 64; i ++)
        {
            if(valor == 0)
                valor = 1;
            else
                valor = valor*2;

            total += valor;
        }

        return total;
    }
}