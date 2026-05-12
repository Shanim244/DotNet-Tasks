using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    // Name: Shani Maroz
    // ID: 211579263
    internal class LiveStream : MediaItem
    {
        public LiveStream(string title, int duration) : base( title, duration)
        {

        }

        // Overrides the Play method
        public override void Play()
        {
            Console.WriteLine($"Live stream {Title} played");
        }
    }
}
