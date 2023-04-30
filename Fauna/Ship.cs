namespace Fauna;

public class Ship : Vehicle
{
	public Ship()
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Ship was created!");
		Console.ResetColor();
	}

	public void Sail()
	{
		Console.WriteLine("Ship is sailing");
	}
}
