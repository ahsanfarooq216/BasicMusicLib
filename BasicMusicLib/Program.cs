using System;

namespace BasicMusicLib
{
    class Program
    {
        static void Main(string[] args)
        {
            var musicfan1 = new User("Mozart Jr.", "banana");
            Console.WriteLine(musicfan1.MyMusicCollection.Count);
            SongManager.GetSongsByArtist(musicfan1.MyMusicCollection, "derek");
            Console.WriteLine(musicfan1.MyMusicCollection.Count);
            Console.WriteLine(musicfan1.MyMusicCollection[0].Title);
        }
    }
}
