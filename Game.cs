using System;
using System.Collections.Generic;

public class Game
{
    public Player Player { get; set; }
    public List<Enemy> Enemies { get; set; }

    public Game(string playerName)
    {
        Player = new Player(playerName);
        Enemies = new List<Enemy>();
        InitializeEnemies();
    }

    // Initialize some enemies for the game
    private void InitializeEnemies()
    {
        Enemies.Add(new Enemy("Goblin", 50, 10));
        Enemies.Add(new Enemy("Orc", 80, 15));
        Enemies.Add(new Enemy("Dragon", 150, 30));
    }

    // Main game loop
    public void Start()
    {
        Console.WriteLine($"Welcome, {Player.Name}!\n");
        while (Player.IsAlive() && Enemies.Count > 0)
        {
            // Show player status
            Console.WriteLine($"Player Health: {Player.Health}");
            Console.WriteLine($"Enemies Remaining: {Enemies.Count}\n");

            // Attack first enemy in the list
            Enemy currentEnemy = Enemies[0];
            Player.Attack(currentEnemy);

            // If the enemy is defeated, remove it from the list
            if (!currentEnemy.IsAlive())
            {
                Console.WriteLine($"{currentEnemy.Name} has been defeated!");
                Enemies.RemoveAt(0);
            }

            // Enemy attacks the player if it's still alive
            if (currentEnemy.IsAlive())
            {
                currentEnemy.Attack(Player);
            }

            // Small pause to make the game more readable
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        // Game over message
        if (Player.IsAlive())
        {
            Console.WriteLine("You have defeated all enemies!");
        }
        else
        {
            Console.WriteLine("Game Over! You have been defeated.");
        }
    }
}
