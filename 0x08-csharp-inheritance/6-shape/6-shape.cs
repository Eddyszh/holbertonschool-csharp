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

/// <summary>
/// Rectangle class that inherits form shape class
/// </summary>
class Rectangle : Shape
{
    //private field that stores width value
    private int width;
    //private field that stores height value
    private int height;
    /// <summary>
    /// A read-write instance property
    /// </summary>
    public int Width
    {
        get => width;
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else width = value;
        }
    }

    /// <summary>
    /// A read-write instance property
    /// </summary>
    public int Height
    {
        get => height;
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else height = value;
        }
    }
}
