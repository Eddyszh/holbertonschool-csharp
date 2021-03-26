using System;

///<summary>
/// Public player class
///</summary>
public class Player
{
    ///<summary>
    /// Read-write name property
    ///</summary>
    public string name { get; set; }
    ///<summary>
    /// Read-write maxHp property
    ///</summary>
    public float maxHp { get; set; }
    ///<summary>
    /// Read-write hp property
    ///</summary>
    public float hp { get; set; }

    ///<summary>
    /// Constructor implementation
    ///</summary>
    ///<param name="name">Player's name, "Player" by default</param>
    ///<param name="maxHp">Player's maxhp 100 by default</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        this.name = name;
        this.maxHp = maxHp;
        hp = maxHp;
    }

    ///<summary>
    /// Method to print
    ///</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    ///<summary>
    /// Delegate declaration
    ///</summary>
    public delegate void CalculateHealth(float amount);

    ///<summary>
    /// Method to calculate damage
    ///</summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
            Console.WriteLine($"{name} takes 0 damage!");
        }
        else
        {
            Console.WriteLine($"{name} takes {damage} damage!");
        }
    }

    ///<summary>
    /// Method to calculate heal
    ///</summary>
    public void HealDamage(float heal)
    {
        Console.WriteLine($"{name} heals {heal} HP!");
        if (heal < 0)
            heal = 0;
    }
}
