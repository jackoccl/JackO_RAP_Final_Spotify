using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapidAppProject
{
    public partial class Form1 : Form
    {
        List<string[]> FileList = new List<string[]>();
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
            string[] File = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            FileList.Add(File);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < FileList.Count; i++)
            {
                listBox1.Items.Add(FileList[i][0]);
            }
        }

        private void btn_clearPL_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text (*.txt)|*.txt";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                using (var sw = new System.IO.StreamWriter(sfd.FileName, false))
                {
                    foreach (var items in listBox1.Items)
                        sw.Write(items.ToString() + Environment.NewLine);
                    MessageBox.Show("Saved");
                }
            }
        }

        private void btn_loadPL_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                var file = new System.IO.StreamReader(ofd.FileName);
                string line;
                while((line = file.ReadLine())!= null)
                {
                    listBox1.Items.Add(line);
                }
                

            }
        }
    }
}
