public class Player
{
    private int health = 100;
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
    public int Health
        {
            get { return name; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("you are out of health");
                }
                else
                {
                    name = value;
                }
            }
        }
    public int GetHealth()
    {
        return health;
    }
}
