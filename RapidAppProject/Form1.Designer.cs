
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addPL = new System.Windows.Forms.Button();
            this.btn_clearPL = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_loadPL = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.pb_PlaylistCover = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PlaylistCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(430, 8);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(348, 381);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btn_addPL
            // 
            this.btn_addPL.Location = new System.Drawing.Point(548, 395);
            this.btn_addPL.Name = "btn_addPL";
            this.btn_addPL.Size = new System.Drawing.Size(112, 24);
            this.btn_addPL.TabIndex = 2;
            this.btn_addPL.Text = "Add to Playlist";
            this.btn_addPL.UseVisualStyleBackColor = true;
            this.btn_addPL.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_clearPL
            // 
            this.btn_clearPL.Location = new System.Drawing.Point(430, 395);
            this.btn_clearPL.Name = "btn_clearPL";
            this.btn_clearPL.Size = new System.Drawing.Size(112, 24);
            this.btn_clearPL.TabIndex = 3;
            this.btn_clearPL.Text = "Clear Playlist";
            this.btn_clearPL.UseVisualStyleBackColor = true;
            this.btn_clearPL.Click += new System.EventHandler(this.btn_clearPL_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(666, 395);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(112, 24);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save Locally";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_loadPL
            // 
            this.btn_loadPL.Location = new System.Drawing.Point(666, 425);
            this.btn_loadPL.Name = "btn_loadPL";
            this.btn_loadPL.Size = new System.Drawing.Size(112, 24);
            this.btn_loadPL.TabIndex = 5;
            this.btn_loadPL.Text = "Load Playlist";
            this.btn_loadPL.UseVisualStyleBackColor = true;
            this.btn_loadPL.Click += new System.EventHandler(this.btn_loadPL_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(28, 396);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(75, 23);
            this.btn_Play.TabIndex = 6;
            this.btn_Play.Text = " ";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.Location = new System.Drawing.Point(109, 396);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(75, 23);
            this.btn_Pause.TabIndex = 7;
            this.btn_Pause.Text = "Pause";
            this.btn_Pause.UseVisualStyleBackColor = true;
            // 
            // pb_PlaylistCover
            // 
            this.pb_PlaylistCover.Location = new System.Drawing.Point(87, 48);
            this.pb_PlaylistCover.Name = "pb_PlaylistCover";
            this.pb_PlaylistCover.Size = new System.Drawing.Size(196, 178);
            this.pb_PlaylistCover.TabIndex = 8;
            this.pb_PlaylistCover.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(28, 342);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(308, 33);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pb_PlaylistCover);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.btn_loadPL);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_clearPL);
            this.Controls.Add(this.btn_addPL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pb_PlaylistCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addPL;
        private System.Windows.Forms.Button btn_clearPL;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_loadPL;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.PictureBox pb_PlaylistCover;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

