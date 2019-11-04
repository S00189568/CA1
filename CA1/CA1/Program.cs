using System;
using System.Collections.Generic;

namespace CA1
{
    class Program
    {
        static void Main(string[] args)
        {

            Song s1 = new Song("ED SHEERAN", "BEAUTIFUL PEOPLE", 3.15, Genre.Pop);
            Song s2 = new Song("REGARD", "RIDE IT", 3.37, Genre.Dance);
            Song s3 = new Song("TONES & I", "DANCE MONKEY", 4.20, Genre.Dance);
            Song s4 = new Song("POST MALONE", "CIRLES", 3.25, Genre.Pop);
            Song s5 = new Song("ED SHEERAN", "SOUTH OF THE BORDER", 4.26, Genre.Other);


            Song[] allSong = new Song[5];
            allSong[0] = s1;
            allSong[1] = s2;
            allSong[2] = s3;
            allSong[3] = s4;
            allSong[4] = s5;

            DisplaySong(allSong);

            Console.WriteLine();
            Array.Sort(allSong);

            Console.WriteLine("Sorting the playlist by artist, then by song title :");

        }//end of main method

        static void DisplaySong(Song[] allSong)
        {
            foreach  (Song s in allSong)
            {
                Console.WriteLine(s);
            }
        }//end of allSong method
    }
}
