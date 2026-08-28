namespace What_sInMyCity
{
    partial class AttractionsForm
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
            this.lblDestination = new System.Windows.Forms.Label();
            this.cboCities = new System.Windows.Forms.ComboBox();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.cboSort = new System.Windows.Forms.ComboBox();
            this.lblMaxPrice = new System.Windows.Forms.Label();
            this.cboMaxPrice = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dgvAttractions = new System.Windows.Forms.DataGridView();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnBookSelected = new System.Windows.Forms.Button();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttractions)).BeginInit();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::What_sInMyCity.Properties.Resources.Untitled;
            this.pictureBox1.Location = new System.Drawing.Point(630, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(678, 140);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(785, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "EXPLORE AND FIND ATTRACTIONS";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(396, 265);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(156, 16);
            this.lblDestination.TabIndex = 3;
            this.lblDestination.Text = "SELECT DESTINATION:";
            // 
            // cboCities
            // 
            this.cboCities.FormattingEnabled = true;
            this.cboCities.Location = new System.Drawing.Point(562, 262);
            this.cboCities.Name = "cboCities";
            this.cboCities.Size = new System.Drawing.Size(221, 24);
            this.cboCities.TabIndex = 4;
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Location = new System.Drawing.Point(799, 265);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(72, 16);
            this.lblSortBy.TabIndex = 5;
            this.lblSortBy.Text = "SORT BY: ";
            // 
            // cboSort
            // 
            this.cboSort.FormattingEnabled = true;
            this.cboSort.Location = new System.Drawing.Point(886, 262);
            this.cboSort.Name = "cboSort";
            this.cboSort.Size = new System.Drawing.Size(179, 24);
            this.cboSort.TabIndex = 6;
            // 
            // lblMaxPrice
            // 
            this.lblMaxPrice.AutoSize = true;
            this.lblMaxPrice.Location = new System.Drawing.Point(1093, 270);
            this.lblMaxPrice.Name = "lblMaxPrice";
            this.lblMaxPrice.Size = new System.Drawing.Size(84, 16);
            this.lblMaxPrice.TabIndex = 7;
            this.lblMaxPrice.Text = "MAX PRICE: ";
            // 
            // cboMaxPrice
            // 
            this.cboMaxPrice.FormattingEnabled = true;
            this.cboMaxPrice.Location = new System.Drawing.Point(1194, 262);
            this.cboMaxPrice.Name = "cboMaxPrice";
            this.cboMaxPrice.Size = new System.Drawing.Size(224, 24);
            this.cboMaxPrice.TabIndex = 8;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Yellow;
            this.btnFilter.Location = new System.Drawing.Point(1437, 254);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(135, 39);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // dgvAttractions
            // 
            this.dgvAttractions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttractions.Location = new System.Drawing.Point(399, 299);
            this.dgvAttractions.Name = "dgvAttractions";
            this.dgvAttractions.RowHeadersWidth = 51;
            this.dgvAttractions.RowTemplate.Height = 24;
            this.dgvAttractions.Size = new System.Drawing.Size(1217, 191);
            this.dgvAttractions.TabIndex = 10;
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.btnBookSelected);
            this.grpDetails.Controls.Add(this.txtDescription);
            this.grpDetails.Controls.Add(this.lblDescription);
            this.grpDetails.Location = new System.Drawing.Point(399, 525);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(1229, 162);
            this.grpDetails.TabIndex = 11;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Selected Activity Details";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 37);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(81, 16);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description: ";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(9, 56);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(1208, 27);
            this.txtDescription.TabIndex = 13;
            // 
            // btnBookSelected
            // 
            this.btnBookSelected.Location = new System.Drawing.Point(972, 109);
            this.btnBookSelected.Name = "btnBookSelected";
            this.btnBookSelected.Size = new System.Drawing.Size(245, 23);
            this.btnBookSelected.TabIndex = 14;
            this.btnBookSelected.Text = "Book Activity";
            this.btnBookSelected.UseVisualStyleBackColor = true;
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(399, 811);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(299, 49);
            this.btnBackToMain.TabIndex = 15;
            this.btnBackToMain.Text = "Back to Main Menu";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1374, 811);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(254, 49);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // AttractionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1794, 872);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.dgvAttractions);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cboMaxPrice);
            this.Controls.Add(this.lblMaxPrice);
            this.Controls.Add(this.cboSort);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.cboCities);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AttractionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttractionsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttractions)).EndInit();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.ComboBox cboCities;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.ComboBox cboSort;
        private System.Windows.Forms.Label lblMaxPrice;
        private System.Windows.Forms.ComboBox cboMaxPrice;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dgvAttractions;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Button btnBookSelected;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Button btnLogout;
    }
}