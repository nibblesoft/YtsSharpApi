using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YtsSharpApi.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var ytsClient = new YtsClient();
            foreach (var movie in ytsClient.GetListMovies().data.movies)
            {
                Console.WriteLine($"Title: {movie.title}, Rating:{movie.rating}");
            }
            Console.ReadLine();
        }
    }
}
