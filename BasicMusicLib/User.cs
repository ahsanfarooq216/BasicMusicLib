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
        StreamReader sr;
        StreamWriter sw;
        public User(string uName, string password)
        {
            Username = uName;
            Password = password;
            MyMusicCollection = new ObservableCollection<Song>();
            MyMusicCollection = SongManager.GetAllMusic(MyMusicCollection);
        }
    }
}
