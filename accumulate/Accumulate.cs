using System;
using System.Collections.Generic;

public static class AccumulateExtensions
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        foreach (var val in collection)
            yield return func(val);
    }

    // public static IEnumerable<int> Accumulate(this IEnumerable<int> collection, Func<int, int> func)
    // {

    //     List<int> colecao = new List<int>();

    //     foreach (int val in collection)
    //     {
    //         colecao.Add(func(val));
    //     }

    //     return colecao;
    // }

    // public static IEnumerable<string> Accumulate(this IEnumerable<string> collection, Func<string, string> func)
    // {
    //     List<string> colecao = new List<string>();

    //     foreach (string val in collection)
    //     {
    //         colecao.Add(func(val));
    //     }

    //     return colecao;

    // }


}