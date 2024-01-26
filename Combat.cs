
public static class Combat
{

   
    public static int TakeDamage()
    {
     return new Random().Next(1,16);
    }
    public static int Heal()
    {
        return new Random().Next(5,10);
    }
    public static bool block()
    {
        bool block=true;
        return block;
    }
   
}