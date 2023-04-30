namespace Fauna;

class Program
{
	static void Main(string[] args)
	{
		Dog[] dogs =
		{
			new Dog("Germanuli nagazi") { Weight = 25 },
			new Dog("Cane korso") { Weight = 35 },
			new Dog("Bull") { Weight = 20 },
			new Dog("Akita") { Weight = 12 },
			new Dog("Pudeli") { Weight = 4 },
			new Dog("Pitbuli") { Weight = 15 },
			new Dog("Labradori") { Weight = 10 },
		};

		Console.Clear();

		MyTools.Sort(dogs);

		for (int i = 0; i < dogs.Length; i++)
		{
			Console.WriteLine($"{dogs[i].Name}, {dogs[i].Weight}");
		}
	}
}
