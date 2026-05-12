using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    // Name: Shani Maroz
    // ID: 211579263
    internal class Movie : MediaItem, IDownloadable, IComparable
    {
        public Movie(string title, int duration) : base(title, duration)
        {

        }

        // Overrides the Play method
        public override void Play()
        {
            Console.WriteLine($"Playing movie {Title}");
        }

        // Implementation of the Download method
        public void Download()
        {
            Console.WriteLine("Downloading movie file");
        }

        // Sorts movies by duration
        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;

            Movie M = (Movie)obj;

            if (this.Duration < M.Duration)
            {
                return -1;
            }
            else if (this.Duration > M.Duration)
            {
                return 1; 
            }
            return 0;
        }
    }
}
