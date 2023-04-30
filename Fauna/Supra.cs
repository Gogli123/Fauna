namespace Fauna;

public class Supra : Vehicle
{
    public Supra()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Supra was created!");
        Console.ResetColor();
    }

    public void Drive()
    {
        Console.WriteLine("Supram aidgaa boshyo");
    }

    public void Speed()
    {
        Console.WriteLine("doyle sagac 400mph");
    }

    public void Sound()
    {
        Console.WriteLine("Ratatatatatatatatatatata");
    }
}
