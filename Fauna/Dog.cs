﻿namespace Fauna;

public /*sealed*/ class Dog : Animal
{
	public Dog() : base("dog")
    {
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Dog was created!");
		Console.ResetColor();
	}

	public Dog(string name) : base(name)
    {
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine($"Dog with name {name} was created!");
		Console.ResetColor();
	}

    public void Bark()
	{
        Console.WriteLine("Dog is barking");
	}

    public override void Move()
    {
	    Console.WriteLine("Dog is moving");
    }

	protected /*sealed*/ override void Breath()
	{
		base.Breath();
		Console.WriteLine("Dog is breathing with Legs");
	}
}
