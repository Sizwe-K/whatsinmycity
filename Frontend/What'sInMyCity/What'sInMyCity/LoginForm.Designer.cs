namespace What_sInMyCity
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSignIn = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtLoginEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lnkRegister = new System.Windows.Forms.LinkLabel();
            this.lblLinkReg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.Location = new System.Drawing.Point(745, 168);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(240, 25);
            this.lblSignIn.TabIndex = 2;
            this.lblSignIn.Text = "Sign In to Your Account";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(600, 256);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(98, 16);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email Address:";
            // 
            // txtLoginEmail
            // 
            this.txtLoginEmail.Location = new System.Drawing.Point(603, 304);
            this.txtLoginEmail.Name = "txtLoginEmail";
            this.txtLoginEmail.Size = new System.Drawing.Size(557, 22);
            this.txtLoginEmail.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(600, 374);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 16);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(603, 420);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(557, 22);
            this.txtLoginPassword.TabIndex = 6;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(729, 473);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(300, 52);
            this.btnSignIn.TabIndex = 7;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            // 
            // lnkRegister
            // 
            this.lnkRegister.AutoSize = true;
            this.lnkRegister.Location = new System.Drawing.Point(1033, 649);
            this.lnkRegister.Name = "lnkRegister";
            this.lnkRegister.Size = new System.Drawing.Size(127, 16);
            this.lnkRegister.TabIndex = 8;
            this.lnkRegister.TabStop = true;
            this.lnkRegister.Text = "Back to Registration";
            // 
            // lblLinkReg
            // 
            this.lblLinkReg.AutoSize = true;
            this.lblLinkReg.Location = new System.Drawing.Point(600, 669);
            this.lblLinkReg.Name = "lblLinkReg";
            this.lblLinkReg.Size = new System.Drawing.Size(116, 16);
            this.lblLinkReg.TabIndex = 9;
            this.lblLinkReg.Text = "Need an account?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::What_sInMyCity.Properties.Resources.Untitled;
            this.pictureBox1.Location = new System.Drawing.Point(539, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(678, 140);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1804, 907);
            this.Controls.Add(this.lblLinkReg);
            this.Controls.Add(this.lnkRegister);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtLoginEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm - Sign In";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtLoginEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.LinkLabel lnkRegister;
        private System.Windows.Forms.Label lblLinkReg;
    }
}