namespace Fauna;

public class SuperCat : Cat
{
    public SuperCat()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("SuperCat was created!");
        Console.ResetColor();
    }

    public void Fly()
    {
	    Console.WriteLine("SuperCat is flying");
    }

    public override void Move()
    {
	    Console.WriteLine("SuperCat is moving");
    }
}
