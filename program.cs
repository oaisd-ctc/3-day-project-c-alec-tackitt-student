using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome.");
        Console.WriteLine("Press enter to start.");
        Console.ReadLine();
        while(true)
        {
            Console.WriteLine("Press control+c to stop this loop.");
        }
        Console.WriteLine("Game over.");
    }
}
