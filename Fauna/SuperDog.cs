namespace Fauna;

public class SuperDog : Dog
{
    public SuperDog()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("SuperDog object was created");
        Console.ResetColor();
    }

    public void Singing()
    {
        Console.WriteLine("SuperDog is singing");
	}

    public void Fly()
    {
	    Console.WriteLine("SuperDog is Flying");
    }

    public override void Move()
    {
	    Console.WriteLine("SuperDog is moving");
    }

	protected override void Breath()
    {
        base.Breath();
        Console.WriteLine("SuperDog is breathing with Legs");
    }
}
