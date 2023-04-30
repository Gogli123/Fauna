namespace Fauna;

public class Eagle : Bird
{
	public Eagle()
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Eagle was created!");
		Console.ResetColor();
	}
}
