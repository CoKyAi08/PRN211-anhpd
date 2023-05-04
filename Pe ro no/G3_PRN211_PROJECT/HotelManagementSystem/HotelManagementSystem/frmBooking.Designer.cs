namespace HotelManagementSystem
{
    partial class frmBooking
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
            this.lbRoom = new System.Windows.Forms.ListBox();
            this.btViewBooking = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btBook = new System.Windows.Forms.Button();
            this.cbStaff = new System.Windows.Forms.ComboBox();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbCustomerPhone = new System.Windows.Forms.TextBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbCustomerId = new System.Windows.Forms.TextBox();
            this.tbRoomDetails = new System.Windows.Forms.TextBox();
            this.tbRoom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRoom
            // 
            this.lbRoom.FormattingEnabled = true;
            this.lbRoom.ItemHeight = 25;
            this.lbRoom.Location = new System.Drawing.Point(42, 106);
            this.lbRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(384, 504);
            this.lbRoom.TabIndex = 0;
            this.lbRoom.SelectedIndexChanged += new System.EventHandler(this.lbRoom_SelectedIndexChanged);
            // 
            // btViewBooking
            // 
            this.btViewBooking.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btViewBooking.Location = new System.Drawing.Point(908, 15);
            this.btViewBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btViewBooking.Name = "btViewBooking";
            this.btViewBooking.Size = new System.Drawing.Size(140, 42);
            this.btViewBooking.TabIndex = 1;
            this.btViewBooking.Text = "View Booking";
            this.btViewBooking.UseVisualStyleBackColor = false;
            this.btViewBooking.Click += new System.EventHandler(this.btViewBooking_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "List of room";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btBook);
            this.groupBox1.Controls.Add(this.cbStaff);
            this.groupBox1.Controls.Add(this.dtpDateTo);
            this.groupBox1.Controls.Add(this.dtpDateFrom);
            this.groupBox1.Controls.Add(this.tbPrice);
            this.groupBox1.Controls.Add(this.tbCustomerPhone);
            this.groupBox1.Controls.Add(this.tbCustomerName);
            this.groupBox1.Controls.Add(this.tbCustomerId);
            this.groupBox1.Controls.Add(this.tbRoomDetails);
            this.groupBox1.Controls.Add(this.tbRoom);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(472, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(568, 522);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // btBook
            // 
            this.btBook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btBook.Location = new System.Drawing.Point(212, 451);
            this.btBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btBook.Name = "btBook";
            this.btBook.Size = new System.Drawing.Size(118, 36);
            this.btBook.TabIndex = 18;
            this.btBook.Text = "Book";
            this.btBook.UseVisualStyleBackColor = false;
            this.btBook.Click += new System.EventHandler(this.btBook_Click);
            // 
            // cbStaff
            // 
            this.cbStaff.FormattingEnabled = true;
            this.cbStaff.Location = new System.Drawing.Point(212, 115);
            this.cbStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbStaff.Name = "cbStaff";
            this.cbStaff.Size = new System.Drawing.Size(312, 33);
            this.cbStaff.TabIndex = 17;
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
            // tbCustomerPhone
            // 
            this.tbCustomerPhone.Location = new System.Drawing.Point(212, 245);
            this.tbCustomerPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCustomerPhone.Name = "tbCustomerPhone";
            this.tbCustomerPhone.Size = new System.Drawing.Size(312, 31);
            this.tbCustomerPhone.TabIndex = 13;
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
            // tbRoomDetails
            // 
            this.tbRoomDetails.Location = new System.Drawing.Point(212, 74);
            this.tbRoomDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRoomDetails.Name = "tbRoomDetails";
            this.tbRoomDetails.ReadOnly = true;
            this.tbRoomDetails.Size = new System.Drawing.Size(312, 31);
            this.tbRoomDetails.TabIndex = 10;
            // 
            // tbRoom
            // 
            this.tbRoom.Location = new System.Drawing.Point(212, 32);
            this.tbRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRoom.Name = "tbRoom";
            this.tbRoom.ReadOnly = true;
            this.tbRoom.Size = new System.Drawing.Size(312, 31);
            this.tbRoom.TabIndex = 9;
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
            this.label5.Location = new System.Drawing.Point(8, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Staff Booking:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Room Deatails:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room:";
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 705);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btViewBooking);
            this.Controls.Add(this.lbRoom);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBooking";
            this.Text = "frmBooking";
            this.Load += new System.EventHandler(this.frmBooking_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbRoom;
        private System.Windows.Forms.Button btViewBooking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCustomerPhone;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.TextBox tbCustomerId;
        private System.Windows.Forms.TextBox tbRoomDetails;
        private System.Windows.Forms.TextBox tbRoom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStaff;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button btBook;
    }
}