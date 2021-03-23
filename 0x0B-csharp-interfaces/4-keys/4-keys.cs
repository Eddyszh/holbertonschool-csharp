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

/// <summary>
/// Decoration class to test abstract class and interfaces
/// </summary>
class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem;

    /// <summary>
    /// Property implementation
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Contrusctor implementation
    /// </summary>
    /// <param name="name">Decoration's name</param>
    /// <param name="durability">Decoration's durability</param>
    /// <param name="isQuestItem">isQuestItem value</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");
        else
        {
            this.name = name;
            this.durability = durability;
            this.isQuestItem = isQuestItem;
        }

    }

    /// <summary>
    /// Interac method implementation
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine("The {0} has been broken.", name);
        else if (isQuestItem == true)
            Console.WriteLine("You look at the {0}. There's a key inside.", name);
        else
            Console.WriteLine("You look at the {0}. Not much to see here.", name);
    }

    /// <summary>
    /// Break method implementation
    /// </summary>
    public void Break()
    {
        durability--;
        if (durability > 0)
            Console.WriteLine("You hit the {0}. It cracks.", name);
        else if (durability == 0)
            Console.WriteLine("You smash the {0}. What a mess.", name);
        else if (durability < 0)
            Console.WriteLine("The {0} is already broken.", name);
    }
}

/// <summary>
/// Key class to test abstract class and interfaces
/// </summary>
class Key : Base, ICollectable
{
    /// <summary>
    /// Property implementation
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Contrusctor implementation
    /// </summary>
    /// <param name="name">Key's name</param>
    /// <param name="isCollected">isCollected value</param>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Collect method implementation
    /// </summary>
    public void Collect()
    {
        if (isCollected == false)
        {
            isCollected = true;
            Console.WriteLine("You pick up the {0}.", name);
        }
        else
        {
            Console.WriteLine("You have already picked up the {0}.", name);
        }
    }
}
