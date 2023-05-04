namespace HotelManagementSystem
{
    partial class frmViewBooking
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
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.cbStaff = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCustomerPhone = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btHideDate = new System.Windows.Forms.Button();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.cbRoominDetails = new System.Windows.Forms.ComboBox();
            this.cbStaffinDetail = new System.Windows.Forms.ComboBox();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbCustomerPhoneinDetail = new System.Windows.Forms.TextBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbCustomerId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.gbDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBooking
            // 
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Location = new System.Drawing.Point(28, 162);
            this.dgvBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.RowHeadersWidth = 51;
            this.dgvBooking.RowTemplate.Height = 29;
            this.dgvBooking.Size = new System.Drawing.Size(911, 675);
            this.dgvBooking.TabIndex = 0;
            this.dgvBooking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooking_CellClick);
            // 
            // cbRoom
            // 
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Location = new System.Drawing.Point(132, 29);
            this.cbRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(273, 33);
            this.cbRoom.TabIndex = 1;
            this.cbRoom.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // cbStaff
            // 
            this.cbStaff.FormattingEnabled = true;
            this.cbStaff.Location = new System.Drawing.Point(132, 92);
            this.cbStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbStaff.Name = "cbStaff";
            this.cbStaff.Size = new System.Drawing.Size(273, 33);
            this.cbStaff.TabIndex = 2;
            this.cbStaff.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Staff";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customer Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date";
            // 
            // tbCustomerPhone
            // 
            this.tbCustomerPhone.Location = new System.Drawing.Point(585, 24);
            this.tbCustomerPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCustomerPhone.Name = "tbCustomerPhone";
            this.tbCustomerPhone.Size = new System.Drawing.Size(309, 31);
            this.tbCustomerPhone.TabIndex = 9;
            this.tbCustomerPhone.TextChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(585, 92);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(309, 31);
            this.dtpDate.TabIndex = 10;
            this.dtpDate.ValueChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // btHideDate
            // 
            this.btHideDate.Location = new System.Drawing.Point(545, 92);
            this.btHideDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btHideDate.Name = "btHideDate";
            this.btHideDate.Size = new System.Drawing.Size(32, 34);
            this.btHideDate.TabIndex = 12;
            this.btHideDate.Text = "X";
            this.btHideDate.UseVisualStyleBackColor = true;
            this.btHideDate.Click += new System.EventHandler(this.btHideDate_Click);
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.btDelete);
            this.gbDetail.Controls.Add(this.btEdit);
            this.gbDetail.Controls.Add(this.cbRoominDetails);
            this.gbDetail.Controls.Add(this.cbStaffinDetail);
            this.gbDetail.Controls.Add(this.dtpDateTo);
            this.gbDetail.Controls.Add(this.dtpDateFrom);
            this.gbDetail.Controls.Add(this.tbPrice);
            this.gbDetail.Controls.Add(this.tbCustomerPhoneinDetail);
            this.gbDetail.Controls.Add(this.tbCustomerName);
            this.gbDetail.Controls.Add(this.tbCustomerId);
            this.gbDetail.Controls.Add(this.label10);
            this.gbDetail.Controls.Add(this.label9);
            this.gbDetail.Controls.Add(this.label8);
            this.gbDetail.Controls.Add(this.label7);
            this.gbDetail.Controls.Add(this.label6);
            this.gbDetail.Controls.Add(this.label5);
            this.gbDetail.Controls.Add(this.label12);
            this.gbDetail.Controls.Add(this.label13);
            this.gbDetail.Location = new System.Drawing.Point(969, 162);
            this.gbDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDetail.Size = new System.Drawing.Size(568, 565);
            this.gbDetail.TabIndex = 13;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Details";
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(351, 485);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(118, 36);
            this.btDelete.TabIndex = 21;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(154, 485);
            this.btEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(118, 36);
            this.btEdit.TabIndex = 20;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // cbRoominDetails
            // 
            this.cbRoominDetails.FormattingEnabled = true;
            this.cbRoominDetails.Location = new System.Drawing.Point(212, 66);
            this.cbRoominDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRoominDetails.Name = "cbRoominDetails";
            this.cbRoominDetails.Size = new System.Drawing.Size(312, 33);
            this.cbRoominDetails.TabIndex = 19;
            // 
            // cbStaffinDetail
            // 
            this.cbStaffinDetail.FormattingEnabled = true;
            this.cbStaffinDetail.Location = new System.Drawing.Point(212, 115);
            this.cbStaffinDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbStaffinDetail.Name = "cbStaffinDetail";
            this.cbStaffinDetail.Size = new System.Drawing.Size(312, 33);
            this.cbStaffinDetail.TabIndex = 17;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Location = new System.Drawing.Point(212, 334);
            this.dtpDateTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(312, 31);
            this.dtpDateTo.TabIndex = 16;
            this.dtpDateTo.ValueChanged += new System.EventHandler(this.dtpDateFrom_ValueChanged);
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Location = new System.Drawing.Point(212, 292);
            this.dtpDateFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(312, 31);
            this.dtpDateFrom.TabIndex = 15;
            this.dtpDateFrom.ValueChanged += new System.EventHandler(this.dtpDateFrom_ValueChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(212, 384);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(312, 31);
            this.tbPrice.TabIndex = 14;
            // 
            // tbCustomerPhoneinDetail
            // 
            this.tbCustomerPhoneinDetail.Location = new System.Drawing.Point(212, 245);
            this.tbCustomerPhoneinDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCustomerPhoneinDetail.Name = "tbCustomerPhoneinDetail";
            this.tbCustomerPhoneinDetail.Size = new System.Drawing.Size(312, 31);
            this.tbCustomerPhoneinDetail.TabIndex = 13;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(212, 201);
            this.tbCustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(312, 31);
            this.tbCustomerName.TabIndex = 12;
            // 
            // tbCustomerId
            // 
            this.tbCustomerId.Location = new System.Drawing.Point(212, 160);
            this.tbCustomerId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCustomerId.Name = "tbCustomerId";
            this.tbCustomerId.Size = new System.Drawing.Size(312, 31);
            this.tbCustomerId.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 388);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 344);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Date To:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 299);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Date From:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Customer Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Customer Identify:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Staff Booking:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 211);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Customer Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 76);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Room:";
            // 
            // frmViewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1659, 896);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.btHideDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.tbCustomerPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStaff);
            this.Controls.Add(this.cbRoom);
            this.Controls.Add(this.dgvBooking);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmViewBooking";
            this.Text = "frmViewBooking";
            this.Load += new System.EventHandler(this.frmViewBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.ComboBox cbStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCustomerPhone;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btHideDate;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.ComboBox cbStaffinDetail;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbCustomerPhoneinDetail;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.TextBox tbCustomerId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbRoominDetails;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
    }
}