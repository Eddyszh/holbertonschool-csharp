using System;

/// <summary>
/// Shape class
/// </summary>
class Shape
{
    /// <summary>
    /// Throws an NotImplementedException with a message
    /// </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
