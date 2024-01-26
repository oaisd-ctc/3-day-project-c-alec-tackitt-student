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
        string player1Name = Console.ReadLine()?;
        System.Console.WriteLine("enter Player 2's name:");
        string player2Name = Console.ReadLine()?:;
        Player :player1 = new Player(player1Name);
        Player :player2 = new Player(player2Name);

        System.Console.WriteLine($"cool names {player1Name} and {player2Name}, good luck and have fun!");

        while(true)
        {
            Player1Selection(player1Name);
            Player2Selection(player2Name);
            CheckForDeath();

            
        }
        Console.WriteLine("Game over.");
    }
     public static void Player1Selection(string player1Name){
            Console.WriteLine($"{player1Name} sleect what you want to do:");
            System.Console.WriteLine("1. Attack");
            System.Console.WriteLine("2. Block");
            System.Console.WriteLine("3. Heal");
            int player1Choice = int.parse(Console.ReadLine()!);
            
            switch (player1Choice){
                case 1:
                    //attack method
                    break;
                case 2:
                    //block method
                case 3:
                    //heal method
                    break;
            }
        }
        public static void Player2Selection(string player2Name){
            Console.WriteLine($"{player1Name} sleect what you want to do:");
            System.Console.WriteLine("1. Attack");
            System.Console.WriteLine("2. Block");
            System.Console.WriteLine("3. Heal");
            int player2Choice = int.parse(Console.ReadLine()!);
            
            switch (player2Choice){
                case 1:
                    //attack method
                    break;
                case 2:
                    //block method
                case 3:
                    //heal method
                    break;
            }
        }
        public static void CheckForDeath(){

        }
}
