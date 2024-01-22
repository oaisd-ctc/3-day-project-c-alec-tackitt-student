public class Player
{
    private int health;
    private string name;
    private int heals;
    private int maxHeals=3;
    public Player(string name)
    {
        this.name=name;
    }
    public string GetName()
    {
        return name;
    }
    public void SetHealth(int number)
    {
        if(number <= 0)
        {
            Console.WriteLine("You must enter a positive number.");
        }
        else
        {
            health = number;
        }
    }
    public int GetHealth()
    {
        return health;
    }
}