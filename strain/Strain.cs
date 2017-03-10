using System;
using System.Collections.Generic;

public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        // throw new NotImplementedException("You need to implement this function.");
        foreach(T item in collection){
            if(predicate(item))
                yield return item;
        }
    }

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        // throw new NotImplementedException("You need to implement this function.");
       foreach(T item in collection){
            if(!predicate(item))
                yield return item;
        }
    }
}