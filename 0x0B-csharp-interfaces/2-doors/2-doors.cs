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

/// <summary>
/// Interactive interface
/// </summary>
interface IInteractive
{
    /// <summary>
    /// Interac method
    /// </summary>
    void Interact();
}

/// <summary>
/// Breakable interface
/// </summary>
interface IBreakable
{
    /// <summary>
    /// A read-write property
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Break method
    /// </summary>
    void Break();
}

/// <summary>
/// Collectable interface
/// </summary>
interface ICollectable
{
    /// <summary>
    /// A read-write instance property
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Collect method
    /// </summary>
    void Collect();
}

/// <summary>
/// Door class to test abstract class and interfaces
/// </summary>
class Door : Base, IInteractive
{
    /// <summary>
    /// Contrusctor implementation
    /// </summary>
    /// <param name="_name">Door's name</param>
    public Door(string _name ="Door")
    {
        name = _name;
    }

    /// <summary>
    /// Interac method implementation
    /// </summary>
    public void Interact()
    {
        Console.WriteLine("You try to open the {0}. It's locked.", name);
    }
}
