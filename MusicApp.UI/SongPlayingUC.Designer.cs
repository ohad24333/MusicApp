
namespace MusicApp.UI
{
    partial class SongPlayingUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblText = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddToPlayList = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblWatched = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblWatchedCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.Location = new System.Drawing.Point(151, 63);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(312, 46);
            this.lblText.TabIndex = 6;
            this.lblText.Text = "Some Text Here";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(151, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(312, 27);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Title";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 120);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(0, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(648, 1);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 1);
            this.panel2.TabIndex = 4;
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Location = new System.Drawing.Point(181, 253);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(75, 33);
            this.btnPlayPause.TabIndex = 8;
            this.btnPlayPause.Text = "Pause";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(100, 253);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 33);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(19, 253);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 33);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back Song";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(262, 253);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 33);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddToPlayList
            // 
            this.btnAddToPlayList.Location = new System.Drawing.Point(388, 224);
            this.btnAddToPlayList.Name = "btnAddToPlayList";
            this.btnAddToPlayList.Size = new System.Drawing.Size(75, 62);
            this.btnAddToPlayList.TabIndex = 12;
            this.btnAddToPlayList.Text = "+ Add To Play List";
            this.btnAddToPlayList.UseVisualStyleBackColor = true;
            this.btnAddToPlayList.Click += new System.EventHandler(this.btnAddToPlayList_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(19, 208);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(318, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(72, 177);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(13, 15);
            this.lblTimer.TabIndex = 14;
            this.lblTimer.Text = "0";
            // 
            // lblWatched
            // 
            this.lblWatched.AutoSize = true;
            this.lblWatched.Location = new System.Drawing.Point(358, 177);
            this.lblWatched.Name = "lblWatched";
            this.lblWatched.Size = new System.Drawing.Size(60, 15);
            this.lblWatched.TabIndex = 15;
            this.lblWatched.Text = "Watched: ";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(19, 177);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(39, 15);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "Time: ";
            // 
            // lblWatchedCounter
            // 
            this.lblWatchedCounter.AutoSize = true;
            this.lblWatchedCounter.Location = new System.Drawing.Point(424, 177);
            this.lblWatchedCounter.Name = "lblWatchedCounter";
            this.lblWatchedCounter.Size = new System.Drawing.Size(13, 15);
            this.lblWatchedCounter.TabIndex = 17;
            this.lblWatchedCounter.Text = "0";
            // 
            // SongPlayingUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblWatchedCounter);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblWatched);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnAddToPlayList);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "SongPlayingUC";
            this.Size = new System.Drawing.Size(480, 304);
            this.Load += new System.EventHandler(this.SongPlayingUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddToPlayList;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblWatched;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblWatchedCounter;
    }
}
