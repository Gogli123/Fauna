namespace Fauna;

public class Plane : Vehicle
{
	public Plane()
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Plane was created!");
		Console.ResetColor();
	}

	public void Fly()
	{
		Console.WriteLine("Plane is flying");
	}
}
