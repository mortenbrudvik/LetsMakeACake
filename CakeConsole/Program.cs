using System;
using System.Threading.Tasks;

namespace CakeConsole
{
    internal class Program
    {
        private static async Task Main()
        {
            var chuckNorris = new ChuckNorris();

            Console.WriteLine(await chuckNorris.TellJokeAsync());
        }
    }
}
