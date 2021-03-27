using System;

///<summary>
/// Public enum
///</summary>
public enum Modifier
{
    ///<summary>Weak modifier</summary>
    Weak,
    ///<summary>Base modifier</summary>
    Base,
    ///<summary>Strong modifier</summary>
    Strong
}

///<summary>
/// Class for eventargs data
///</summary>
public class CurrentHPArgs : EventArgs
{
    ///<summary>
    /// Read only property
    ///</summary>
    public readonly float currentHp;

    ///<summary>
    /// Constructor implementation
    ///</summary>
    ///<param name="newHp">hp value</param>
    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
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
    /// Read-write private property
    ///</summary>
    private string status { get; set; }

    ///<summary>
    /// Constructor implementation
    ///</summary>
    ///<param name="name">Player's name, "Player" by default</param>
    ///<param name="maxHp">Player's maxhp 100 by default</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
            {
                maxHp = 100f;
                Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            }
        this.maxHp = maxHp;
        this.name = name;
        this.hp = maxHp;
        this.status = $"{name} is ready to go!";
        HPCheck += CheckStatus;
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
        if (damage < 0)
            damage = 0;
        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(hp - damage);
    }

    ///<summary>
    /// Method to calculate heal
    ///</summary>
    ///<param name="heal">amount of heal</param>
    public void HealDamage(float heal)
    {
        Console.WriteLine($"{name} heals {heal} HP!");
        if (heal >= 0)
            ValidateHP(hp + heal);
    }

    ///<summary>
    /// Method to calculae the player's hp
    ///</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;
        OnCheckStatus(new CurrentHPArgs(this.hp));
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

    ///<summary>
    /// Eventhandler declaration
    ///</summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

    ///<summary>
    /// Method to use eventhandler
    ///</summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
            status = $"{name} is in perfect health!";
        else if (e.currentHp >= (this.maxHp / 2f))
            status = $"{name} is doing well!";
        else if (e.currentHp >= (this.maxHp / 4f))
            status = $"{name} isn't doing too great...";
        else if (e.currentHp > 0)
            status = $"{name} needs help!";
        else
            status = $"{name} is knocked out!";
        Console.WriteLine(status);
    }

    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
            Console.WriteLine("Health has reached zero!");
        else
            Console.WriteLine("Health is low!");
    }

    ///<summary>
    /// Method to use eventhandler
    ///</summary>
    public void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp <= (maxHp / 4f))
            HPCheck += HPValueWarning;
        HPCheck(this, e);
        HPCheck -= HPValueWarning;
    }
}
