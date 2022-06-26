namespace WFAHotelRezervasyon
{
    partial class Form1
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
            this.gbxCustomerInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.btnCustomerInfo = new System.Windows.Forms.Button();
            this.nudCustomerId = new System.Windows.Forms.NumericUpDown();
            this.gbxHotelInfo = new System.Windows.Forms.GroupBox();
            this.btnSearchHotel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxHotels = new System.Windows.Forms.ComboBox();
            this.dgwHotelList = new System.Windows.Forms.DataGridView();
            this.gbxCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomerId)).BeginInit();
            this.gbxHotelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHotelList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCustomerInfo
            // 
            this.gbxCustomerInfo.Controls.Add(this.nudCustomerId);
            this.gbxCustomerInfo.Controls.Add(this.btnCustomerInfo);
            this.gbxCustomerInfo.Controls.Add(this.tbxSurname);
            this.gbxCustomerInfo.Controls.Add(this.tbxName);
            this.gbxCustomerInfo.Controls.Add(this.label2);
            this.gbxCustomerInfo.Controls.Add(this.label1);
            this.gbxCustomerInfo.Location = new System.Drawing.Point(12, 12);
            this.gbxCustomerInfo.Name = "gbxCustomerInfo";
            this.gbxCustomerInfo.Size = new System.Drawing.Size(227, 172);
            this.gbxCustomerInfo.TabIndex = 0;
            this.gbxCustomerInfo.TabStop = false;
            this.gbxCustomerInfo.Text = "Customer Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(64, 24);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(125, 20);
            this.tbxName.TabIndex = 2;
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(64, 48);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.ReadOnly = true;
            this.tbxSurname.Size = new System.Drawing.Size(125, 20);
            this.tbxSurname.TabIndex = 3;
            // 
            // btnCustomerInfo
            // 
            this.btnCustomerInfo.Location = new System.Drawing.Point(64, 100);
            this.btnCustomerInfo.Name = "btnCustomerInfo";
            this.btnCustomerInfo.Size = new System.Drawing.Size(125, 57);
            this.btnCustomerInfo.TabIndex = 4;
            this.btnCustomerInfo.Text = "Show Customer Info";
            this.btnCustomerInfo.UseVisualStyleBackColor = true;
            this.btnCustomerInfo.Click += new System.EventHandler(this.btnCustomerInfo_Click);
            // 
            // nudCustomerId
            // 
            this.nudCustomerId.Location = new System.Drawing.Point(108, 74);
            this.nudCustomerId.Name = "nudCustomerId";
            this.nudCustomerId.Size = new System.Drawing.Size(34, 20);
            this.nudCustomerId.TabIndex = 5;
            // 
            // gbxHotelInfo
            // 
            this.gbxHotelInfo.Controls.Add(this.cbxHotels);
            this.gbxHotelInfo.Controls.Add(this.label5);
            this.gbxHotelInfo.Controls.Add(this.btnSearchHotel);
            this.gbxHotelInfo.Location = new System.Drawing.Point(245, 12);
            this.gbxHotelInfo.Name = "gbxHotelInfo";
            this.gbxHotelInfo.Size = new System.Drawing.Size(543, 64);
            this.gbxHotelInfo.TabIndex = 6;
            this.gbxHotelInfo.TabStop = false;
            this.gbxHotelInfo.Text = "Hotel Info";
            // 
            // btnSearchHotel
            // 
            this.btnSearchHotel.Location = new System.Drawing.Point(292, 19);
            this.btnSearchHotel.Name = "btnSearchHotel";
            this.btnSearchHotel.Size = new System.Drawing.Size(97, 25);
            this.btnSearchHotel.TabIndex = 4;
            this.btnSearchHotel.Text = "Search Hotels";
            this.btnSearchHotel.UseVisualStyleBackColor = true;
            this.btnSearchHotel.Click += new System.EventHandler(this.btnSearchHotel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Location:";
            // 
            // cbxHotels
            // 
            this.cbxHotels.FormattingEnabled = true;
            this.cbxHotels.Location = new System.Drawing.Point(63, 21);
            this.cbxHotels.Name = "cbxHotels";
            this.cbxHotels.Size = new System.Drawing.Size(223, 21);
            this.cbxHotels.TabIndex = 7;
            // 
            // dgwHotelList
            // 
            this.dgwHotelList.AllowUserToOrderColumns = true;
            this.dgwHotelList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwHotelList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwHotelList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgwHotelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHotelList.Location = new System.Drawing.Point(245, 82);
            this.dgwHotelList.Name = "dgwHotelList";
            this.dgwHotelList.ReadOnly = true;
            this.dgwHotelList.Size = new System.Drawing.Size(543, 356);
            this.dgwHotelList.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwHotelList);
            this.Controls.Add(this.gbxHotelInfo);
            this.Controls.Add(this.gbxCustomerInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxCustomerInfo.ResumeLayout(false);
            this.gbxCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomerId)).EndInit();
            this.gbxHotelInfo.ResumeLayout(false);
            this.gbxHotelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHotelList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCustomerInfo;
        private System.Windows.Forms.NumericUpDown nudCustomerId;
        private System.Windows.Forms.Button btnCustomerInfo;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxHotelInfo;
        private System.Windows.Forms.ComboBox cbxHotels;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchHotel;
        private System.Windows.Forms.DataGridView dgwHotelList;
    }
}

