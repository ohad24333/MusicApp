
namespace MusicApp.UI.User_Controls
{
    partial class ChooseArtistUC
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
            this.lblAddNewSong = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboxSearchBy = new System.Windows.Forms.ComboBox();
            this.txtSearchInsert = new System.Windows.Forms.TextBox();
            this.lblSearchArtist = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddNewSong
            // 
            this.lblAddNewSong.AutoSize = true;
            this.lblAddNewSong.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddNewSong.Location = new System.Drawing.Point(34, 44);
            this.lblAddNewSong.Name = "lblAddNewSong";
            this.lblAddNewSong.Size = new System.Drawing.Size(264, 51);
            this.lblAddNewSong.TabIndex = 7;
            this.lblAddNewSong.Text = "Choose Artist:";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(224, 171);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboxSearchBy
            // 
            this.comboxSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboxSearchBy.FormattingEnabled = true;
            this.comboxSearchBy.Location = new System.Drawing.Point(180, 132);
            this.comboxSearchBy.Name = "comboxSearchBy";
            this.comboxSearchBy.Size = new System.Drawing.Size(121, 23);
            this.comboxSearchBy.TabIndex = 10;
            // 
            // txtSearchInsert
            // 
            this.txtSearchInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchInsert.Location = new System.Drawing.Point(48, 172);
            this.txtSearchInsert.Name = "txtSearchInsert";
            this.txtSearchInsert.Size = new System.Drawing.Size(170, 23);
            this.txtSearchInsert.TabIndex = 9;
            // 
            // lblSearchArtist
            // 
            this.lblSearchArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchArtist.AutoSize = true;
            this.lblSearchArtist.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearchArtist.Location = new System.Drawing.Point(48, 135);
            this.lblSearchArtist.Name = "lblSearchArtist";
            this.lblSearchArtist.Size = new System.Drawing.Size(120, 20);
            this.lblSearchArtist.TabIndex = 8;
            this.lblSearchArtist.Text = "Search Artist By:";
            // 
            // ChooseArtistUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboxSearchBy);
            this.Controls.Add(this.txtSearchInsert);
            this.Controls.Add(this.lblSearchArtist);
            this.Controls.Add(this.lblAddNewSong);
            this.Name = "ChooseArtistUC";
            this.Size = new System.Drawing.Size(653, 531);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddNewSong;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboxSearchBy;
        private System.Windows.Forms.TextBox txtSearchInsert;
        private System.Windows.Forms.Label lblSearchArtist;
    }
}
