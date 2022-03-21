
namespace MusicApp.UI
{
    partial class EditArtistsUC
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
            this.lblSearchArtist = new System.Windows.Forms.Label();
            this.txtSearchInsert = new System.Windows.Forms.TextBox();
            this.comboxSearchBy = new System.Windows.Forms.ComboBox();
            this.lblArtistManager = new System.Windows.Forms.Label();
            this.btnAddANewArtist = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.panelEditArtist = new System.Windows.Forms.Panel();
            this.btnAddNewSong = new System.Windows.Forms.Button();
            this.btnAddNewAlbum = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblStageName = new System.Windows.Forms.Label();
            this.txtStageName = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelEditArtist.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearchArtist
            // 
            this.lblSearchArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchArtist.AutoSize = true;
            this.lblSearchArtist.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearchArtist.Location = new System.Drawing.Point(57, 127);
            this.lblSearchArtist.Name = "lblSearchArtist";
            this.lblSearchArtist.Size = new System.Drawing.Size(120, 20);
            this.lblSearchArtist.TabIndex = 1;
            this.lblSearchArtist.Text = "Search Artist By:";
            this.lblSearchArtist.Click += new System.EventHandler(this.lblSearchArtist_Click);
            // 
            // txtSearchInsert
            // 
            this.txtSearchInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchInsert.Location = new System.Drawing.Point(57, 164);
            this.txtSearchInsert.Name = "txtSearchInsert";
            this.txtSearchInsert.Size = new System.Drawing.Size(170, 23);
            this.txtSearchInsert.TabIndex = 2;
            this.txtSearchInsert.TextChanged += new System.EventHandler(this.txtSearchInsert_TextChanged);
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
            this.comboxSearchBy.TabIndex = 3;
            this.comboxSearchBy.SelectedIndexChanged += new System.EventHandler(this.comboxSearchBy_SelectedIndexChanged);
            // 
            // lblArtistManager
            // 
            this.lblArtistManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArtistManager.AutoSize = true;
            this.lblArtistManager.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblArtistManager.Location = new System.Drawing.Point(55, 48);
            this.lblArtistManager.Name = "lblArtistManager";
            this.lblArtistManager.Size = new System.Drawing.Size(201, 37);
            this.lblArtistManager.TabIndex = 5;
            this.lblArtistManager.Text = "Artist Manager";
            // 
            // btnAddANewArtist
            // 
            this.btnAddANewArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddANewArtist.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddANewArtist.Location = new System.Drawing.Point(1063, 504);
            this.btnAddANewArtist.Name = "btnAddANewArtist";
            this.btnAddANewArtist.Size = new System.Drawing.Size(197, 70);
            this.btnAddANewArtist.TabIndex = 6;
            this.btnAddANewArtist.Text = "Add A New Artist";
            this.btnAddANewArtist.UseVisualStyleBackColor = true;
            this.btnAddANewArtist.Click += new System.EventHandler(this.btnAddANewArtist_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(233, 163);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(378, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(653, 531);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.Forward);
            this.panel1.Controls.Add(this.panelEditArtist);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 617);
            this.panel1.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(189, 519);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 44);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Forward
            // 
            this.Forward.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Forward.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Forward.Location = new System.Drawing.Point(54, 519);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(113, 44);
            this.Forward.TabIndex = 11;
            this.Forward.Text = "Edit Artist";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Visible = false;
            this.Forward.Click += new System.EventHandler(this.btnEditArtist_Click);
            // 
            // panelEditArtist
            // 
            this.panelEditArtist.Controls.Add(this.btnAddNewSong);
            this.panelEditArtist.Controls.Add(this.btnAddNewAlbum);
            this.panelEditArtist.Controls.Add(this.lblLastName);
            this.panelEditArtist.Controls.Add(this.txtLastName);
            this.panelEditArtist.Controls.Add(this.lblFirstName);
            this.panelEditArtist.Controls.Add(this.txtFirstName);
            this.panelEditArtist.Controls.Add(this.lblStageName);
            this.panelEditArtist.Controls.Add(this.txtStageName);
            this.panelEditArtist.Location = new System.Drawing.Point(55, 213);
            this.panelEditArtist.Name = "panelEditArtist";
            this.panelEditArtist.Size = new System.Drawing.Size(255, 270);
            this.panelEditArtist.TabIndex = 0;
            this.panelEditArtist.Visible = false;
            // 
            // btnAddNewSong
            // 
            this.btnAddNewSong.Location = new System.Drawing.Point(132, 224);
            this.btnAddNewSong.Name = "btnAddNewSong";
            this.btnAddNewSong.Size = new System.Drawing.Size(109, 28);
            this.btnAddNewSong.TabIndex = 16;
            this.btnAddNewSong.Text = "Add New Song";
            this.btnAddNewSong.UseVisualStyleBackColor = true;
            this.btnAddNewSong.Click += new System.EventHandler(this.btnAddNewSong_Click);
            // 
            // btnAddNewAlbum
            // 
            this.btnAddNewAlbum.Location = new System.Drawing.Point(3, 224);
            this.btnAddNewAlbum.Name = "btnAddNewAlbum";
            this.btnAddNewAlbum.Size = new System.Drawing.Size(109, 28);
            this.btnAddNewAlbum.TabIndex = 15;
            this.btnAddNewAlbum.Text = "Add New Album";
            this.btnAddNewAlbum.UseVisualStyleBackColor = true;
            this.btnAddNewAlbum.Click += new System.EventHandler(this.btnAddNewAlbum_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(2, 119);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(75, 19);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(93, 119);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(132, 23);
            this.txtLastName.TabIndex = 13;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(2, 66);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(77, 19);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(93, 63);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(132, 23);
            this.txtFirstName.TabIndex = 11;
            // 
            // lblStageName
            // 
            this.lblStageName.AutoSize = true;
            this.lblStageName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStageName.Location = new System.Drawing.Point(2, 16);
            this.lblStageName.Name = "lblStageName";
            this.lblStageName.Size = new System.Drawing.Size(85, 19);
            this.lblStageName.TabIndex = 10;
            this.lblStageName.Text = "Stage Name";
            // 
            // txtStageName
            // 
            this.txtStageName.Location = new System.Drawing.Point(93, 16);
            this.txtStageName.Name = "txtStageName";
            this.txtStageName.ReadOnly = true;
            this.txtStageName.Size = new System.Drawing.Size(132, 23);
            this.txtStageName.TabIndex = 9;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.Location = new System.Drawing.Point(1094, 43);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(137, 61);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(919, 540);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 34);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // EditArtistsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddANewArtist);
            this.Controls.Add(this.lblArtistManager);
            this.Controls.Add(this.comboxSearchBy);
            this.Controls.Add(this.txtSearchInsert);
            this.Controls.Add(this.lblSearchArtist);
            this.Controls.Add(this.panel1);
            this.Name = "EditArtistsUC";
            this.Size = new System.Drawing.Size(1307, 617);
            this.Load += new System.EventHandler(this.EditArtistsUC_Load);
            this.panel1.ResumeLayout(false);
            this.panelEditArtist.ResumeLayout(false);
            this.panelEditArtist.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchArtist;
        private System.Windows.Forms.TextBox txtSearchInsert;
        private System.Windows.Forms.ComboBox comboxSearchBy;
        private System.Windows.Forms.Label lblArtistManager;
        private System.Windows.Forms.Button btnAddANewArtist;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelEditArtist;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Button btnAddNewSong;
        private System.Windows.Forms.Button btnAddNewAlbum;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblStageName;
        private System.Windows.Forms.TextBox txtStageName;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBack;
    }
}
