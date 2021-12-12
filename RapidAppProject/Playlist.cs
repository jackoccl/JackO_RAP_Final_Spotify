using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyAPI.Web;
using System.Text.RegularExpressions;   


using System.IO;

namespace RapidAppProject
{
   
    public class Playlist
    {
        SpotifyClient spotify;
  
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


    }

    public class Song
    {
        public string Name { get; set; }
        public string Artist { get; set; } = "";
        public string Location { get; set; }

        public string Cover { get; set; }
        public Song() // default constructor for loading file from playlist
        {

        }
        public Song(string[] File)
        {
            Location = File[0];
            getName(Location);
            setCover();
        }
        public async void setCover()
        {

            var config = SpotifyClientConfig
                .CreateDefault()
                .WithAuthenticator(new ClientCredentialsAuthenticator("c95e453f00374e509b3bc34bc98dadf2", "56fb4d3a5e214b56941ad22ea6af3cbb"));
            var spotify = new SpotifyClient(config);

            string query = $"{Name} {Artist}";

           // Console.WriteLine(query);

            var search = await spotify.Search.Item(new SearchRequest(SearchRequest.Types.All, query));

            try
            {
                Cover = search.Tracks.Items.First().Album.Images.First().Url;
            }
            catch
            {
                Cover = "https://i.scdn.co/image/ab67616d0000b273c5663e50de353981ed2b1a37";
                Console.WriteLine("Cover not found");
            }
        }
        public void getName(string filepath)
        {
            string pattern = @"^(.*?)\s*-\s*(.*?)$";
            Regex rx = new Regex(pattern);


            string FileName = Path.GetFileName(filepath);

            FileName = FileName.Replace('_', ' ');
            // Console.WriteLine(FileName);
            if (rx.Matches(FileName).Count > 0)
            {
               
                Artist = rx.Matches(FileName)[0].Groups[1].Value;
                Name = Path.ChangeExtension(rx.Matches(FileName)[0].Groups[2].Value, null);
            }
            else
            {
                Name = Path.ChangeExtension(FileName, null);
            }
            Console.WriteLine(Name);
            Console.WriteLine(Artist);









        }
        
    }
}
