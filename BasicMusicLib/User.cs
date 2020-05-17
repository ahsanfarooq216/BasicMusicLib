using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;


namespace BasicMusicLib
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public ObservableCollection<Song> MyMusicCollection { get; set; }
        public User(string name, string password)
        {
            Username = name;
            Password = password;
            StreamWriter sr = new StreamWriter($"/{name}.txt");
            MyMusicCollection = new ObservableCollection<Song>();
            SongManager.GetSampleMusic(MyMusicCollection);
        }
    }
}
