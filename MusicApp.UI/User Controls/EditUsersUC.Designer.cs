
namespace MusicApp.UI.User_Controls
{
    partial class EditUsersUC
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
            this.panelEditArtist = new System.Windows.Forms.Panel();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbUsersManagement = new System.Windows.Forms.Label();
            this.lblSearchSong = new System.Windows.Forms.Label();
            this.txtSearchInsert = new System.Windows.Forms.TextBox();
            this.comboxSearchBy = new System.Windows.Forms.ComboBox();
            this.panelEditArtist.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(923, 560);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 34);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.Location = new System.Drawing.Point(1097, 44);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(144, 61);
            this.btnHome.TabIndex = 31;
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(382, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(653, 531);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // panelEditArtist
            // 
            this.panelEditArtist.Controls.Add(this.lblLastName);
            this.panelEditArtist.Controls.Add(this.txtLastName);
            this.panelEditArtist.Controls.Add(this.lblFirstName);
            this.panelEditArtist.Controls.Add(this.txtFirstName);
            this.panelEditArtist.Location = new System.Drawing.Point(42, 233);
            this.panelEditArtist.Name = "panelEditArtist";
            this.panelEditArtist.Size = new System.Drawing.Size(255, 270);
            this.panelEditArtist.TabIndex = 23;
            this.panelEditArtist.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(3, 67);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(75, 19);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(93, 63);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(132, 23);
            this.txtLastName.TabIndex = 11;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(2, 16);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(77, 19);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(93, 16);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(132, 23);
            this.txtFirstName.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(218, 183);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbUsersManagement
            // 
            this.lbUsersManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUsersManagement.AutoSize = true;
            this.lbUsersManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbUsersManagement.Location = new System.Drawing.Point(42, 68);
            this.lbUsersManagement.Name = "lbUsersManagement";
            this.lbUsersManagement.Size = new System.Drawing.Size(254, 37);
            this.lbUsersManagement.TabIndex = 27;
            this.lbUsersManagement.Text = "Users Management";
            // 
            // lblSearchSong
            // 
            this.lblSearchSong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchSong.AutoSize = true;
            this.lblSearchSong.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearchSong.Location = new System.Drawing.Point(42, 147);
            this.lblSearchSong.Name = "lblSearchSong";
            this.lblSearchSong.Size = new System.Drawing.Size(115, 20);
            this.lblSearchSong.TabIndex = 24;
            this.lblSearchSong.Text = "Search User By:";
            // 
            // txtSearchInsert
            // 
            this.txtSearchInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchInsert.Location = new System.Drawing.Point(42, 183);
            this.txtSearchInsert.Name = "txtSearchInsert";
            this.txtSearchInsert.Size = new System.Drawing.Size(170, 23);
            this.txtSearchInsert.TabIndex = 25;
            // 
            // comboxSearchBy
            // 
            this.comboxSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboxSearchBy.FormattingEnabled = true;
            this.comboxSearchBy.Location = new System.Drawing.Point(176, 144);
            this.comboxSearchBy.Name = "comboxSearchBy";
            this.comboxSearchBy.Size = new System.Drawing.Size(121, 23);
            this.comboxSearchBy.TabIndex = 26;
            // 
            // EditUsersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelEditArtist);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbUsersManagement);
            this.Controls.Add(this.lblSearchSong);
            this.Controls.Add(this.txtSearchInsert);
            this.Controls.Add(this.comboxSearchBy);
            this.Name = "EditUsersUC";
            this.Size = new System.Drawing.Size(1307, 617);
            this.Load += new System.EventHandler(this.EditUsersUC_Load);
            this.panelEditArtist.ResumeLayout(false);
            this.panelEditArtist.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelEditArtist;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbUsersManagement;
        private System.Windows.Forms.Label lblSearchSong;
        private System.Windows.Forms.TextBox txtSearchInsert;
        private System.Windows.Forms.ComboBox comboxSearchBy;
    }
}
