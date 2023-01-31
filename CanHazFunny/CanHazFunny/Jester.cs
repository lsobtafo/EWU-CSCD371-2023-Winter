using System;
namespace CanHazFunny
{
	public class Jester
	{
		private readonly IJokeService _jokeService;
		private readonly IJokeServiceOutput _jokeOutput;
        public Jester(IJokeService? jokeService, IJokeServiceOutput? jokeOutput)
        {
            if (jokeService == null)
            {
                throw new System.ArgumentNullException(nameof(jokeService));
            }
            if (jokeOutput == null)
            {
                throw new System.ArgumentNullException(nameof(jokeOutput));
            }
            _jokeService = jokeService;
            _jokeOutput = jokeOutput;
        }
        void TellJoke()
        {
            string joke = "Chuck Norris";
            while (joke.Contains("Chuck Norris"))
            {
                joke = _jokeService.GetJoke();
            }

            _jokeOutput.Output(joke);
        }
    }
}

