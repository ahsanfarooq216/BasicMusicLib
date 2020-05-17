using System;

namespace BasicMusicLib
{
    class Program
    {
        static void Main(string[] args)
        {
            var musicfan1 = new User("Mozart Jr.", "banana");
            Console.WriteLine($"There are {musicfan1.MyMusicCollection.Count} songs in {musicfan1.Username}'s collection");
            SongManager.GetSongsByArtist(musicfan1.MyMusicCollection, "derek");
            Console.WriteLine($"{musicfan1.Username} has the following {musicfan1.MyMusicCollection.Count} songs by derek in their collection:");
            for (int i = 0; i < musicfan1.MyMusicCollection.Count; i++)
            {
                Console.WriteLine(musicfan1.MyMusicCollection[i].Title);
            }
            var song1 = new Song("Lights", "Drive my soul", "@C:/Users/Ahsan/Desktop/Lights_-_Drive My Soul.mp3");
            SongManager.GetAllMusic(musicfan1.MyMusicCollection);
            Console.WriteLine($"There are {musicfan1.MyMusicCollection.Count} songs in {musicfan1.Username}'s collection");
            musicfan1.MyMusicCollection.Add(song1);
            Console.WriteLine($"There are {musicfan1.MyMusicCollection.Count} songs in {musicfan1.Username}'s collection");
            Console.WriteLine(song1.Title);
            song1.Title = "Rigatoni";
            Console.WriteLine(song1.Title);
        }
    }
}
