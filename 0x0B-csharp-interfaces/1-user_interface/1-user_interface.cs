using System;

/// <summary>
/// Abstract base class
/// </summary>
public abstract class Base
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
public interface IInteractive
{
    /// <summary>
    /// Interac method
    /// </summary>
    void Interact();
}

/// <summary>
/// Breakable interface
/// </summary>
public interface IBreakable
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
public interface ICollectable
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
/// Class to test the abstract class and interfaces
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// Interact method implementation
    /// </summary>
    public void Interact() { }

    /// <summary>
    /// Property implementation
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Break method implementation
    /// </summary>
    public void Break() { }

    /// <summary>
    /// Property implementation
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Collect method implementation
    /// </summary>
    public void Collect() { }
}
