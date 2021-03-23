using System;

/// <summary>
/// Abstract base class
/// </summary>
abstract class Base
{
    /// <summary>
    /// A read-write instance property
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Public method that overrides the output of ToString
    /// </summary>
    /// <return>
    /// New output to stdout
    /// </return>
    public override string ToString()
    {
        return String.Format("{0} is a {1}", name, GetType().Name);
    }
}
