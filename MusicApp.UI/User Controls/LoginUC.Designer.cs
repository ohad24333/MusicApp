
namespace MusicApp.UI
{
    partial class LoginUC
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblLoginExplain = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnForgetPassword = new System.Windows.Forms.Button();
            this.btnSingIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnForOhad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(38, 56);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(162, 65);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login:";
            // 
            // lblLoginExplain
            // 
            this.lblLoginExplain.AutoSize = true;
            this.lblLoginExplain.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoginExplain.Location = new System.Drawing.Point(66, 156);
            this.lblLoginExplain.Name = "lblLoginExplain";
            this.lblLoginExplain.Size = new System.Drawing.Size(347, 21);
            this.lblLoginExplain.TabIndex = 1;
            this.lblLoginExplain.Text = "Please Enter Your Email And Passwors To Login";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(87, 213);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 17);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(87, 265);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(172, 213);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 23);
            this.txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(172, 264);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(241, 23);
            this.txtPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(316, 331);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(97, 30);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnForgetPassword
            // 
            this.btnForgetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForgetPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnForgetPassword.Location = new System.Drawing.Point(66, 331);
            this.btnForgetPassword.Name = "btnForgetPassword";
            this.btnForgetPassword.Size = new System.Drawing.Size(156, 30);
            this.btnForgetPassword.TabIndex = 7;
            this.btnForgetPassword.Text = "I Forgot My Password";
            this.btnForgetPassword.UseVisualStyleBackColor = true;
            this.btnForgetPassword.Click += new System.EventHandler(this.btnForgetPassword_Click);
            // 
            // btnSingIn
            // 
            this.btnSingIn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSingIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSingIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSingIn.Location = new System.Drawing.Point(316, 387);
            this.btnSingIn.Name = "btnSingIn";
            this.btnSingIn.Size = new System.Drawing.Size(96, 37);
            this.btnSingIn.TabIndex = 8;
            this.btnSingIn.Text = "Sing In";
            this.btnSingIn.UseVisualStyleBackColor = false;
            this.btnSingIn.Click += new System.EventHandler(this.btnSingIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(66, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Don\'t Have A User Yet? Please Sing In";
            // 
            // btnForOhad
            // 
            this.btnForOhad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForOhad.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnForOhad.Location = new System.Drawing.Point(703, 130);
            this.btnForOhad.Name = "btnForOhad";
            this.btnForOhad.Size = new System.Drawing.Size(338, 231);
            this.btnForOhad.TabIndex = 10;
            this.btnForOhad.Text = "Login With Admin User (Login With My User \"Ohad Saadia\" :) . )";
            this.btnForOhad.UseVisualStyleBackColor = true;
            this.btnForOhad.Click += new System.EventHandler(this.btnForOhad_Click);
            // 
            // LoginUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnForOhad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSingIn);
            this.Controls.Add(this.btnForgetPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLoginExplain);
            this.Controls.Add(this.lblLogin);
            this.Name = "LoginUC";
            this.Size = new System.Drawing.Size(1307, 616);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblLoginExplain;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnForgetPassword;
        private System.Windows.Forms.Button btnSingIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnForOhad;
    }
}
