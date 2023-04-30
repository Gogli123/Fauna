namespace Fauna;

public abstract class Creature : Comparable
{
    public Creature()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Creature was created!");
        Console.ResetColor();
        Breath();
    }

    public string Name { get; set; }
    public int Weight { get; set; }

    public virtual void Move()
    {
        Console.WriteLine("Creature is moving");
    }

    protected abstract void Breath();

    public override int CompareTo(object obj)
    {
        Creature other = (Creature)obj;

        if (Weight > other.Weight)
        {
            return 1;
        }
        else if (Weight < other.Weight)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}
