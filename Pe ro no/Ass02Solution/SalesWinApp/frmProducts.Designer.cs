namespace SalesWinApp
{
    partial class frmProducts
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
            txtProductId = new System.Windows.Forms.TextBox();
            txtCategoryId = new System.Windows.Forms.TextBox();
            txtProductName = new System.Windows.Forms.TextBox();
            txtWeight = new System.Windows.Forms.TextBox();
            txtUnitPrice = new System.Windows.Forms.TextBox();
            txtUnitInStock = new System.Windows.Forms.TextBox();
            dgProductList = new System.Windows.Forms.DataGridView();
            btnSearch = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            gbSearch = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgProductList).BeginInit();
            gbSearch.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            label1.Location = new System.Drawing.Point(289, 9);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(319, 41);
            label1.TabIndex = 0;
            label1.Text = "Product Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(33, 86);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(93, 21);
            label2.TabIndex = 1;
            label2.Text = "Product Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(289, 86);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(103, 21);
            label3.TabIndex = 2;
            label3.Text = "Category Id:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(33, 196);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(70, 21);
            label4.TabIndex = 3;
            label4.Text = "Weight:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(33, 144);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(124, 21);
            label5.TabIndex = 4;
            label5.Text = "Product Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(33, 251);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(85, 21);
            label6.TabIndex = 5;
            label6.Text = "UnitPrice:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(289, 255);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(113, 21);
            label7.TabIndex = 6;
            label7.Text = "Unit In Stock:";
            // 
            // txtProductId
            // 
            txtProductId.Location = new System.Drawing.Point(170, 88);
            txtProductId.Margin = new System.Windows.Forms.Padding(2);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new System.Drawing.Size(106, 23);
            txtProductId.TabIndex = 7;
            txtProductId.Enter += txtProductId_Enter;
            txtProductId.KeyPress += txtProductId_KeyPress;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new System.Drawing.Point(424, 86);
            txtCategoryId.Margin = new System.Windows.Forms.Padding(2);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new System.Drawing.Size(106, 23);
            txtCategoryId.TabIndex = 8;
            // 
            // txtProductName
            // 
            txtProductName.Location = new System.Drawing.Point(170, 146);
            txtProductName.Margin = new System.Windows.Forms.Padding(2);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new System.Drawing.Size(232, 23);
            txtProductName.TabIndex = 9;
            // 
            // txtWeight
            // 
            txtWeight.Location = new System.Drawing.Point(170, 196);
            txtWeight.Margin = new System.Windows.Forms.Padding(2);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new System.Drawing.Size(232, 23);
            txtWeight.TabIndex = 10;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new System.Drawing.Point(170, 254);
            txtUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(106, 23);
            txtUnitPrice.TabIndex = 11;
            // 
            // txtUnitInStock
            // 
            txtUnitInStock.Location = new System.Drawing.Point(424, 253);
            txtUnitInStock.Margin = new System.Windows.Forms.Padding(2);
            txtUnitInStock.Name = "txtUnitInStock";
            txtUnitInStock.Size = new System.Drawing.Size(106, 23);
            txtUnitInStock.TabIndex = 12;
            // 
            // dgProductList
            // 
            dgProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductList.Location = new System.Drawing.Point(33, 320);
            dgProductList.Margin = new System.Windows.Forms.Padding(2);
            dgProductList.Name = "dgProductList";
            dgProductList.RowHeadersWidth = 62;
            dgProductList.RowTemplate.Height = 33;
            dgProductList.Size = new System.Drawing.Size(793, 218);
            dgProductList.TabIndex = 13;
            dgProductList.CellClick += dgProductList_CellClick;
            dgProductList.CellContentClick += dgProductList_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(113, 91);
            btnSearch.Margin = new System.Windows.Forms.Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(79, 20);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(33, 288);
            btnAdd.Margin = new System.Windows.Forms.Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(79, 20);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(396, 288);
            btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(79, 20);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(747, 288);
            btnDelete.Margin = new System.Windows.Forms.Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(79, 20);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(396, 555);
            btnClose.Margin = new System.Windows.Forms.Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(79, 20);
            btnClose.TabIndex = 18;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(0, 40);
            label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(81, 21);
            label8.TabIndex = 19;
            label8.Text = "Keyword:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(113, 40);
            txtSearch.Margin = new System.Windows.Forms.Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(106, 23);
            txtSearch.TabIndex = 20;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(label8);
            gbSearch.Controls.Add(txtSearch);
            gbSearch.Controls.Add(btnSearch);
            gbSearch.Location = new System.Drawing.Point(571, 86);
            gbSearch.Margin = new System.Windows.Forms.Padding(2);
            gbSearch.Name = "gbSearch";
            gbSearch.Padding = new System.Windows.Forms.Padding(2);
            gbSearch.Size = new System.Drawing.Size(255, 133);
            gbSearch.TabIndex = 21;
            gbSearch.TabStop = false;
            gbSearch.Text = "Search";
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(860, 596);
            Controls.Add(gbSearch);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgProductList);
            Controls.Add(txtUnitInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtWeight);
            Controls.Add(txtProductName);
            Controls.Add(txtCategoryId);
            Controls.Add(txtProductId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "frmProducts";
            Text = "frmProducts";
            Load += frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgProductList).EndInit();
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
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
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtUnitInStock;
        private System.Windows.Forms.DataGridView dgProductList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox gbSearch;
    }
}