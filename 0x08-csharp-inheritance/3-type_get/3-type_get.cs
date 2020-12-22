using System;
using System.Reflection;

/// <summary>
/// Object class
/// </summary>
class Obj
{
    /// <summary>
    /// prints the names of the available properties and methods of an object
    /// </summary>
    public static void Print(object myObj)
    {
        Type info = myObj.GetType();
        Console.WriteLine($"{info.Name} Properties:");
        foreach (PropertyInfo item in info.GetProperties())
        {
            Console.WriteLine(item.Name);
        }
        Console.WriteLine($"{info.Name} Methods:");
        foreach (MethodInfo item in info.GetMethods())
        {
            Console.WriteLine(item.Name);
        }
    }
}
