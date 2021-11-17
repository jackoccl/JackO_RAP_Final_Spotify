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

namespace RapidAppProject
{

    public partial class Form1 : Form
    {
        List<string[]> FileList = new List<string[]>(); // manages drag and drop files
        Playlist localPlaylist = new Playlist(); // playlist are loaded into and from this playlist.
        public Form1()
        {
            InitializeComponent();

            string folderName = @"c:\Rapid Music";
            string pathString = System.IO.Path.Combine(folderName, "My Files"); // drag drop will save files here. List box will read mp3s from the dir
            System.IO.Directory.CreateDirectory(pathString);

            this.AllowDrop = true;

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
                localPlaylist.Songs.Add(new Song(File));
                PopulateLB();
            }

            
            //FileList.Add(File);
            //lbPlaylist.Items.Clear();
            //for (int i = 0; i < FileList.Count; i++)
            //{
            //    lbPlaylist.Items.Add(FileList[i][0]);
            //}
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
            lbPlaylist.Items.Clear();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JSON (*.json)|*.json";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                string json = JsonConvert.SerializeObject(localPlaylist, Formatting.Indented);
                Console.WriteLine(json);
                using(var sw= new System.IO.StreamWriter(sfd.FileName, false))
                {
                    sw.Write(json);
                }
                //MessageBox.Show(" Saved! ");
                //lbPlaylist.Items.Clear();
                //using (var sw = new System.IO.StreamWriter(sfd.FileName, false))
                //{
                //    foreach (var items in lbPlaylist.Items)
                //        sw.Write(items.ToString() + Environment.NewLine);
                //    MessageBox.Show("Saved");
                //}
            }
        }

        private void btn_loadPL_Click(object sender, EventArgs e)
        {
            lbPlaylist.Items.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                //var file = new System.IO.StreamReader(ofd.FileName);
                using(StreamReader reader = new StreamReader(ofd.FileName))
                {
                    string json = reader.ReadToEnd();
                    Playlist pl = JsonConvert.DeserializeObject<Playlist>(json);
                    // List<Song> Songs = JsonConvert.DeserializeObject<List<Song>>(json);
                    localPlaylist = new Playlist(pl.Name, pl.Songs,pl.Cover);
                }
                PopulateLB();





                //var file = new System.IO.StreamReader(ofd.FileName);
                //string line;
                //while((line = file.ReadLine())!= null)
                //{
                //    lbPlaylist.Items.Add(line);
                //}


            }
           
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            

        }

        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = localPlaylist.Songs[lbPlaylist.SelectedIndex].Location;

        }
        
        public void PopulateLB()
        {
            lbPlaylist.Items.Clear();
            foreach (Song s in localPlaylist.Songs)
            {
                lbPlaylist.Items.Add(s.Name);
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
                    pb_PlaylistCover.Image = Image.FromFile(localPlaylist.Cover);
                }
            }
        }

        private void pb_PlaylistCover_Click(object sender, EventArgs e)
        {

        }
    }
}
