using System.Diagnostics.Metrics;

namespace Task5
{
    internal class Program
    {
        // Name: Shani Maroz
        // ID: 211579263
        static void Main(string[] args)
        {
            
            MediaItem[] mediaItem = new MediaItem[3];


            // Array containing different media items
            mediaItem[0] = new Movie("A Quiet Place", 90);
            mediaItem[1] = new LiveStream("Metallica: European Tour 2026 Live", 120);
            mediaItem[2] = new Song("Enjoy the Silence", 3);

            // Loop through the array and play each one
            foreach (MediaItem item in mediaItem)
            {
                item.Play();
            }
            
            // New movies array
            Movie[] movies = new Movie[3];

            // Array containing different movies and durations
            movies[0] = new Movie("Avatar: The Way of Water", 192);
            movies[1] = new Movie("Gladiator", 155);
            movies[2] = new Movie("The Lion King", 88);

            // Sort movies by CompareTo function
            Array.Sort(movies);
            Console.WriteLine("");

            // Show the sorted movies list
            foreach (var movie in movies)
            {
                movie.Play();
            }
        }
    }
}
