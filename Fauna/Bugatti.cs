namespace Fauna;

public class Bugatti : Vehicle
{
    public Bugatti()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bugatti was created!");
        Console.ResetColor();
    }

    public void Drive()
    {
        Console.WriteLine("Bugatti dagazaobs");
    }

    public void Hp()
    {
        Console.WriteLine("doyle");
    }
}
