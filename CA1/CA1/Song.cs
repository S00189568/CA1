using System;
using System.Collections.Generic;
using System.Text;

namespace CA1
{
    enum Genre
    {
        Rock,
        Pop,
        Dance,
        Other
    }
    class Song:IComparable 
    {
        //Properties
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }
        public Genre genre { get; set; }

        //Constructors
        public Song(string title, string artist, double duration,Genre pop) : this(title, artist, duration)
        {
            Title = title;
            Artist = artist;
            Duration = duration;         
        }

        public Song(string title, string artist, double duration)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
        }

        //Methods
        public override string ToString()
        {
            return string.Format("Artist {0}  Song {1}   Duration {2}   Genre {3}",
                Artist, Title, Duration, genre);
        }

        public int CompareTo(object obj)
        {
            Song that = (Song)obj;

            return this.Artist.CompareTo(that.Artist);          
        }
    }
}
