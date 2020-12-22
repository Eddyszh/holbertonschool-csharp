using System;
using System.Reflection;

class Obj
{
    public static void Print(object myObj)
    {
        Type info = myObj.GetType();
        Console.WriteLine("{0} Properties: ", info.Name);
        foreach (PropertyInfo item in info.GetProperties())
        {
            Console.WriteLine(item.Name);
        }
        Console.WriteLine("{0} Methods: ", info.Name);
        foreach (MethodInfo item in info.GetMethods())
        {
            Console.WriteLine(item.Name);
        }
    }
}
