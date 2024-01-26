using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Fighting Friends! a fun and interative game to play with your friend!");
        System.Console.WriteLine("the game is about turn based combat, pokemon style with the options to attack, heal, and block.");
        System.Console.WriteLine("try and outlive your friend in the shortest amount of moves!");
        Console.WriteLine("Press enter to start.");
        System.Console.WriteLine("");
        System.Console.WriteLine("enter Player 1's name:");
        string? player1Name = Console.ReadLine();
        System.Console.WriteLine("enter Player 2's name:");
        string? player2Name = Console.ReadLine();
        Player player1 = new Player(player1Name);
        Player player2 = new Player(player2Name);

        System.Console.WriteLine($"cool names {player1Name} and {player2Name}, good luck and have fun!");
        System.Console.WriteLine("");

        while(true)
        {
            Player1Selection(player1Name, player1, player2);
            if(player1.Health <= 0 || player2.Health <= 0){
                break;
            }
            Player2Selection(player2Name, player1, player2);
            if(player1.Health <= 0 || player2.Health <= 0){
                break;
            }
        }
        Console.WriteLine("Game over.");
        if (player1.Health > player2.Health){
            System.Console.WriteLine($"{player1.Name} won!");
        }
        else {
            System.Console.WriteLine($"{player2.Name} won!");
        }
    }
     public static void Player1Selection(string player1Name, Player player1, Player player2){
            Console.WriteLine($"{player1Name}, select what you want to do:");
            System.Console.WriteLine("1. Attack");
            System.Console.WriteLine("2. Block");
            System.Console.WriteLine("3. Heal");
            int player1Choice = int.Parse(Console.ReadLine()!);
            
            switch (player1Choice){
                case 1:
                    player2.Health = player2.Health - Combat.TakeDamage();
                    System.Console.WriteLine("");
                    System.Console.WriteLine($"{player2.Name}'s health is now {player2.Health}");
                    break;
                case 2:
                    //block method
                    System.Console.WriteLine("");
                    break;
                case 3:
                    //heal method
                    System.Console.WriteLine("");
                    break;
            }
        }
        public static void Player2Selection(string player2Name, Player player1, Player player2){
            Console.WriteLine($"{player2Name}, select what you want to do:");
            System.Console.WriteLine("1. Attack");
            System.Console.WriteLine("2. Block");
            System.Console.WriteLine("3. Heal");
            int player2Choice = int.Parse(Console.ReadLine()!);
            
            switch (player2Choice){
                case 1:
                    player1.Health = player1.Health - Combat.TakeDamage();
                    System.Console.WriteLine("");
                    System.Console.WriteLine($"{player1.Name}'s health is now {player1.Health}");
                    break;
                case 2:
                    //block method
                    System.Console.WriteLine("");
                    break;
                case 3:
                    //heal method
                    System.Console.WriteLine("");
                    break;
            }
        }
        
}
