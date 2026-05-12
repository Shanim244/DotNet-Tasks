using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    // Name: Shani Maroz
    // ID: 211579263
    internal class Song : MediaItem, IDownloadable
    {
        public Song(string title, int duration) :base(title, duration)
        {

        }

        // Overrides the Play method
        public override void Play()
        {
            Console.WriteLine($"The song {Title} played");
        }

        // Implementation of the Download method
        public void Download()
        {
            Console.WriteLine("Downloaded");
        }
    }
}
