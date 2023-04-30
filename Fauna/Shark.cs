namespace Fauna;

public class Shark : Fish
{
	public Shark()
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Shark was created!");
		Console.ResetColor();
	}
}
