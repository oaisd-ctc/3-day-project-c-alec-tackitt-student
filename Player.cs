public class Player
{
    private int health = 100;
    private string name;
    private int heals;
    private int maxHeals=3;
    private int blockCoolDown=0;
    public Player(string? name)
    {
        this.name=name;
    }
    
    public int Health
    {
        get { return health; }
        set
        {
            health = value;
            if (value <= 0)
            {
                Console.WriteLine($"{this.name} is out of health");
            }
        }
    }
    public string Name
    {
        get { return name; }
        set
        {
            value = name;
        }
    }
    public int BlockCoolDown
    {
        get { return blockCoolDown; }
        set { blockCoolDown=value; }
    }
}