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
/// Class to test the abstract class and interfaces
/// </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// Interact method implementation
    /// </summary>
    public void Interact()
    {
        // Method implementation.
    }

    /// <summary>
    /// Property implementation
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Break method implementation
    /// </summary>
    public void Break()
    {
        // Method implementation.
    }

    /// <summary>
    /// Property implementation
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Collect method implementation
    /// </summary>
    public void Collect()
    {
        // Method implementation.
    }
}
