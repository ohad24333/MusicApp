
namespace MusicApp.UI.User_Controls
{
    partial class AddNewSongUC
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpDatePublished = new System.Windows.Forms.DateTimePicker();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.lblDatePublished = new System.Windows.Forms.Label();
            this.lblAlbumName = new System.Windows.Forms.Label();
            this.lblAddNewSong = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.dtpDuration = new System.Windows.Forms.DateTimePicker();
            this.lblGenre = new System.Windows.Forms.Label();
            this.comboxGenre = new System.Windows.Forms.ComboBox();
            this.comboxPublisher = new System.Windows.Forms.ComboBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.comboxAlbum = new System.Windows.Forms.ComboBox();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(453, 449);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 59);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpDatePublished
            // 
            this.dtpDatePublished.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDatePublished.Location = new System.Drawing.Point(233, 206);
            this.dtpDatePublished.Name = "dtpDatePublished";
            this.dtpDatePublished.Size = new System.Drawing.Size(200, 25);
            this.dtpDatePublished.TabIndex = 10;
            // 
            // txtSongName
            // 
            this.txtSongName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSongName.Location = new System.Drawing.Point(233, 154);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(200, 27);
            this.txtSongName.TabIndex = 9;
            // 
            // lblDatePublished
            // 
            this.lblDatePublished.AutoSize = true;
            this.lblDatePublished.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblDatePublished.Location = new System.Drawing.Point(54, 203);
            this.lblDatePublished.Name = "lblDatePublished";
            this.lblDatePublished.Size = new System.Drawing.Size(155, 28);
            this.lblDatePublished.TabIndex = 8;
            this.lblDatePublished.Text = "Date Published:";
            // 
            // lblAlbumName
            // 
            this.lblAlbumName.AutoSize = true;
            this.lblAlbumName.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblAlbumName.Location = new System.Drawing.Point(54, 154);
            this.lblAlbumName.Name = "lblAlbumName";
            this.lblAlbumName.Size = new System.Drawing.Size(124, 28);
            this.lblAlbumName.TabIndex = 7;
            this.lblAlbumName.Text = "Song Name:";
            // 
            // lblAddNewSong
            // 
            this.lblAddNewSong.AutoSize = true;
            this.lblAddNewSong.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddNewSong.Location = new System.Drawing.Point(54, 43);
            this.lblAddNewSong.Name = "lblAddNewSong";
            this.lblAddNewSong.Size = new System.Drawing.Size(326, 51);
            this.lblAddNewSong.TabIndex = 6;
            this.lblAddNewSong.Text = "Add A New Song:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblDuration.Location = new System.Drawing.Point(54, 249);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(96, 28);
            this.lblDuration.TabIndex = 12;
            this.lblDuration.Text = "Duration:";
            // 
            // dtpDuration
            // 
            this.dtpDuration.CustomFormat = "mm:ss";
            this.dtpDuration.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDuration.Location = new System.Drawing.Point(233, 254);
            this.dtpDuration.Name = "dtpDuration";
            this.dtpDuration.Size = new System.Drawing.Size(67, 23);
            this.dtpDuration.TabIndex = 13;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblGenre.Location = new System.Drawing.Point(54, 293);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(72, 28);
            this.lblGenre.TabIndex = 14;
            this.lblGenre.Text = "Genre:";
            // 
            // comboxGenre
            // 
            this.comboxGenre.FormattingEnabled = true;
            this.comboxGenre.Location = new System.Drawing.Point(233, 298);
            this.comboxGenre.Name = "comboxGenre";
            this.comboxGenre.Size = new System.Drawing.Size(200, 23);
            this.comboxGenre.TabIndex = 15;
            // 
            // comboxPublisher
            // 
            this.comboxPublisher.FormattingEnabled = true;
            this.comboxPublisher.Location = new System.Drawing.Point(233, 339);
            this.comboxPublisher.Name = "comboxPublisher";
            this.comboxPublisher.Size = new System.Drawing.Size(200, 23);
            this.comboxPublisher.TabIndex = 17;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblPublisher.Location = new System.Drawing.Point(54, 334);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(103, 28);
            this.lblPublisher.TabIndex = 16;
            this.lblPublisher.Text = "Publisher:";
            // 
            // comboxAlbum
            // 
            this.comboxAlbum.FormattingEnabled = true;
            this.comboxAlbum.Location = new System.Drawing.Point(233, 385);
            this.comboxAlbum.Name = "comboxAlbum";
            this.comboxAlbum.Size = new System.Drawing.Size(200, 23);
            this.comboxAlbum.TabIndex = 19;
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblAlbum.Location = new System.Drawing.Point(54, 380);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(77, 28);
            this.lblAlbum.TabIndex = 18;
            this.lblAlbum.Text = "Album:";
            // 
            // AddNewSongUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboxAlbum);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.comboxPublisher);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.comboxGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.dtpDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpDatePublished);
            this.Controls.Add(this.txtSongName);
            this.Controls.Add(this.lblDatePublished);
            this.Controls.Add(this.lblAlbumName);
            this.Controls.Add(this.lblAddNewSong);
            this.Name = "AddNewSongUC";
            this.Size = new System.Drawing.Size(653, 531);
            this.Load += new System.EventHandler(this.AddNewSongUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpDatePublished;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.Label lblDatePublished;
        private System.Windows.Forms.Label lblAlbumName;
        private System.Windows.Forms.Label lblAddNewSong;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.DateTimePicker dtpDuration;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox comboxGenre;
        private System.Windows.Forms.ComboBox comboxPublisher;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.ComboBox comboxAlbum;
        private System.Windows.Forms.Label lblAlbum;
    }
}
