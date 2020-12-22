using System;

class Obj
{
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType)) return true;
        return false;
    }
}
