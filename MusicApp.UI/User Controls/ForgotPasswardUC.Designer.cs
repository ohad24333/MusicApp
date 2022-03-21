
namespace MusicApp.UI.User_Controls
{
    partial class ForgotPasswardUC
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
            this.lblForgotPassward = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSendPasswardToMyEmail = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.kbkSignIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblForgotPassward
            // 
            this.lblForgotPassward.AutoSize = true;
            this.lblForgotPassward.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblForgotPassward.Location = new System.Drawing.Point(65, 57);
            this.lblForgotPassward.Name = "lblForgotPassward";
            this.lblForgotPassward.Size = new System.Drawing.Size(410, 65);
            this.lblForgotPassward.TabIndex = 1;
            this.lblForgotPassward.Text = "Forgot Passward?";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(173, 165);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(88, 165);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 17);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // lblSendPasswardToMyEmail
            // 
            this.lblSendPasswardToMyEmail.AutoSize = true;
            this.lblSendPasswardToMyEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSendPasswardToMyEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSendPasswardToMyEmail.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSendPasswardToMyEmail.Location = new System.Drawing.Point(88, 213);
            this.lblSendPasswardToMyEmail.Name = "lblSendPasswardToMyEmail";
            this.lblSendPasswardToMyEmail.Size = new System.Drawing.Size(208, 21);
            this.lblSendPasswardToMyEmail.TabIndex = 5;
            this.lblSendPasswardToMyEmail.Text = "Send Passward To My Email";
            this.lblSendPasswardToMyEmail.Click += new System.EventHandler(this.lblSendPasswardToMyEmail_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(88, 306);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 36);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // kbkSignIn
            // 
            this.kbkSignIn.AutoSize = true;
            this.kbkSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kbkSignIn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kbkSignIn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.kbkSignIn.Location = new System.Drawing.Point(354, 213);
            this.kbkSignIn.Name = "kbkSignIn";
            this.kbkSignIn.Size = new System.Drawing.Size(60, 21);
            this.kbkSignIn.TabIndex = 9;
            this.kbkSignIn.Text = "Sign In";
            this.kbkSignIn.Click += new System.EventHandler(this.kbkSignIn_Click);
            // 
            // ForgotPasswardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kbkSignIn);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSendPasswardToMyEmail);
            this.Controls.Add(this.lblForgotPassward);
            this.Name = "ForgotPasswardUC";
            this.Size = new System.Drawing.Size(1307, 616);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForgotPassward;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSendPasswardToMyEmail;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label kbkSignIn;
    }
}
