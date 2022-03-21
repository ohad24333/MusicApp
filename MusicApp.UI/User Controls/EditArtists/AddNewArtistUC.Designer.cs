
namespace MusicApp.UI.User_Controls.EditArtists
{
    partial class AddNewArtistUC
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
            this.lblDuration = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblAddNewArtist = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtStageName = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.comboxContries = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblDuration.Location = new System.Drawing.Point(48, 269);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(127, 28);
            this.lblDuration.TabIndex = 26;
            this.lblDuration.Text = "Stage Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(447, 440);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 59);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(227, 145);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 27);
            this.txtFirstName.TabIndex = 23;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(48, 144);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(115, 28);
            this.lblFirstName.TabIndex = 21;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblAddNewArtist
            // 
            this.lblAddNewArtist.AutoSize = true;
            this.lblAddNewArtist.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddNewArtist.Location = new System.Drawing.Point(48, 34);
            this.lblAddNewArtist.Name = "lblAddNewArtist";
            this.lblAddNewArtist.Size = new System.Drawing.Size(332, 51);
            this.lblAddNewArtist.TabIndex = 20;
            this.lblAddNewArtist.Text = "Add A New Artist:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(227, 206);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 27);
            this.txtLastName.TabIndex = 35;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(48, 205);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(113, 28);
            this.lblLastName.TabIndex = 34;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtStageName
            // 
            this.txtStageName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStageName.Location = new System.Drawing.Point(227, 270);
            this.txtStageName.Name = "txtStageName";
            this.txtStageName.Size = new System.Drawing.Size(200, 27);
            this.txtStageName.TabIndex = 36;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblCountry.Location = new System.Drawing.Point(48, 330);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(90, 28);
            this.lblCountry.TabIndex = 37;
            this.lblCountry.Text = "Country:";
            // 
            // comboxContries
            // 
            this.comboxContries.FormattingEnabled = true;
            this.comboxContries.Location = new System.Drawing.Point(227, 335);
            this.comboxContries.Name = "comboxContries";
            this.comboxContries.Size = new System.Drawing.Size(200, 23);
            this.comboxContries.TabIndex = 38;
            // 
            // AddNewArtistUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboxContries);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtStageName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblAddNewArtist);
            this.Name = "AddNewArtistUC";
            this.Size = new System.Drawing.Size(653, 531);
            this.Load += new System.EventHandler(this.AddNewArtistUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblAddNewArtist;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtStageName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox comboxContries;
    }
}
