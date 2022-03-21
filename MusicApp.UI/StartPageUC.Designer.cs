
namespace MusicApp.UI
{
    partial class StartPageUC
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnListeningHistory = new System.Windows.Forms.Button();
            this.txtSearchInsert = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.comboxSearchBy = new System.Windows.Forms.ComboBox();
            this.lblAdminOptions = new System.Windows.Forms.Label();
            this.btnEditSongs = new System.Windows.Forms.Button();
            this.btnEditArtists = new System.Windows.Forms.Button();
            this.btnEditUsers = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.fLPSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSongSaved = new System.Windows.Forms.Button();
            this.lblDisconect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(43, 44);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(92, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(396, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnListeningHistory
            // 
            this.btnListeningHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListeningHistory.Location = new System.Drawing.Point(505, 44);
            this.btnListeningHistory.Name = "btnListeningHistory";
            this.btnListeningHistory.Size = new System.Drawing.Size(121, 35);
            this.btnListeningHistory.TabIndex = 4;
            this.btnListeningHistory.Text = "Listening History";
            this.btnListeningHistory.UseVisualStyleBackColor = true;
            this.btnListeningHistory.Click += new System.EventHandler(this.btnListeningHistory_Click);
            // 
            // txtSearchInsert
            // 
            this.txtSearchInsert.Location = new System.Drawing.Point(158, 94);
            this.txtSearchInsert.Name = "txtSearchInsert";
            this.txtSearchInsert.Size = new System.Drawing.Size(220, 23);
            this.txtSearchInsert.TabIndex = 5;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(43, 97);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(103, 15);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search For A Song";
            // 
            // comboxSearchBy
            // 
            this.comboxSearchBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboxSearchBy.FormattingEnabled = true;
            this.comboxSearchBy.Location = new System.Drawing.Point(505, 97);
            this.comboxSearchBy.Name = "comboxSearchBy";
            this.comboxSearchBy.Size = new System.Drawing.Size(121, 23);
            this.comboxSearchBy.TabIndex = 7;
            // 
            // lblAdminOptions
            // 
            this.lblAdminOptions.AutoSize = true;
            this.lblAdminOptions.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblAdminOptions.Location = new System.Drawing.Point(924, 97);
            this.lblAdminOptions.Name = "lblAdminOptions";
            this.lblAdminOptions.Size = new System.Drawing.Size(158, 30);
            this.lblAdminOptions.TabIndex = 9;
            this.lblAdminOptions.Text = "Admin Options";
            // 
            // btnEditSongs
            // 
            this.btnEditSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSongs.Location = new System.Drawing.Point(776, 149);
            this.btnEditSongs.Name = "btnEditSongs";
            this.btnEditSongs.Size = new System.Drawing.Size(138, 35);
            this.btnEditSongs.TabIndex = 10;
            this.btnEditSongs.Text = "Edit Songs";
            this.btnEditSongs.UseVisualStyleBackColor = false;
            this.btnEditSongs.Click += new System.EventHandler(this.btnEditSongs_Click);
            // 
            // btnEditArtists
            // 
            this.btnEditArtists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditArtists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditArtists.Location = new System.Drawing.Point(944, 149);
            this.btnEditArtists.Name = "btnEditArtists";
            this.btnEditArtists.Size = new System.Drawing.Size(138, 35);
            this.btnEditArtists.TabIndex = 11;
            this.btnEditArtists.Text = "Edit Artists";
            this.btnEditArtists.UseVisualStyleBackColor = false;
            this.btnEditArtists.Click += new System.EventHandler(this.btnEditArtists_Click);
            // 
            // btnEditUsers
            // 
            this.btnEditUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditUsers.Location = new System.Drawing.Point(1118, 149);
            this.btnEditUsers.Name = "btnEditUsers";
            this.btnEditUsers.Size = new System.Drawing.Size(138, 35);
            this.btnEditUsers.TabIndex = 12;
            this.btnEditUsers.Text = "Edit Users";
            this.btnEditUsers.UseVisualStyleBackColor = false;
            this.btnEditUsers.Click += new System.EventHandler(this.btnEditUsers_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(43, 149);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(583, 394);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // fLPSongs
            // 
            this.fLPSongs.Location = new System.Drawing.Point(776, 239);
            this.fLPSongs.Name = "fLPSongs";
            this.fLPSongs.Size = new System.Drawing.Size(480, 304);
            this.fLPSongs.TabIndex = 14;
            // 
            // btnSongSaved
            // 
            this.btnSongSaved.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSongSaved.Location = new System.Drawing.Point(368, 44);
            this.btnSongSaved.Name = "btnSongSaved";
            this.btnSongSaved.Size = new System.Drawing.Size(121, 35);
            this.btnSongSaved.TabIndex = 15;
            this.btnSongSaved.Text = "Song Saved";
            this.btnSongSaved.UseVisualStyleBackColor = true;
            this.btnSongSaved.Click += new System.EventHandler(this.btnSongSaved_Click);
            // 
            // lblDisconect
            // 
            this.lblDisconect.AutoSize = true;
            this.lblDisconect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDisconect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblDisconect.ForeColor = System.Drawing.Color.Blue;
            this.lblDisconect.Location = new System.Drawing.Point(30, 18);
            this.lblDisconect.Name = "lblDisconect";
            this.lblDisconect.Size = new System.Drawing.Size(66, 15);
            this.lblDisconect.TabIndex = 16;
            this.lblDisconect.Text = "Disconnect";
            this.lblDisconect.Click += new System.EventHandler(this.lblDisconect_Click);
            // 
            // StartPageUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDisconect);
            this.Controls.Add(this.btnSongSaved);
            this.Controls.Add(this.fLPSongs);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnEditUsers);
            this.Controls.Add(this.btnEditArtists);
            this.Controls.Add(this.btnEditSongs);
            this.Controls.Add(this.lblAdminOptions);
            this.Controls.Add(this.comboxSearchBy);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearchInsert);
            this.Controls.Add(this.btnListeningHistory);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblWelcome);
            this.Name = "StartPageUC";
            this.Size = new System.Drawing.Size(1307, 616);
            this.Load += new System.EventHandler(this.StartPageUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnListeningHistory;
        private System.Windows.Forms.TextBox txtSearchInsert;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox comboxSearchBy;
        private System.Windows.Forms.Label lblAdminOptions;
        private System.Windows.Forms.Button btnEditSongs;
        private System.Windows.Forms.Button btnEditArtists;
        private System.Windows.Forms.Button btnEditUsers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel fLPSongs;
        private System.Windows.Forms.Button btnSongSaved;
        private System.Windows.Forms.Label lblDisconect;
    }
}
