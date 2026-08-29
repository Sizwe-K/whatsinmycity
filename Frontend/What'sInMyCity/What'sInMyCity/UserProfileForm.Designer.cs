namespace What_sInMyCity
{
    partial class UserProfileForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDocExpiry = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblOCR = new System.Windows.Forms.Label();
            this.lblOCRStatus = new System.Windows.Forms.Label();
            this.lblOCRMatch = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpPersonalInformation = new System.Windows.Forms.GroupBox();
            this.grpVerfication = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.txtProfileEmail = new System.Windows.Forms.TextBox();
            this.txtProfilePhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnVerification = new System.Windows.Forms.Button();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpPersonalInformation.SuspendLayout();
            this.grpVerfication.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.OliveDrab;
            this.pictureBox1.Image = global::What_sInMyCity.Properties.Resources.Untitled;
            this.pictureBox1.Location = new System.Drawing.Point(608, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(678, 140);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(749, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Government Document Verification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID / Passport Number:";
            // 
            // txtDocNumber
            // 
            this.txtDocNumber.Location = new System.Drawing.Point(148, 41);
            this.txtDocNumber.Name = "txtDocNumber";
            this.txtDocNumber.Size = new System.Drawing.Size(221, 22);
            this.txtDocNumber.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Document Type:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(682, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Expiry Date:";
            // 
            // dtpDocExpiry
            // 
            this.dtpDocExpiry.Location = new System.Drawing.Point(104, 90);
            this.dtpDocExpiry.Name = "dtpDocExpiry";
            this.dtpDocExpiry.Size = new System.Drawing.Size(265, 22);
            this.dtpDocExpiry.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(308, 506);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(337, 304);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // lblOCR
            // 
            this.lblOCR.AutoSize = true;
            this.lblOCR.Location = new System.Drawing.Point(687, 526);
            this.lblOCR.Name = "lblOCR";
            this.lblOCR.Size = new System.Drawing.Size(148, 16);
            this.lblOCR.TabIndex = 11;
            this.lblOCR.Text = "OCR Verification Status:";
            // 
            // lblOCRStatus
            // 
            this.lblOCRStatus.AutoSize = true;
            this.lblOCRStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOCRStatus.Location = new System.Drawing.Point(686, 565);
            this.lblOCRStatus.Name = "lblOCRStatus";
            this.lblOCRStatus.Size = new System.Drawing.Size(99, 22);
            this.lblOCRStatus.TabIndex = 12;
            this.lblOCRStatus.Text = "VERIFIED";
            // 
            // lblOCRMatch
            // 
            this.lblOCRMatch.AutoSize = true;
            this.lblOCRMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOCRMatch.Location = new System.Drawing.Point(685, 612);
            this.lblOCRMatch.Name = "lblOCRMatch";
            this.lblOCRMatch.Size = new System.Drawing.Size(378, 25);
            this.lblOCRMatch.TabIndex = 13;
            this.lblOCRMatch.Text = "100% Name and Document No. Match";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 14;
            // 
            // grpPersonalInformation
            // 
            this.grpPersonalInformation.Controls.Add(this.txtProfilePhone);
            this.grpPersonalInformation.Controls.Add(this.txtProfileEmail);
            this.grpPersonalInformation.Controls.Add(this.txtProfileName);
            this.grpPersonalInformation.Controls.Add(this.label8);
            this.grpPersonalInformation.Controls.Add(this.label7);
            this.grpPersonalInformation.Controls.Add(this.label6);
            this.grpPersonalInformation.Location = new System.Drawing.Point(301, 215);
            this.grpPersonalInformation.Name = "grpPersonalInformation";
            this.grpPersonalInformation.Size = new System.Drawing.Size(1245, 66);
            this.grpPersonalInformation.TabIndex = 15;
            this.grpPersonalInformation.TabStop = false;
            this.grpPersonalInformation.Text = "Personal information";
            // 
            // grpVerfication
            // 
            this.grpVerfication.Controls.Add(this.label2);
            this.grpVerfication.Controls.Add(this.txtDocNumber);
            this.grpVerfication.Controls.Add(this.label4);
            this.grpVerfication.Controls.Add(this.dtpDocExpiry);
            this.grpVerfication.Controls.Add(this.label3);
            this.grpVerfication.Controls.Add(this.comboBox1);
            this.grpVerfication.Location = new System.Drawing.Point(301, 287);
            this.grpVerfication.Name = "grpVerfication";
            this.grpVerfication.Size = new System.Drawing.Size(1245, 167);
            this.grpVerfication.TabIndex = 16;
            this.grpVerfication.TabStop = false;
            this.grpVerfication.Text = "Government Document Verification (DHA / OCR Integration)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Full Name: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Email: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(852, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Phone: ";
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(86, 21);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(314, 22);
            this.txtProfileName.TabIndex = 17;
            // 
            // txtProfileEmail
            // 
            this.txtProfileEmail.Location = new System.Drawing.Point(556, 15);
            this.txtProfileEmail.Name = "txtProfileEmail";
            this.txtProfileEmail.Size = new System.Drawing.Size(221, 22);
            this.txtProfileEmail.TabIndex = 20;
            // 
            // txtProfilePhone
            // 
            this.txtProfilePhone.Location = new System.Drawing.Point(971, 21);
            this.txtProfilePhone.Name = "txtProfilePhone";
            this.txtProfilePhone.Size = new System.Drawing.Size(221, 22);
            this.txtProfilePhone.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Uploaded Document Scan:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(690, 768);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(195, 42);
            this.btnBrowse.TabIndex = 17;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // btnVerification
            // 
            this.btnVerification.Location = new System.Drawing.Point(1292, 768);
            this.btnVerification.Name = "btnVerification";
            this.btnVerification.Size = new System.Drawing.Size(254, 42);
            this.btnVerification.TabIndex = 18;
            this.btnVerification.Text = "Submit Verification";
            this.btnVerification.UseVisualStyleBackColor = true;
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(301, 848);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(255, 49);
            this.btnBackToMain.TabIndex = 19;
            this.btnBackToMain.Text = "Back to Main Menu";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1292, 837);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(254, 49);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1804, 898);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.btnVerification);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grpVerfication);
            this.Controls.Add(this.grpPersonalInformation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblOCRMatch);
            this.Controls.Add(this.lblOCRStatus);
            this.Controls.Add(this.lblOCR);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserProfileForm";
            this.Load += new System.EventHandler(this.UserProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpPersonalInformation.ResumeLayout(false);
            this.grpPersonalInformation.PerformLayout();
            this.grpVerfication.ResumeLayout(false);
            this.grpVerfication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDocExpiry;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblOCR;
        private System.Windows.Forms.Label lblOCRStatus;
        private System.Windows.Forms.Label lblOCRMatch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpPersonalInformation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpVerfication;
        private System.Windows.Forms.TextBox txtProfilePhone;
        private System.Windows.Forms.TextBox txtProfileEmail;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnVerification;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Button btnLogout;
    }
}