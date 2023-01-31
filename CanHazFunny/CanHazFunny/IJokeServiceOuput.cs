using System;
namespace CanHazFunny
{
	public interface IJokeServiceOutput :IJokeServiceDisplay
	{
		public void Output(string message)
		{
			Console.WriteLine(message);
		}
	}
}

