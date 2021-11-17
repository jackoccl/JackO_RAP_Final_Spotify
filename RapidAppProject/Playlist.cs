using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace RapidAppProject
{
   
    public class Playlist
    {
  
        public string Name { get; set; } // playlist name
        public List<Song> Songs = new List<Song>(); 
        public string Cover { get; set; }
        public Playlist()
        {

        }
        public Playlist(string name, List<Song> songs, string cover)
        {
            Name = name;
            Songs = songs;
            Cover = cover;
        }

        public void setCover()
        {

        }
    }

    public class Song
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public Song() // default constructor for loading file from playlist
        {

        }
        public Song(string[] File)
        {
            Location = File[0];
            getName(Location);
        }

        public void getName(string filepath)
        {
            string FileName = Path.GetFileName(filepath);

            Name = Path.ChangeExtension(FileName, null);
        }
        
    }
}
