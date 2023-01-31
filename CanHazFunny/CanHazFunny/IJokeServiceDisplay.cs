using System;
namespace CanHazFunny
{
	public interface IJokeServiceDisplay
	{
        public void Display(string message)
        {
            Console.WriteLine(message);
        }
    }
}

