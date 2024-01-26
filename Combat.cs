
public static class Combat
{
     Random rnd = new Random();
    int num = rnd.Next();

    public static int TakeDamage()
    {
     return rnd.Next(1,16);
    }
    public static int Heal()
    {
        return Rnd.Next(5,10);
    }
    public static bool block()
    {
        bool block=true;
        return block;
    }
   
}