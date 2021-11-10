
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addPL = new System.Windows.Forms.Button();
            this.btn_clearPL = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_loadPL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(430, 8);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(348, 381);
            this.listBox1.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

