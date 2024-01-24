
public static class Combat
{
    random Random=new Random();
    public int TakeDamage()
    {
     return Random.next(1,16);
    }
    public int Heal()
    {
        return Random.Next(5,10);
    }
    public bool block()
    {
        bool block=true;
        return block;
    }
    public int heal
}