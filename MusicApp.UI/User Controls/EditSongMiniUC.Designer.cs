
namespace MusicApp.UI.User_Controls
{
    partial class EditSongMiniUC
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
            this.comboxAlbum = new System.Windows.Forms.ComboBox();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.comboxPublisher = new System.Windows.Forms.ComboBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.comboxGenre = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDatePublished = new System.Windows.Forms.DateTimePicker();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.lblDatePublished = new System.Windows.Forms.Label();
            this.lblAlbumName = new System.Windows.Forms.Label();
            this.lblEditSong = new System.Windows.Forms.Label();
            this.dtpDuration = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // comboxAlbum
            // 
            this.comboxAlbum.FormattingEnabled = true;
            this.comboxAlbum.Location = new System.Drawing.Point(218, 380);
            this.comboxAlbum.Name = "comboxAlbum";
            this.comboxAlbum.Size = new System.Drawing.Size(200, 23);
            this.comboxAlbum.TabIndex = 33;
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblAlbum.Location = new System.Drawing.Point(39, 375);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(77, 28);
            this.lblAlbum.TabIndex = 32;
            this.lblAlbum.Text = "Album:";
            // 
            // comboxPublisher
            // 
            this.comboxPublisher.FormattingEnabled = true;
            this.comboxPublisher.Location = new System.Drawing.Point(218, 334);
            this.comboxPublisher.Name = "comboxPublisher";
            this.comboxPublisher.Size = new System.Drawing.Size(200, 23);
            this.comboxPublisher.TabIndex = 31;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblPublisher.Location = new System.Drawing.Point(39, 329);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(103, 28);
            this.lblPublisher.TabIndex = 30;
            this.lblPublisher.Text = "Publisher:";
            // 
            // comboxGenre
            // 
            this.comboxGenre.FormattingEnabled = true;
            this.comboxGenre.Location = new System.Drawing.Point(218, 293);
            this.comboxGenre.Name = "comboxGenre";
            this.comboxGenre.Size = new System.Drawing.Size(200, 23);
            this.comboxGenre.TabIndex = 29;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblGenre.Location = new System.Drawing.Point(39, 288);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(72, 28);
            this.lblGenre.TabIndex = 28;
            this.lblGenre.Text = "Genre:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblDuration.Location = new System.Drawing.Point(39, 244);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(96, 28);
            this.lblDuration.TabIndex = 26;
            this.lblDuration.Text = "Duration:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(438, 444);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 59);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDatePublished
            // 
            this.dtpDatePublished.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDatePublished.Location = new System.Drawing.Point(218, 201);
            this.dtpDatePublished.Name = "dtpDatePublished";
            this.dtpDatePublished.Size = new System.Drawing.Size(200, 25);
            this.dtpDatePublished.TabIndex = 24;
            // 
            // txtSongName
            // 
            this.txtSongName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSongName.Location = new System.Drawing.Point(218, 149);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(200, 27);
            this.txtSongName.TabIndex = 23;
            // 
            // lblDatePublished
            // 
            this.lblDatePublished.AutoSize = true;
            this.lblDatePublished.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblDatePublished.Location = new System.Drawing.Point(39, 198);
            this.lblDatePublished.Name = "lblDatePublished";
            this.lblDatePublished.Size = new System.Drawing.Size(155, 28);
            this.lblDatePublished.TabIndex = 22;
            this.lblDatePublished.Text = "Date Published:";
            // 
            // lblAlbumName
            // 
            this.lblAlbumName.AutoSize = true;
            this.lblAlbumName.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblAlbumName.Location = new System.Drawing.Point(39, 149);
            this.lblAlbumName.Name = "lblAlbumName";
            this.lblAlbumName.Size = new System.Drawing.Size(124, 28);
            this.lblAlbumName.TabIndex = 21;
            this.lblAlbumName.Text = "Song Name:";
            // 
            // lblEditSong
            // 
            this.lblEditSong.AutoSize = true;
            this.lblEditSong.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEditSong.Location = new System.Drawing.Point(39, 38);
            this.lblEditSong.Name = "lblEditSong";
            this.lblEditSong.Size = new System.Drawing.Size(197, 51);
            this.lblEditSong.TabIndex = 20;
            this.lblEditSong.Text = "Edit Song:";
            // 
            // dtpDuration
            // 
            this.dtpDuration.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtpDuration.CustomFormat = "mm:ss";
            this.dtpDuration.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDuration.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDuration.Location = new System.Drawing.Point(218, 244);
            this.dtpDuration.Name = "dtpDuration";
            this.dtpDuration.Size = new System.Drawing.Size(86, 25);
            this.dtpDuration.TabIndex = 36;
            // 
            // EditSongMiniUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpDuration);
            this.Controls.Add(this.comboxAlbum);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.comboxPublisher);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.comboxGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDatePublished);
            this.Controls.Add(this.txtSongName);
            this.Controls.Add(this.lblDatePublished);
            this.Controls.Add(this.lblAlbumName);
            this.Controls.Add(this.lblEditSong);
            this.Name = "EditSongMiniUC";
            this.Size = new System.Drawing.Size(653, 531);
            this.Load += new System.EventHandler(this.EditSongMiniUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboxAlbum;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.ComboBox comboxPublisher;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.ComboBox comboxGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpDatePublished;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.Label lblDatePublished;
        private System.Windows.Forms.Label lblAlbumName;
        private System.Windows.Forms.Label lblEditSong;
        private System.Windows.Forms.DateTimePicker dtpDuration;
    }
}
