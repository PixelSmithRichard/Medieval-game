using System;

public class Player
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public int Speed { get; set; }

    public Player(string name)
    {
        Name = name;
        Health = 100; // Default health
        AttackPower = 20; // Default attack power
        Speed = 5; // Default speed
    }

    // Method to attack an enemy
    public void Attack(Enemy enemy)
    {
        Console.WriteLine($"{Name} attacks {enemy.Name}!");
        enemy.TakeDamage(AttackPower);
    }

    // Method to take damage
    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0) Health = 0;
        Console.WriteLine($"{Name} takes {damage} damage! Health: {Health}");
    }

    // Check if the player is still alive
    public bool IsAlive()
    {
        return Health > 0;
    }
}
