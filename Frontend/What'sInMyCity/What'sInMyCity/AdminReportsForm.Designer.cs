namespace What_sInMyCity
{
    partial class AdminReportsForm
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
            this.grpParameters = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cboReportCity = new System.Windows.Forms.ComboBox();
            this.btnRunReport = new System.Windows.Forms.Button();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvSummaryReport = new System.Windows.Forms.DataGridView();
            this.lblSummaryTotals = new System.Windows.Forms.Label();
            this.btnExportReport = new System.Windows.Forms.Button();
            this.dgvAuditTrail = new System.Windows.Forms.DataGridView();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpParameters.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummaryReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditTrail)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::What_sInMyCity.Properties.Resources.Untitled;
            this.pictureBox1.Location = new System.Drawing.Point(401, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(678, 140);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(547, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "MANAGEMENT REPORTS & ANALYTICS";
            // 
            // grpParameters
            // 
            this.grpParameters.Controls.Add(this.btnRunReport);
            this.grpParameters.Controls.Add(this.cboReportCity);
            this.grpParameters.Controls.Add(this.dateTimePicker2);
            this.grpParameters.Controls.Add(this.dateTimePicker1);
            this.grpParameters.Controls.Add(this.label4);
            this.grpParameters.Controls.Add(this.label3);
            this.grpParameters.Controls.Add(this.label2);
            this.grpParameters.Location = new System.Drawing.Point(332, 327);
            this.grpParameters.Name = "grpParameters";
            this.grpParameters.Size = new System.Drawing.Size(1014, 118);
            this.grpParameters.TabIndex = 3;
            this.grpParameters.TabStop = false;
            this.grpParameters.Text = "FILTER PARAMETERS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "City";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(336, 28);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(215, 22);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // cboReportCity
            // 
            this.cboReportCity.FormattingEnabled = true;
            this.cboReportCity.Location = new System.Drawing.Point(660, 25);
            this.cboReportCity.Name = "cboReportCity";
            this.cboReportCity.Size = new System.Drawing.Size(199, 24);
            this.cboReportCity.TabIndex = 5;
            // 
            // btnRunReport
            // 
            this.btnRunReport.Location = new System.Drawing.Point(660, 56);
            this.btnRunReport.Name = "btnRunReport";
            this.btnRunReport.Size = new System.Drawing.Size(199, 23);
            this.btnRunReport.TabIndex = 6;
            this.btnRunReport.Text = "Run Report";
            this.btnRunReport.UseVisualStyleBackColor = true;
            // 
            // tab1
            // 
            this.tab1.AccessibleDescription = "Summarized Revenue & Activity";
            this.tab1.AccessibleName = "Summarized Revenue & Activity";
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Location = new System.Drawing.Point(332, 451);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(1014, 100);
            this.tab1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1006, 71);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(868, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvSummaryReport
            // 
            this.dgvSummaryReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummaryReport.Location = new System.Drawing.Point(332, 576);
            this.dgvSummaryReport.Name = "dgvSummaryReport";
            this.dgvSummaryReport.RowHeadersWidth = 51;
            this.dgvSummaryReport.RowTemplate.Height = 24;
            this.dgvSummaryReport.Size = new System.Drawing.Size(1014, 99);
            this.dgvSummaryReport.TabIndex = 5;
            // 
            // lblSummaryTotals
            // 
            this.lblSummaryTotals.AutoSize = true;
            this.lblSummaryTotals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryTotals.Location = new System.Drawing.Point(331, 747);
            this.lblSummaryTotals.Name = "lblSummaryTotals";
            this.lblSummaryTotals.Size = new System.Drawing.Size(827, 25);
            this.lblSummaryTotals.TabIndex = 6;
            this.lblSummaryTotals.Text = "SUMMARY TOTALS    Total: 89    Total: 50    SUM: R 66,400.00    Overall Avg: 4.63" +
    "";
            // 
            // btnExportReport
            // 
            this.btnExportReport.Location = new System.Drawing.Point(1092, 834);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(254, 23);
            this.btnExportReport.TabIndex = 7;
            this.btnExportReport.Text = "Export PDF / CSV";
            this.btnExportReport.UseVisualStyleBackColor = true;
            // 
            // dgvAuditTrail
            // 
            this.dgvAuditTrail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditTrail.Location = new System.Drawing.Point(332, 694);
            this.dgvAuditTrail.Name = "dgvAuditTrail";
            this.dgvAuditTrail.RowHeadersWidth = 51;
            this.dgvAuditTrail.RowTemplate.Height = 24;
            this.dgvAuditTrail.Size = new System.Drawing.Size(1014, 117);
            this.dgvAuditTrail.TabIndex = 8;
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(330, 857);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(255, 49);
            this.btnBackToMain.TabIndex = 9;
            this.btnBackToMain.Text = "Back to Main Menu";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1092, 867);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(254, 49);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // AdminReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1700, 928);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.dgvAuditTrail);
            this.Controls.Add(this.btnExportReport);
            this.Controls.Add(this.lblSummaryTotals);
            this.Controls.Add(this.dgvSummaryReport);
            this.Controls.Add(this.tab1);
            this.Controls.Add(this.grpParameters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdminReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminReportsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpParameters.ResumeLayout(false);
            this.grpParameters.PerformLayout();
            this.tab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummaryReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditTrail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpParameters;
        private System.Windows.Forms.Button btnRunReport;
        private System.Windows.Forms.ComboBox cboReportCity;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvSummaryReport;
        private System.Windows.Forms.Label lblSummaryTotals;
        private System.Windows.Forms.Button btnExportReport;
        private System.Windows.Forms.DataGridView dgvAuditTrail;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Button btnLogout;
    }
}