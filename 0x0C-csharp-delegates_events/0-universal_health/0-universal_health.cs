using System;

///<summary>
/// Public player class
///</summary>
public class Player
{
    ///<summary>
    /// Read-write name property
    ///</summary>
    string name { get; set; }
    ///<summary>
    /// Read-write maxHp property
    ///</summary>
    float maxHp { get; set; }
    ///<summary>
    /// Read-write hp property
    ///</summary>
    float hp { get; set; }

    ///<summary>
    /// Constructor implementation
    ///</summary>
    ///<param name="name">Player's name, "Player" by default</param>
    ///<param name="maxHp">Player's maxhp 100 by default</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }
        hp = this.maxHp;
    }

    ///<summary>
    /// Method to print
    ///</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}
