namespace Fauna
{
    public class Cat : Animal
    {
		public Cat() : base("cat")
        {
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Cat was created!");
			Console.ResetColor();
		}

		public void Meow()
		{
			Console.WriteLine("Cat is Meowing");
		}
		public override void Move()
		{
			Console.WriteLine("Cat is moving");
		}

		public void CatchingMouse()
		{
			Console.WriteLine("SuperCat is catching mouse");
		}
	}
}