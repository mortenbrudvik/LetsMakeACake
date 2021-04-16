using System.Threading.Tasks;
using Flurl.Http;

namespace CakeConsole
{
    public class ChuckNorris
    {
        public async Task<Joke> TellJokeAsync()
            => await "https://api.chucknorris.io/jokes/random".GetJsonAsync<Joke>();
    }
}