using System;

///<summary>
/// Public enum
///</summary>
public enum Modifier
{
    Weak,
    Base,
    Strong
}

///<summary>
/// Public delegate
///</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

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
    ///<param name="damage">amount of damage</param>
    public void TakeDamage(float damage)
    {
        CalculateHealth calDam = ValidateHP;
        if (damage < 0)
        {
            damage = 0;
            Console.WriteLine($"{name} takes 0 damage!");
        }
        else
        {
            calDam(hp - damage);
            Console.WriteLine($"{name} takes {damage} damage!");
        }
    }

    ///<summary>
    /// Method to calculate heal
    ///</summary>
    ///<param name="heal">amount of heal</param>
    public void HealDamage(float heal)
    {
        CalculateHealth calHea = ValidateHP;
        if (heal < 0)
        {
            heal = 0;
            Console.WriteLine($"{name} heals 0 HP!");
        }
        else
        {
            calHea(hp + heal);
            Console.WriteLine($"{name} heals {heal} HP!");
        }
    }

    ///<summary>
    /// Method to calculae the player's hp
    ///</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            hp = 0;
        else if (newHp > maxHp)
            hp = maxHp;
        else
            hp = newHp;
    }

    ///<summary>
    /// Method to modify the damage or heal taken
    ///</summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return baseValue * .5f;
        else if (modifier == Modifier.Base)
            return baseValue;
        else
            return baseValue * 1.5f;
    }
}
