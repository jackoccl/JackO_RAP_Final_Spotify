
namespace RapidAppProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbPlaylist = new System.Windows.Forms.ListBox();
            this.btn_clearPL = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_loadPL = new System.Windows.Forms.Button();
            this.pb_PlaylistCover = new System.Windows.Forms.PictureBox();
            this.btn_AddCover = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PlaylistCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPlaylist
            // 
            this.lbPlaylist.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbPlaylist.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaylist.ForeColor = System.Drawing.Color.Black;
            this.lbPlaylist.FormattingEnabled = true;
            this.lbPlaylist.ItemHeight = 28;
            this.lbPlaylist.Location = new System.Drawing.Point(7, 23);
            this.lbPlaylist.Margin = new System.Windows.Forms.Padding(4);
            this.lbPlaylist.Name = "lbPlaylist";
            this.lbPlaylist.Size = new System.Drawing.Size(195, 424);
            this.lbPlaylist.TabIndex = 0;
            this.lbPlaylist.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_clearPL
            // 
            this.btn_clearPL.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_clearPL.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearPL.ForeColor = System.Drawing.Color.Black;
            this.btn_clearPL.Location = new System.Drawing.Point(479, 502);
            this.btn_clearPL.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clearPL.Name = "btn_clearPL";
            this.btn_clearPL.Size = new System.Drawing.Size(170, 35);
            this.btn_clearPL.TabIndex = 3;
            this.btn_clearPL.Text = "Clear Playlist";
            this.btn_clearPL.UseVisualStyleBackColor = false;
            this.btn_clearPL.Click += new System.EventHandler(this.btn_clearPL_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Save.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Location = new System.Drawing.Point(479, 555);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(170, 31);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save Playlist";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_loadPL
            // 
            this.btn_loadPL.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_loadPL.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadPL.ForeColor = System.Drawing.Color.Black;
            this.btn_loadPL.Location = new System.Drawing.Point(479, 605);
            this.btn_loadPL.Margin = new System.Windows.Forms.Padding(4);
            this.btn_loadPL.Name = "btn_loadPL";
            this.btn_loadPL.Size = new System.Drawing.Size(170, 31);
            this.btn_loadPL.TabIndex = 5;
            this.btn_loadPL.Text = "Load Playlist";
            this.btn_loadPL.UseVisualStyleBackColor = false;
            this.btn_loadPL.Click += new System.EventHandler(this.btn_loadPL_Click);
            // 
            // pb_PlaylistCover
            // 
            this.pb_PlaylistCover.Location = new System.Drawing.Point(13, 45);
            this.pb_PlaylistCover.Margin = new System.Windows.Forms.Padding(4);
            this.pb_PlaylistCover.Name = "pb_PlaylistCover";
            this.pb_PlaylistCover.Size = new System.Drawing.Size(411, 330);
            this.pb_PlaylistCover.TabIndex = 8;
            this.pb_PlaylistCover.TabStop = false;
            this.pb_PlaylistCover.Click += new System.EventHandler(this.pb_PlaylistCover_Click);
            // 
            // btn_AddCover
            // 
            this.btn_AddCover.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_AddCover.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCover.ForeColor = System.Drawing.Color.Black;
            this.btn_AddCover.Location = new System.Drawing.Point(146, 572);
            this.btn_AddCover.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddCover.Name = "btn_AddCover";
            this.btn_AddCover.Size = new System.Drawing.Size(145, 40);
            this.btn_AddCover.TabIndex = 10;
            this.btn_AddCover.Text = "Add Cover";
            this.btn_AddCover.UseVisualStyleBackColor = false;
            this.btn_AddCover.Click += new System.EventHandler(this.btn_AddCover_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(6, 326);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(308, 33);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter_1);
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnShuffle.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.ForeColor = System.Drawing.Color.Black;
            this.btnShuffle.Location = new System.Drawing.Point(311, 502);
            this.btnShuffle.Margin = new System.Windows.Forms.Padding(4);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(125, 35);
            this.btnShuffle.TabIndex = 13;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNext.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(166, 502);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(125, 35);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPrevious.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.Black;
            this.btnPrevious.Location = new System.Drawing.Point(25, 502);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(125, 35);
            this.btnPrevious.TabIndex = 15;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPlaylist);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(462, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 454);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Playlist";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.axWindowsMediaPlayer1);
            this.groupBox2.Controls.Add(this.pb_PlaylistCover);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 459);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cover";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(716, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Video Player";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1147, 663);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btn_AddCover);
            this.Controls.Add(this.btn_loadPL);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_clearPL);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pb_PlaylistCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPlaylist;
        private System.Windows.Forms.Button btn_clearPL;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_loadPL;
        private System.Windows.Forms.PictureBox pb_PlaylistCover;
        private System.Windows.Forms.Button btn_AddCover;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}

