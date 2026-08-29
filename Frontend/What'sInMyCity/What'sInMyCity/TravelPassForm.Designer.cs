namespace What_sInMyCity
{
    partial class TravelPassForm
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
            this.grpPassDetails = new System.Windows.Forms.GroupBox();
            this.lblPassID = new System.Windows.Forms.Label();
            this.lblPassType = new System.Windows.Forms.Label();
            this.lblHolderName = new System.Windows.Forms.Label();
            this.lblValidUntil = new System.Windows.Forms.Label();
            this.lblPassStatus = new System.Windows.Forms.Label();
            this.picQRCode = new System.Windows.Forms.PictureBox();
            this.btnPrintPDF = new System.Windows.Forms.Button();
            this.btnSimulateScan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpPassDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.OliveDrab;
            this.pictureBox1.Image = global::What_sInMyCity.Properties.Resources.Untitled;
            this.pictureBox1.Location = new System.Drawing.Point(594, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(678, 140);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // grpPassDetails
            // 
            this.grpPassDetails.Controls.Add(this.btnSimulateScan);
            this.grpPassDetails.Controls.Add(this.btnPrintPDF);
            this.grpPassDetails.Controls.Add(this.picQRCode);
            this.grpPassDetails.Controls.Add(this.lblPassStatus);
            this.grpPassDetails.Controls.Add(this.lblValidUntil);
            this.grpPassDetails.Controls.Add(this.lblHolderName);
            this.grpPassDetails.Controls.Add(this.lblPassType);
            this.grpPassDetails.Controls.Add(this.lblPassID);
            this.grpPassDetails.Location = new System.Drawing.Point(435, 169);
            this.grpPassDetails.Name = "grpPassDetails";
            this.grpPassDetails.Size = new System.Drawing.Size(988, 654);
            this.grpPassDetails.TabIndex = 2;
            this.grpPassDetails.TabStop = false;
            this.grpPassDetails.Text = "Travel Pass Details";
            // 
            // lblPassID
            // 
            this.lblPassID.AutoSize = true;
            this.lblPassID.Location = new System.Drawing.Point(28, 46);
            this.lblPassID.Name = "lblPassID";
            this.lblPassID.Size = new System.Drawing.Size(57, 16);
            this.lblPassID.TabIndex = 0;
            this.lblPassID.Text = "Pass ID:";
            // 
            // lblPassType
            // 
            this.lblPassType.AutoSize = true;
            this.lblPassType.Location = new System.Drawing.Point(28, 101);
            this.lblPassType.Name = "lblPassType";
            this.lblPassType.Size = new System.Drawing.Size(76, 16);
            this.lblPassType.TabIndex = 1;
            this.lblPassType.Text = "Pass Type:";
            // 
            // lblHolderName
            // 
            this.lblHolderName.AutoSize = true;
            this.lblHolderName.Location = new System.Drawing.Point(28, 145);
            this.lblHolderName.Name = "lblHolderName";
            this.lblHolderName.Size = new System.Drawing.Size(91, 16);
            this.lblHolderName.TabIndex = 2;
            this.lblHolderName.Text = "Holder Name:";
            // 
            // lblValidUntil
            // 
            this.lblValidUntil.AutoSize = true;
            this.lblValidUntil.Location = new System.Drawing.Point(28, 188);
            this.lblValidUntil.Name = "lblValidUntil";
            this.lblValidUntil.Size = new System.Drawing.Size(70, 16);
            this.lblValidUntil.TabIndex = 3;
            this.lblValidUntil.Text = "Valid Until:";
            // 
            // lblPassStatus
            // 
            this.lblPassStatus.AutoSize = true;
            this.lblPassStatus.Location = new System.Drawing.Point(28, 232);
            this.lblPassStatus.Name = "lblPassStatus";
            this.lblPassStatus.Size = new System.Drawing.Size(81, 16);
            this.lblPassStatus.TabIndex = 4;
            this.lblPassStatus.Text = "Pass Status:";
            // 
            // picQRCode
            // 
            this.picQRCode.Location = new System.Drawing.Point(512, 21);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(441, 327);
            this.picQRCode.TabIndex = 5;
            this.picQRCode.TabStop = false;
            // 
            // btnPrintPDF
            // 
            this.btnPrintPDF.Location = new System.Drawing.Point(31, 423);
            this.btnPrintPDF.Name = "btnPrintPDF";
            this.btnPrintPDF.Size = new System.Drawing.Size(171, 23);
            this.btnPrintPDF.TabIndex = 6;
            this.btnPrintPDF.Text = "Save/Print PDF";
            this.btnPrintPDF.UseVisualStyleBackColor = true;
            // 
            // btnSimulateScan
            // 
            this.btnSimulateScan.Location = new System.Drawing.Point(782, 423);
            this.btnSimulateScan.Name = "btnSimulateScan";
            this.btnSimulateScan.Size = new System.Drawing.Size(171, 23);
            this.btnSimulateScan.TabIndex = 7;
            this.btnSimulateScan.Text = "Test QR";
            this.btnSimulateScan.UseVisualStyleBackColor = true;
            // 
            // TravelPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1801, 815);
            this.Controls.Add(this.grpPassDetails);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TravelPassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TravelPassForm";
            this.Load += new System.EventHandler(this.TravelPassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpPassDetails.ResumeLayout(false);
            this.grpPassDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpPassDetails;
        private System.Windows.Forms.Label lblValidUntil;
        private System.Windows.Forms.Label lblHolderName;
        private System.Windows.Forms.Label lblPassType;
        private System.Windows.Forms.Label lblPassID;
        private System.Windows.Forms.Button btnSimulateScan;
        private System.Windows.Forms.Button btnPrintPDF;
        private System.Windows.Forms.PictureBox picQRCode;
        private System.Windows.Forms.Label lblPassStatus;
    }
}