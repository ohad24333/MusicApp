
namespace MusicApp.UI.User_Controls
{
    partial class EditSongUC
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddANewSong = new System.Windows.Forms.Button();
            this.lbSongManagement = new System.Windows.Forms.Label();
            this.comboxSearchBy = new System.Windows.Forms.ComboBox();
            this.txtSearchInsert = new System.Windows.Forms.TextBox();
            this.lblSearchSong = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelEditArtist = new System.Windows.Forms.Panel();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.lblSongName = new System.Windows.Forms.Label();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelEditArtist.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(936, 540);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 34);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.Location = new System.Drawing.Point(1110, 24);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(144, 61);
            this.btnHome.TabIndex = 21;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(395, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(653, 531);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(231, 163);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddANewSong
            // 
            this.btnAddANewSong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddANewSong.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddANewSong.Location = new System.Drawing.Point(1080, 504);
            this.btnAddANewSong.Name = "btnAddANewSong";
            this.btnAddANewSong.Size = new System.Drawing.Size(197, 70);
            this.btnAddANewSong.TabIndex = 17;
            this.btnAddANewSong.Text = "Add A New Song";
            this.btnAddANewSong.UseVisualStyleBackColor = true;
            this.btnAddANewSong.Click += new System.EventHandler(this.btnAddANewSong_Click);
            // 
            // lbSongManagement
            // 
            this.lbSongManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSongManagement.AutoSize = true;
            this.lbSongManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbSongManagement.Location = new System.Drawing.Point(55, 48);
            this.lbSongManagement.Name = "lbSongManagement";
            this.lbSongManagement.Size = new System.Drawing.Size(250, 37);
            this.lbSongManagement.TabIndex = 16;
            this.lbSongManagement.Text = "Song Management";
            // 
            // comboxSearchBy
            // 
            this.comboxSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboxSearchBy.FormattingEnabled = true;
            this.comboxSearchBy.Location = new System.Drawing.Point(189, 124);
            this.comboxSearchBy.Name = "comboxSearchBy";
            this.comboxSearchBy.Size = new System.Drawing.Size(121, 23);
            this.comboxSearchBy.TabIndex = 15;
            // 
            // txtSearchInsert
            // 
            this.txtSearchInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchInsert.Location = new System.Drawing.Point(55, 163);
            this.txtSearchInsert.Name = "txtSearchInsert";
            this.txtSearchInsert.Size = new System.Drawing.Size(170, 23);
            this.txtSearchInsert.TabIndex = 14;
            // 
            // lblSearchSong
            // 
            this.lblSearchSong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchSong.AutoSize = true;
            this.lblSearchSong.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearchSong.Location = new System.Drawing.Point(55, 127);
            this.lblSearchSong.Name = "lblSearchSong";
            this.lblSearchSong.Size = new System.Drawing.Size(119, 20);
            this.lblSearchSong.TabIndex = 13;
            this.lblSearchSong.Text = "Search Song By:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelEditArtist);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lbSongManagement);
            this.panel1.Controls.Add(this.lblSearchSong);
            this.panel1.Controls.Add(this.txtSearchInsert);
            this.panel1.Controls.Add(this.comboxSearchBy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 617);
            this.panel1.TabIndex = 20;
            // 
            // panelEditArtist
            // 
            this.panelEditArtist.Controls.Add(this.lblAlbum);
            this.panelEditArtist.Controls.Add(this.txtArtist);
            this.panelEditArtist.Controls.Add(this.lblArtist);
            this.panelEditArtist.Controls.Add(this.txtAlbum);
            this.panelEditArtist.Controls.Add(this.lblSongName);
            this.panelEditArtist.Controls.Add(this.txtSongName);
            this.panelEditArtist.Location = new System.Drawing.Point(55, 213);
            this.panelEditArtist.Name = "panelEditArtist";
            this.panelEditArtist.Size = new System.Drawing.Size(255, 270);
            this.panelEditArtist.TabIndex = 0;
            this.panelEditArtist.Visible = false;
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlbum.Location = new System.Drawing.Point(3, 67);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(50, 19);
            this.lblAlbum.TabIndex = 14;
            this.lblAlbum.Text = "Album";
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(93, 119);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.ReadOnly = true;
            this.txtArtist.Size = new System.Drawing.Size(132, 23);
            this.txtArtist.TabIndex = 13;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArtist.Location = new System.Drawing.Point(3, 123);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(43, 19);
            this.lblArtist.TabIndex = 12;
            this.lblArtist.Text = "Artist";
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(93, 63);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.ReadOnly = true;
            this.txtAlbum.Size = new System.Drawing.Size(132, 23);
            this.txtAlbum.TabIndex = 11;
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSongName.Location = new System.Drawing.Point(2, 16);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(82, 19);
            this.lblSongName.TabIndex = 10;
            this.lblSongName.Text = "Song Name";
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(93, 16);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.ReadOnly = true;
            this.txtSongName.Size = new System.Drawing.Size(132, 23);
            this.txtSongName.TabIndex = 9;
            // 
            // EditSongUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnAddANewSong);
            this.Controls.Add(this.panel1);
            this.Name = "EditSongUC";
            this.Size = new System.Drawing.Size(1307, 617);
            this.Load += new System.EventHandler(this.EditSongUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEditArtist.ResumeLayout(false);
            this.panelEditArtist.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddANewSong;
        private System.Windows.Forms.Label lbSongManagement;
        private System.Windows.Forms.ComboBox comboxSearchBy;
        private System.Windows.Forms.TextBox txtSearchInsert;
        private System.Windows.Forms.Label lblSearchSong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelEditArtist;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.TextBox txtSongName;
    }
}
