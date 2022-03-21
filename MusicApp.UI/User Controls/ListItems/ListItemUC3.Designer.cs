
namespace MusicApp.UI
{
    partial class ListItemUC3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(146, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(485, 27);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            this.lblTitle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListArtistsItemUC_MouseClick);
            this.lblTitle.MouseEnter += new System.EventHandler(this.panel3_MouseEnter);
            this.lblTitle.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            // 
            // lblText
            // 
            this.lblText.Location = new System.Drawing.Point(146, 58);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(485, 46);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Some Text Here";
            this.lblText.Click += new System.EventHandler(this.lblText_Click);
            this.lblText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListArtistsItemUC_MouseClick);
            this.lblText.MouseEnter += new System.EventHandler(this.panel3_MouseEnter);
            this.lblText.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 120);
            this.panel1.TabIndex = 3;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListArtistsItemUC_MouseClick);
            this.panel1.MouseEnter += new System.EventHandler(this.panel3_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(0, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(648, 1);
            this.panel3.TabIndex = 5;
            this.panel3.MouseEnter += new System.EventHandler(this.panel3_MouseEnter);
            this.panel3.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 1);
            this.panel2.TabIndex = 4;
            // 
            // ListItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "ListItemUC";
            this.Size = new System.Drawing.Size(653, 123);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListArtistsItemUC_MouseClick);
            this.MouseEnter += new System.EventHandler(this.panel3_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}
