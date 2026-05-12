using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    // Name: Shani Maroz
    // ID: 211579263

    // Base abstract class
    abstract class MediaItem
    {
        // Properties

        // Title of the media
        public string Title { get; set; }

        // Duration in minutes
        public int Duration { get; set; }

        public MediaItem(string title, int duration)
        {
            Title = title;
            Duration = duration;
        }

        // Abstract method without implementation
        public abstract void Play();
    }
}
