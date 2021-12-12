﻿
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clearPL = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_loadPL = new System.Windows.Forms.Button();
            this.pb_PlaylistCover = new System.Windows.Forms.PictureBox();
            this.btn_AddCover = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PlaylistCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPlaylist
            // 
            this.lbPlaylist.BackColor = System.Drawing.Color.Plum;
            this.lbPlaylist.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaylist.ForeColor = System.Drawing.Color.Navy;
            this.lbPlaylist.FormattingEnabled = true;
            this.lbPlaylist.ItemHeight = 28;
            this.lbPlaylist.Location = new System.Drawing.Point(467, 46);
            this.lbPlaylist.Margin = new System.Windows.Forms.Padding(4);
            this.lbPlaylist.Name = "lbPlaylist";
            this.lbPlaylist.Size = new System.Drawing.Size(195, 452);
            this.lbPlaylist.TabIndex = 0;
            this.lbPlaylist.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cover";
            // 
            // btn_clearPL
            // 
            this.btn_clearPL.BackColor = System.Drawing.Color.Plum;
            this.btn_clearPL.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearPL.ForeColor = System.Drawing.Color.Navy;
            this.btn_clearPL.Location = new System.Drawing.Point(479, 515);
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
            this.btn_Save.BackColor = System.Drawing.Color.Plum;
            this.btn_Save.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Navy;
            this.btn_Save.Location = new System.Drawing.Point(479, 562);
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
            this.btn_loadPL.BackColor = System.Drawing.Color.Plum;
            this.btn_loadPL.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadPL.ForeColor = System.Drawing.Color.Navy;
            this.btn_loadPL.Location = new System.Drawing.Point(479, 610);
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
            this.pb_PlaylistCover.Location = new System.Drawing.Point(25, 54);
            this.pb_PlaylistCover.Margin = new System.Windows.Forms.Padding(4);
            this.pb_PlaylistCover.Name = "pb_PlaylistCover";
            this.pb_PlaylistCover.Size = new System.Drawing.Size(411, 330);
            this.pb_PlaylistCover.TabIndex = 8;
            this.pb_PlaylistCover.TabStop = false;
            this.pb_PlaylistCover.Click += new System.EventHandler(this.pb_PlaylistCover_Click);
            // 
            // btn_AddCover
            // 
            this.btn_AddCover.BackColor = System.Drawing.Color.Plum;
            this.btn_AddCover.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCover.ForeColor = System.Drawing.Color.Navy;
            this.btn_AddCover.Location = new System.Drawing.Point(35, 502);
            this.btn_AddCover.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddCover.Name = "btn_AddCover";
            this.btn_AddCover.Size = new System.Drawing.Size(160, 35);
            this.btn_AddCover.TabIndex = 10;
            this.btn_AddCover.Text = "Add Cover";
            this.btn_AddCover.UseVisualStyleBackColor = false;
            this.btn_AddCover.Click += new System.EventHandler(this.btn_AddCover_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(24, 351);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(308, 33);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Plum;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(818, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Video Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Plum;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(521, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Playlist";
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.Plum;
            this.btnShuffle.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.ForeColor = System.Drawing.Color.Navy;
            this.btnShuffle.Location = new System.Drawing.Point(258, 502);
            this.btnShuffle.Margin = new System.Windows.Forms.Padding(4);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(160, 35);
            this.btnShuffle.TabIndex = 13;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Plum;
            this.btnNext.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Navy;
            this.btnNext.Location = new System.Drawing.Point(258, 582);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(160, 35);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Plum;
            this.btnPrevious.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.Navy;
            this.btnPrevious.Location = new System.Drawing.Point(35, 582);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(160, 35);
            this.btnPrevious.TabIndex = 15;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1172, 663);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_AddCover);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pb_PlaylistCover);
            this.Controls.Add(this.btn_loadPL);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_clearPL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPlaylist);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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

        private System.Windows.Forms.ListBox lbPlaylist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clearPL;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_loadPL;
        private System.Windows.Forms.PictureBox pb_PlaylistCover;
        private System.Windows.Forms.Button btn_AddCover;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
    }
}

