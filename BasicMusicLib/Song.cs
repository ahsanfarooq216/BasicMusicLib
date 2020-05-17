using System;
using System.Collections.Generic;
using System.Text;

namespace BasicMusicLib
{
    public class Song
    {
        private string _audioFilePath;
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }
        public string ImagePath { get; set; }
        public string AudioFilePath
        {
            get { return _audioFilePath; }
            set { _audioFilePath = value; }
        }
        public Song(string artist, string title, string audioFilePath)
        {
            Artist = artist;
            Title = title;
            AudioFilePath = audioFilePath;
        }
    }
}
