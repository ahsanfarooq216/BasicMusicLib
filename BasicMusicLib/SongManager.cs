using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace BasicMusicLib
{
   public static class SongManager
    {
        public static void GetSampleMusic(ObservableCollection<Song> songs)
        {
            var sampleSongs = getSampleMusic();
            songs.Clear();
            sampleSongs.ForEach(s => songs.Add(s));
        }

        public static void GetSongsByArtist(ObservableCollection<Song> songs, string artist)
        {
            var allSongs = getSampleMusic();
            var filteredSongs = allSongs.Where(s => String.Equals(s.Artist.ToLower(), artist.ToLower())).ToList();
            songs.Clear();
            filteredSongs.ForEach(s => songs.Add(s));
        }
        public static void GetSongsByTitle(ObservableCollection<Song> songs, string title)
        {
            var allSongs = getSampleMusic();
            var filteredSongs = allSongs.Where(s => String.Equals(s.Title.ToLower(), title.ToLower())).ToList();
            songs.Clear();
            filteredSongs.ForEach(s => songs.Add(s));
        }
        private static List<Song> getSampleMusic()
        {
            var sampleSongs = new List<Song>();
            sampleSongs.Add(new Song("derek", "annalise", $"/Assets/SampleMusic/Derek_Clegg_-_Annalise.mp3"));
            sampleSongs.Add(new Song("derek", "get us there", $"/Assets/SampleMusic/Derek_Clegg_-_Ill_Almost_Get_Us_There.mp3"));
            sampleSongs.Add(new Song("Jahzzar", "siesta", $"/Assets/SampleMusic/Jahzzar_-_Siesta.mp3"));
            sampleSongs.Add(new Song("Monplaisir", "estampe galactus", $"/Assets/SampleMusic/Monplaisir_-_Estampe_Galactus_Barbare_Epaul_Giraffe_Ennui.mp3"));
            return sampleSongs;
        }
    }
}
