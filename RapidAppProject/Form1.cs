using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using Newtonsoft.Json;
using WMPLib;
using AxWMPLib;
using SpotifyAPI.Web;

namespace RapidAppProject
{

    public partial class Form1 : Form
    {

        List<string[]> FileList = new List<string[]>(); // manages drag and drop files
        Playlist localPlaylist = new Playlist(); // playlist are loaded into and from this playlist.
        public string folderName = @"c:\Rapid Music";
        public Form1()
        {
            InitializeComponent();

            pb_PlaylistCover.SizeMode = PictureBoxSizeMode.StretchImage;
            axWindowsMediaPlayer1.settings.volume = 10;
          
            
            System.IO.Directory.CreateDirectory(folderName);

            this.AllowDrop = true;


        }

        public void loadPL()
        {
            clearPL();
            Song last;
            foreach (Song s in localPlaylist.Songs)
            {
                lbPlaylist.Items.Add(s.Name);
                last = s;
                pb_PlaylistCover.ImageLocation = last.Cover;
                axWindowsMediaPlayer1.URL = s.Location;
            }

            Console.WriteLine(localPlaylist.Songs.First().Cover);


            
        }
        public void clearPL()
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            FileList.Clear();
            lbPlaylist.Items.Clear();
            
            pb_PlaylistCover.Image = null;
        }
        public void Reset()
        {
            clearPL();
            localPlaylist.Songs.Clear();
        }
        public void setCover(object Sender, SpotifyData data)
        {
            pb_PlaylistCover.ImageLocation = data.cover;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {

            lbPlaylist.Items.Clear();

            string[] File = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (Path.GetExtension(File[0]) == ".mp3" || Path.GetExtension(File[0]) == ".flac")
            {
                Song s = new Song(File);
                s.UpdateCover += setCover;

                localPlaylist.Songs.Add(s);
                loadPL();
            }

        }


        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_clearPL_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = folderName;
            sfd.Filter = "JSON (*.json)|*.json";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                string json = JsonConvert.SerializeObject(localPlaylist, Formatting.Indented);
                Console.WriteLine(json);
                using(var sw= new System.IO.StreamWriter(sfd.FileName, false))
                {
                    sw.Write(json);
                }

            }
        }

        private void btn_loadPL_Click(object sender, EventArgs e)
        {
            lbPlaylist.Items.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = folderName;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                using(StreamReader reader = new StreamReader(ofd.FileName))
                {
                    string json = reader.ReadToEnd();
                    Playlist pl = JsonConvert.DeserializeObject<Playlist>(json);
                    localPlaylist = new Playlist( pl.Songs,pl.Cover);
                }
                loadPL();

            }
           
        }



        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.URL = localPlaylist.Songs[lbPlaylist.SelectedIndex].Location;


                pb_PlaylistCover.ImageLocation = localPlaylist.Songs[lbPlaylist.SelectedIndex].Cover;
            }
            catch
            {

            }


        }



        private void btn_AddCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                if(Path.GetExtension(ofd.FileName) == ".png" || Path.GetExtension(ofd.FileName) == ".jpg")
                {
                    localPlaylist.Cover = ofd.FileName;
                    pb_PlaylistCover.Image = System.Drawing.Image.FromFile(localPlaylist.Cover);
                }
            }
        }

        private void pb_PlaylistCover_Click(object sender, EventArgs e)
        {

        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int w = localPlaylist.Songs.Count;
            if (lbPlaylist.Items.Count > 0)
            {
                while (w > 1)
                {
                    w--;
                    int u = random.Next(w + 1);
                    Song value = localPlaylist.Songs[u];
                    localPlaylist.Songs[u] = localPlaylist.Songs[w];
                    localPlaylist.Songs[w] = value;
                }

                clearPL();
                foreach (Song s in localPlaylist.Songs)
                {
                    lbPlaylist.Items.Add(s.Name);
                }
                if (localPlaylist.Cover != null)
                {
                    //pb_PlaylistCover.Image = Image.FromFile(localPlaylist.Cover);
                }
                pb_PlaylistCover.ImageLocation = localPlaylist.Songs.First().Cover;

            }

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(lbPlaylist.Items.Count > 0)
            {
                if (lbPlaylist.SelectedIndex != 0)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    lbPlaylist.SelectedIndex--;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                else
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    lbPlaylist.SelectedIndex = localPlaylist.Songs.Count - 1;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                pb_PlaylistCover.ImageLocation = localPlaylist.Songs[lbPlaylist.SelectedIndex].Cover;
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lbPlaylist.Items.Count > 0)
            {
                if (lbPlaylist.SelectedIndex != localPlaylist.Songs.Count - 1)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    lbPlaylist.SelectedIndex++;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                else
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    lbPlaylist.SelectedIndex = 0;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                pb_PlaylistCover.ImageLocation = localPlaylist.Songs[lbPlaylist.SelectedIndex].Cover;
            }


        }
    }
}
