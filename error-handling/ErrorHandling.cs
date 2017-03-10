using System;

public static class ErrorHandling
{
    public static void HandleErrorByThrowingException()
    {
        // throw new NotImplementedException("You need to implement this function.");
        throw new Exception();
    }

    public static int? HandleErrorByReturningNullableType(string input)
    {
        // throw new NotImplementedException("You need to implement this function.");
        // int val = ;

        if (input.Equals("1"))
            return 1;
        else
            return null;
    }

    public static bool HandleErrorWithOutParam(string input, out int result)
    {
        // throw new NotImplementedException("You need to implement this function.");

        if (input.Equals("1")){
            result = 1;
            return true;
        }
        else
        {
            result = 1;
            return false;
        }

    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
        disposableObject.Dispose();
        throw new Exception();
    }
}
