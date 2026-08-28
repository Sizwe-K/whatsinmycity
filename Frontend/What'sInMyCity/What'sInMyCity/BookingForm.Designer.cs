namespace What_sInMyCity
{
    partial class BookingForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.lblNumVisitors = new System.Windows.Forms.Label();
            this.numVisitors = new System.Windows.Forms.NumericUpDown();
            this.chkTransport = new System.Windows.Forms.CheckBox();
            this.cboTransportOptions = new System.Windows.Forms.ComboBox();
            this.lblTransport = new System.Windows.Forms.Label();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCardType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCardHolder = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtExpiry = new System.Windows.Forms.TextBox();
            this.lblTotalDue = new System.Windows.Forms.Label();
            this.btnUpdateBooking = new System.Windows.Forms.Button();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBackToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVisitors)).BeginInit();
            this.grpPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::What_sInMyCity.Properties.Resources.Untitled;
            this.pictureBox1.Location = new System.Drawing.Point(552, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(678, 140);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(789, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "BOOKING AND CHECKOUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected Attraction: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ticket Price: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Booking Date: ";
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Location = new System.Drawing.Point(724, 287);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(231, 22);
            this.dtpBookingDate.TabIndex = 6;
            // 
            // lblNumVisitors
            // 
            this.lblNumVisitors.AutoSize = true;
            this.lblNumVisitors.Location = new System.Drawing.Point(970, 245);
            this.lblNumVisitors.Name = "lblNumVisitors";
            this.lblNumVisitors.Size = new System.Drawing.Size(119, 16);
            this.lblNumVisitors.TabIndex = 7;
            this.lblNumVisitors.Text = "Number of Visitors:";
            // 
            // numVisitors
            // 
            this.numVisitors.Location = new System.Drawing.Point(1110, 239);
            this.numVisitors.Name = "numVisitors";
            this.numVisitors.Size = new System.Drawing.Size(120, 22);
            this.numVisitors.TabIndex = 8;
            // 
            // chkTransport
            // 
            this.chkTransport.AutoSize = true;
            this.chkTransport.Location = new System.Drawing.Point(601, 340);
            this.chkTransport.Name = "chkTransport";
            this.chkTransport.Size = new System.Drawing.Size(182, 20);
            this.chkTransport.TabIndex = 9;
            this.chkTransport.Text = "Include Transport Service";
            this.chkTransport.UseVisualStyleBackColor = true;
            // 
            // cboTransportOptions
            // 
            this.cboTransportOptions.FormattingEnabled = true;
            this.cboTransportOptions.Location = new System.Drawing.Point(755, 384);
            this.cboTransportOptions.Name = "cboTransportOptions";
            this.cboTransportOptions.Size = new System.Drawing.Size(215, 24);
            this.cboTransportOptions.TabIndex = 10;
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Location = new System.Drawing.Point(598, 392);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(151, 16);
            this.lblTransport.TabIndex = 11;
            this.lblTransport.Text = "Select Transport Option:";
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.lblTotalDue);
            this.grpPayment.Controls.Add(this.txtExpiry);
            this.grpPayment.Controls.Add(this.label9);
            this.grpPayment.Controls.Add(this.txtCVV);
            this.grpPayment.Controls.Add(this.label8);
            this.grpPayment.Controls.Add(this.txtCardNumber);
            this.grpPayment.Controls.Add(this.label7);
            this.grpPayment.Controls.Add(this.txtCardHolder);
            this.grpPayment.Controls.Add(this.label6);
            this.grpPayment.Controls.Add(this.cboCardType);
            this.grpPayment.Controls.Add(this.label5);
            this.grpPayment.Location = new System.Drawing.Point(460, 447);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(961, 216);
            this.grpPayment.TabIndex = 12;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Payment Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Card Type:";
            // 
            // cboCardType
            // 
            this.cboCardType.FormattingEnabled = true;
            this.cboCardType.Location = new System.Drawing.Point(117, 19);
            this.cboCardType.Name = "cboCardType";
            this.cboCardType.Size = new System.Drawing.Size(316, 24);
            this.cboCardType.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cardholder Name:";
            // 
            // txtCardHolder
            // 
            this.txtCardHolder.Location = new System.Drawing.Point(627, 19);
            this.txtCardHolder.Name = "txtCardHolder";
            this.txtCardHolder.Size = new System.Drawing.Size(293, 22);
            this.txtCardHolder.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Card Number:";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(140, 65);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(293, 22);
            this.txtCardNumber.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(485, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "CVV:";
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(627, 62);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(293, 22);
            this.txtCVV.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Expiry Date:";
            // 
            // txtExpiry
            // 
            this.txtExpiry.Location = new System.Drawing.Point(140, 117);
            this.txtExpiry.Name = "txtExpiry";
            this.txtExpiry.Size = new System.Drawing.Size(293, 22);
            this.txtExpiry.TabIndex = 22;
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.AutoSize = true;
            this.lblTotalDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDue.Location = new System.Drawing.Point(483, 114);
            this.lblTotalDue.Name = "lblTotalDue";
            this.lblTotalDue.Size = new System.Drawing.Size(251, 25);
            this.lblTotalDue.TabIndex = 23;
            this.lblTotalDue.Text = "TOTAL DUE: R 1,320.00";
            // 
            // btnUpdateBooking
            // 
            this.btnUpdateBooking.Location = new System.Drawing.Point(861, 682);
            this.btnUpdateBooking.Name = "btnUpdateBooking";
            this.btnUpdateBooking.Size = new System.Drawing.Size(181, 36);
            this.btnUpdateBooking.TabIndex = 13;
            this.btnUpdateBooking.Text = "Update Booking";
            this.btnUpdateBooking.UseVisualStyleBackColor = true;
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.Location = new System.Drawing.Point(1240, 682);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(181, 36);
            this.btnConfirmPayment.TabIndex = 14;
            this.btnConfirmPayment.Text = "Confirm Payment";
            this.btnConfirmPayment.UseVisualStyleBackColor = true;
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Location = new System.Drawing.Point(460, 682);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(181, 36);
            this.btnCancelBooking.TabIndex = 15;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1167, 820);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(254, 49);
            this.btnLogout.TabIndex = 24;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(460, 820);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(255, 49);
            this.btnBackToMain.TabIndex = 25;
            this.btnBackToMain.Text = "Back to Main Menu";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1799, 881);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCancelBooking);
            this.Controls.Add(this.btnConfirmPayment);
            this.Controls.Add(this.btnUpdateBooking);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.lblTransport);
            this.Controls.Add(this.cboTransportOptions);
            this.Controls.Add(this.chkTransport);
            this.Controls.Add(this.numVisitors);
            this.Controls.Add(this.lblNumVisitors);
            this.Controls.Add(this.dtpBookingDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVisitors)).EndInit();
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.Label lblNumVisitors;
        private System.Windows.Forms.NumericUpDown numVisitors;
        private System.Windows.Forms.CheckBox chkTransport;
        private System.Windows.Forms.ComboBox cboTransportOptions;
        private System.Windows.Forms.Label lblTransport;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCardHolder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCardType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblTotalDue;
        private System.Windows.Forms.TextBox txtExpiry;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Button btnUpdateBooking;
        private System.Windows.Forms.Button btnConfirmPayment;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBackToMain;
    }
}