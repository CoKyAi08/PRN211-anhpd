namespace SalesWinApp
{
    partial class frmOrders
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            txtOrderId = new System.Windows.Forms.TextBox();
            txtMemberId = new System.Windows.Forms.TextBox();
            dtOrder = new System.Windows.Forms.DateTimePicker();
            dtRequired = new System.Windows.Forms.DateTimePicker();
            dtShipped = new System.Windows.Forms.DateTimePicker();
            txtFreight = new System.Windows.Forms.TextBox();
            dgOrderList = new System.Windows.Forms.DataGridView();
            btnViewDetail = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            gbOrder = new System.Windows.Forms.GroupBox();
            gbOrderDetail = new System.Windows.Forms.GroupBox();
            dgOrderDetail = new System.Windows.Forms.DataGridView();
            DeleteDetail = new System.Windows.Forms.Button();
            btnUpdateDetail = new System.Windows.Forms.Button();
            btnAddDetail = new System.Windows.Forms.Button();
            txtDiscount = new System.Windows.Forms.TextBox();
            txtQuantity = new System.Windows.Forms.TextBox();
            txtUnitPrice = new System.Windows.Forms.TextBox();
            txtProductId = new System.Windows.Forms.TextBox();
            txtOrderDetailId = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgOrderList).BeginInit();
            gbOrder.SuspendLayout();
            gbOrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            label1.Location = new System.Drawing.Point(497, 9);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(288, 41);
            label1.TabIndex = 0;
            label1.Text = "Order Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(16, 39);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 21);
            label2.TabIndex = 1;
            label2.Text = "Order Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(16, 131);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(123, 21);
            label3.TabIndex = 2;
            label3.Text = "Required Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(289, 40);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(97, 21);
            label4.TabIndex = 3;
            label4.Text = "Member Id:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(16, 180);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(113, 21);
            label5.TabIndex = 4;
            label5.Text = "Shipper Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(16, 223);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(68, 21);
            label6.TabIndex = 5;
            label6.Text = "Freight:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(16, 83);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(97, 21);
            label7.TabIndex = 6;
            label7.Text = "Order Date:";
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new System.Drawing.Point(158, 41);
            txtOrderId.Margin = new System.Windows.Forms.Padding(2);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new System.Drawing.Size(106, 23);
            txtOrderId.TabIndex = 7;
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new System.Drawing.Point(396, 41);
            txtMemberId.Margin = new System.Windows.Forms.Padding(2);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new System.Drawing.Size(106, 23);
            txtMemberId.TabIndex = 8;
            // 
            // dtOrder
            // 
            dtOrder.Location = new System.Drawing.Point(158, 83);
            dtOrder.Margin = new System.Windows.Forms.Padding(2);
            dtOrder.Name = "dtOrder";
            dtOrder.Size = new System.Drawing.Size(343, 23);
            dtOrder.TabIndex = 9;
            // 
            // dtRequired
            // 
            dtRequired.Location = new System.Drawing.Point(158, 130);
            dtRequired.Margin = new System.Windows.Forms.Padding(2);
            dtRequired.Name = "dtRequired";
            dtRequired.Size = new System.Drawing.Size(343, 23);
            dtRequired.TabIndex = 10;
            // 
            // dtShipped
            // 
            dtShipped.Location = new System.Drawing.Point(158, 180);
            dtShipped.Margin = new System.Windows.Forms.Padding(2);
            dtShipped.Name = "dtShipped";
            dtShipped.Size = new System.Drawing.Size(343, 23);
            dtShipped.TabIndex = 11;
            // 
            // txtFreight
            // 
            txtFreight.Location = new System.Drawing.Point(158, 225);
            txtFreight.Margin = new System.Windows.Forms.Padding(2);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new System.Drawing.Size(106, 23);
            txtFreight.TabIndex = 12;
            // 
            // dgOrderList
            // 
            dgOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOrderList.Location = new System.Drawing.Point(16, 302);
            dgOrderList.Margin = new System.Windows.Forms.Padding(2);
            dgOrderList.Name = "dgOrderList";
            dgOrderList.RowHeadersWidth = 62;
            dgOrderList.RowTemplate.Height = 33;
            dgOrderList.Size = new System.Drawing.Size(586, 223);
            dgOrderList.TabIndex = 13;
            // 
            // btnViewDetail
            // 
            btnViewDetail.Location = new System.Drawing.Point(523, 260);
            btnViewDetail.Margin = new System.Windows.Forms.Padding(2);
            btnViewDetail.Name = "btnViewDetail";
            btnViewDetail.Size = new System.Drawing.Size(79, 20);
            btnViewDetail.TabIndex = 15;
            btnViewDetail.Text = "View Detail";
            btnViewDetail.UseVisualStyleBackColor = true;
            btnViewDetail.Click += btnViewDetail_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(289, 260);
            btnDelete.Margin = new System.Windows.Forms.Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(79, 20);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(300, 636);
            btnExit.Margin = new System.Windows.Forms.Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(79, 20);
            btnExit.TabIndex = 17;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(16, 260);
            btnAdd.Margin = new System.Windows.Forms.Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(79, 20);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // gbOrder
            // 
            gbOrder.Controls.Add(label2);
            gbOrder.Controls.Add(btnAdd);
            gbOrder.Controls.Add(dgOrderList);
            gbOrder.Controls.Add(btnDelete);
            gbOrder.Controls.Add(txtOrderId);
            gbOrder.Controls.Add(btnViewDetail);
            gbOrder.Controls.Add(txtMemberId);
            gbOrder.Controls.Add(label4);
            gbOrder.Controls.Add(label7);
            gbOrder.Controls.Add(label3);
            gbOrder.Controls.Add(label5);
            gbOrder.Controls.Add(txtFreight);
            gbOrder.Controls.Add(label6);
            gbOrder.Controls.Add(dtShipped);
            gbOrder.Controls.Add(dtOrder);
            gbOrder.Controls.Add(dtRequired);
            gbOrder.Location = new System.Drawing.Point(11, 55);
            gbOrder.Margin = new System.Windows.Forms.Padding(2);
            gbOrder.Name = "gbOrder";
            gbOrder.Padding = new System.Windows.Forms.Padding(2);
            gbOrder.Size = new System.Drawing.Size(619, 543);
            gbOrder.TabIndex = 19;
            gbOrder.TabStop = false;
            gbOrder.Text = "Order";
            // 
            // gbOrderDetail
            // 
            gbOrderDetail.Controls.Add(dgOrderDetail);
            gbOrderDetail.Controls.Add(DeleteDetail);
            gbOrderDetail.Controls.Add(btnUpdateDetail);
            gbOrderDetail.Controls.Add(btnAddDetail);
            gbOrderDetail.Controls.Add(txtDiscount);
            gbOrderDetail.Controls.Add(txtQuantity);
            gbOrderDetail.Controls.Add(txtUnitPrice);
            gbOrderDetail.Controls.Add(txtProductId);
            gbOrderDetail.Controls.Add(txtOrderDetailId);
            gbOrderDetail.Controls.Add(label12);
            gbOrderDetail.Controls.Add(label11);
            gbOrderDetail.Controls.Add(label10);
            gbOrderDetail.Controls.Add(label9);
            gbOrderDetail.Controls.Add(label8);
            gbOrderDetail.Location = new System.Drawing.Point(654, 55);
            gbOrderDetail.Margin = new System.Windows.Forms.Padding(2);
            gbOrderDetail.Name = "gbOrderDetail";
            gbOrderDetail.Padding = new System.Windows.Forms.Padding(2);
            gbOrderDetail.Size = new System.Drawing.Size(599, 543);
            gbOrderDetail.TabIndex = 20;
            gbOrderDetail.TabStop = false;
            gbOrderDetail.Text = "Order Detail";
            // 
            // dgOrderDetail
            // 
            dgOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOrderDetail.Location = new System.Drawing.Point(16, 302);
            dgOrderDetail.Margin = new System.Windows.Forms.Padding(2);
            dgOrderDetail.Name = "dgOrderDetail";
            dgOrderDetail.RowHeadersWidth = 62;
            dgOrderDetail.RowTemplate.Height = 33;
            dgOrderDetail.Size = new System.Drawing.Size(565, 223);
            dgOrderDetail.TabIndex = 17;
            // 
            // DeleteDetail
            // 
            DeleteDetail.Location = new System.Drawing.Point(477, 260);
            DeleteDetail.Margin = new System.Windows.Forms.Padding(2);
            DeleteDetail.Name = "DeleteDetail";
            DeleteDetail.Size = new System.Drawing.Size(104, 20);
            DeleteDetail.TabIndex = 16;
            DeleteDetail.Text = "Delete Detail";
            DeleteDetail.UseVisualStyleBackColor = true;
            DeleteDetail.Click += DeleteDetail_Click;
            // 
            // btnUpdateDetail
            // 
            btnUpdateDetail.Location = new System.Drawing.Point(218, 260);
            btnUpdateDetail.Margin = new System.Windows.Forms.Padding(2);
            btnUpdateDetail.Name = "btnUpdateDetail";
            btnUpdateDetail.Size = new System.Drawing.Size(106, 20);
            btnUpdateDetail.TabIndex = 15;
            btnUpdateDetail.Text = "Update Detail";
            btnUpdateDetail.UseVisualStyleBackColor = true;
            btnUpdateDetail.Click += btnUpdateDetail_Click;
            // 
            // btnAddDetail
            // 
            btnAddDetail.Location = new System.Drawing.Point(16, 260);
            btnAddDetail.Margin = new System.Windows.Forms.Padding(2);
            btnAddDetail.Name = "btnAddDetail";
            btnAddDetail.Size = new System.Drawing.Size(79, 20);
            btnAddDetail.TabIndex = 14;
            btnAddDetail.Text = "Add Detail";
            btnAddDetail.UseVisualStyleBackColor = true;
            btnAddDetail.Click += btnAddDetail_Click;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new System.Drawing.Point(165, 215);
            txtDiscount.Margin = new System.Windows.Forms.Padding(2);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new System.Drawing.Size(157, 23);
            txtDiscount.TabIndex = 13;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new System.Drawing.Point(165, 172);
            txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new System.Drawing.Size(157, 23);
            txtQuantity.TabIndex = 12;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new System.Drawing.Point(165, 122);
            txtUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(159, 23);
            txtUnitPrice.TabIndex = 11;
            // 
            // txtProductId
            // 
            txtProductId.Location = new System.Drawing.Point(165, 76);
            txtProductId.Margin = new System.Windows.Forms.Padding(2);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new System.Drawing.Size(159, 23);
            txtProductId.TabIndex = 10;
            // 
            // txtOrderDetailId
            // 
            txtOrderDetailId.Location = new System.Drawing.Point(165, 34);
            txtOrderDetailId.Margin = new System.Windows.Forms.Padding(2);
            txtOrderDetailId.Name = "txtOrderDetailId";
            txtOrderDetailId.Size = new System.Drawing.Size(159, 23);
            txtOrderDetailId.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(16, 215);
            label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(82, 21);
            label12.TabIndex = 6;
            label12.Text = "Discount:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(16, 170);
            label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(85, 21);
            label11.TabIndex = 5;
            label11.Text = "Quantity: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(16, 120);
            label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(89, 21);
            label10.TabIndex = 4;
            label10.Text = "Unit Price:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(16, 74);
            label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(93, 21);
            label9.TabIndex = 3;
            label9.Text = "Product Id:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(16, 32);
            label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(76, 21);
            label8.TabIndex = 2;
            label8.Text = "Order Id:";
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1264, 667);
            Controls.Add(gbOrderDetail);
            Controls.Add(gbOrder);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "frmOrders";
            Text = "frmOrders";
            Load += frmOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dgOrderList).EndInit();
            gbOrder.ResumeLayout(false);
            gbOrder.PerformLayout();
            gbOrderDetail.ResumeLayout(false);
            gbOrderDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgOrderDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.DateTimePicker dtOrder;
        private System.Windows.Forms.DateTimePicker dtRequired;
        private System.Windows.Forms.DateTimePicker dtShipped;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.DataGridView dgOrderList;
        private System.Windows.Forms.Button btnViewDetail;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.GroupBox gbOrderDetail;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtOrderDetailId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button DeleteDetail;
        private System.Windows.Forms.Button btnUpdateDetail;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.DataGridView dgOrderDetail;
    }
}