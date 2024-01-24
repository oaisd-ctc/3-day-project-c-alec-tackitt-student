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
        string player1Name = Console.ReadLine();
        System.Console.WriteLine("enter Player 2's name:");
        string player2Name = Console.ReadLine();

        Player player1 = new Player(player1Name);
        Player player2 = new Player(player2Name);

        System.Console.WriteLine($"cool names {player1Name} and {player2Name}, good luck and have fun!");

        while(true)
        {
            Console.WriteLine("Press control+c to stop this loop.");
        }
        Console.WriteLine("Game over.");
    }
}
