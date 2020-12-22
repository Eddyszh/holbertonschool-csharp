using System;

/// <summary>
/// Object class
/// </summary>
class Obj
{
    /// <summary>
    /// returns True if the object is an instance of, or if the object is an instance of a class that inherited from, Array, otherwise return False
    /// </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array) return true;
        return false;
    }
}
