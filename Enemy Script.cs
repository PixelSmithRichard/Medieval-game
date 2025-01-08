using System;

public class Enemy
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }

    public Enemy(string name, int health, int attackPower)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
    }

    // Method to attack the player
    public void Attack(Player player)
    {
        Console.WriteLine($"{Name} attacks {player.Name}!");
        player.TakeDamage(AttackPower);
    }

    // Method to take damage
    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0) Health = 0;
        Console.WriteLine($"{Name} takes {damage} damage! Health: {Health}");
    }

    // Check if the enemy is still alive
    public bool IsAlive()
    {
        return Health > 0;
    }
}
