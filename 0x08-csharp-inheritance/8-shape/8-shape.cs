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

    /// <summary>
    /// Public method that overrides the area method
    /// </summary>
    /// <return>
    /// the area of a rectangle
    /// </return>
    public new int Area()
    {
        return width * height;
    }

    /// <summary>
    /// Public method that overrides the output of .ToString method
    /// </summary>
    /// <return>
    /// New output to stdout
    /// </return>
    public override string ToString()
    {
        return String.Format("[Rectangle] {0} / {1}", width, height);
    }
}

/// <summary>
/// Square class that inherits form rectangle class
/// </summary>
class Square : Rectangle
{
    //private field that stores size value
    private int size;
    /// <summary>
    /// A read-write instance property
    /// </summary>
    public int Size
    {
        get => size;
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            else
            {
                Width = value;
                Height = value;
                size = value;
            }
        }
    }
}
