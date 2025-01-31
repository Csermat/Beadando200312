﻿namespace Beadandó200212
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
            this.btnAddDisco = new System.Windows.Forms.Button();
            this.btnAddURL = new System.Windows.Forms.Button();
            this.btnEditSelect = new System.Windows.Forms.Button();
            this.cbArtist = new System.Windows.Forms.ComboBox();
            this.cbAlbum = new System.Windows.Forms.ComboBox();
            this.pbAlbum = new System.Windows.Forms.PictureBox();
            this.rtbAlbum = new System.Windows.Forms.RichTextBox();
            this.dgvTrack = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbURL = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddDisco
            // 
            this.btnAddDisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAddDisco.Location = new System.Drawing.Point(374, 467);
            this.btnAddDisco.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDisco.Name = "btnAddDisco";
            this.btnAddDisco.Size = new System.Drawing.Size(197, 56);
            this.btnAddDisco.TabIndex = 0;
            this.btnAddDisco.Text = "Add discography";
            this.btnAddDisco.UseVisualStyleBackColor = true;
            this.btnAddDisco.Click += new System.EventHandler(this.btnAddDisco_Click);
            // 
            // btnAddURL
            // 
            this.btnAddURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAddURL.Location = new System.Drawing.Point(575, 467);
            this.btnAddURL.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddURL.Name = "btnAddURL";
            this.btnAddURL.Size = new System.Drawing.Size(141, 56);
            this.btnAddURL.TabIndex = 1;
            this.btnAddURL.Text = "Add URL";
            this.btnAddURL.UseVisualStyleBackColor = true;
            this.btnAddURL.Click += new System.EventHandler(this.btnAddURL_Click);
            // 
            // btnEditSelect
            // 
            this.btnEditSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnEditSelect.Location = new System.Drawing.Point(720, 467);
            this.btnEditSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditSelect.Name = "btnEditSelect";
            this.btnEditSelect.Size = new System.Drawing.Size(173, 56);
            this.btnEditSelect.TabIndex = 2;
            this.btnEditSelect.Text = "Edit Selected";
            this.btnEditSelect.UseVisualStyleBackColor = true;
            this.btnEditSelect.Click += new System.EventHandler(this.btnEditSelect_Click);
            // 
            // cbArtist
            // 
            this.cbArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbArtist.FormattingEnabled = true;
            this.cbArtist.Location = new System.Drawing.Point(9, 64);
            this.cbArtist.Margin = new System.Windows.Forms.Padding(2);
            this.cbArtist.Name = "cbArtist";
            this.cbArtist.Size = new System.Drawing.Size(163, 32);
            this.cbArtist.TabIndex = 3;
            // 
            // cbAlbum
            // 
            this.cbAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbAlbum.FormattingEnabled = true;
            this.cbAlbum.Location = new System.Drawing.Point(182, 64);
            this.cbAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.cbAlbum.Name = "cbAlbum";
            this.cbAlbum.Size = new System.Drawing.Size(171, 32);
            this.cbAlbum.TabIndex = 4;
            // 
            // pbAlbum
            // 
            this.pbAlbum.Location = new System.Drawing.Point(370, 208);
            this.pbAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.pbAlbum.Name = "pbAlbum";
            this.pbAlbum.Size = new System.Drawing.Size(155, 155);
            this.pbAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlbum.TabIndex = 5;
            this.pbAlbum.TabStop = false;
            // 
            // rtbAlbum
            // 
            this.rtbAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rtbAlbum.Location = new System.Drawing.Point(529, 208);
            this.rtbAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.rtbAlbum.Name = "rtbAlbum";
            this.rtbAlbum.Size = new System.Drawing.Size(364, 155);
            this.rtbAlbum.TabIndex = 6;
            this.rtbAlbum.Text = "";
            // 
            // dgvTrack
            // 
            this.dgvTrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrack.Location = new System.Drawing.Point(9, 208);
            this.dgvTrack.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTrack.Name = "dgvTrack";
            this.dgvTrack.RowTemplate.Height = 24;
            this.dgvTrack.Size = new System.Drawing.Size(344, 315);
            this.dgvTrack.TabIndex = 7;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbSearch.Location = new System.Drawing.Point(9, 162);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(344, 29);
            this.tbSearch.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(178, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Album";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(5, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search in track\'s title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(394, 410);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "URL (if any) :";
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbURL.Location = new System.Drawing.Point(510, 410);
            this.lbURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(85, 24);
            this.lbURL.TabIndex = 13;
            this.lbURL.TabStop = true;
            this.lbURL.Text = "<Empty>";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.Red;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnTest.Location = new System.Drawing.Point(854, 11);
            this.btnTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(39, 40);
            this.btnTest.TabIndex = 14;
            this.btnTest.Text = "T";
            this.btnTest.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 546);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lbURL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvTrack);
            this.Controls.Add(this.rtbAlbum);
            this.Controls.Add(this.pbAlbum);
            this.Controls.Add(this.cbAlbum);
            this.Controls.Add(this.cbArtist);
            this.Controls.Add(this.btnEditSelect);
            this.Controls.Add(this.btnAddURL);
            this.Controls.Add(this.btnAddDisco);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDisco;
        private System.Windows.Forms.Button btnAddURL;
        private System.Windows.Forms.Button btnEditSelect;
        private System.Windows.Forms.ComboBox cbArtist;
        private System.Windows.Forms.ComboBox cbAlbum;
        private System.Windows.Forms.PictureBox pbAlbum;
        private System.Windows.Forms.RichTextBox rtbAlbum;
        private System.Windows.Forms.DataGridView dgvTrack;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lbURL;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnTest;
    }
}

