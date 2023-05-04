namespace HotelManagementSystem
{
    partial class frmUpdatePrice
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
            this.btUpdate = new System.Windows.Forms.Button();
            this.btReturnToList1 = new System.Windows.Forms.Button();
            this.btAddtoList2 = new System.Windows.Forms.Button();
            this.lsSelectedRooms = new System.Windows.Forms.ListBox();
            this.lsAllRooms = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btViewRoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(649, 534);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(94, 29);
            this.btUpdate.TabIndex = 15;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btReturnToList1
            // 
            this.btReturnToList1.Location = new System.Drawing.Point(344, 256);
            this.btReturnToList1.Name = "btReturnToList1";
            this.btReturnToList1.Size = new System.Drawing.Size(94, 29);
            this.btReturnToList1.TabIndex = 14;
            this.btReturnToList1.Text = "<<<";
            this.btReturnToList1.UseVisualStyleBackColor = true;
            this.btReturnToList1.Click += new System.EventHandler(this.btReturnToList1_Click);
            // 
            // btAddtoList2
            // 
            this.btAddtoList2.Location = new System.Drawing.Point(344, 209);
            this.btAddtoList2.Name = "btAddtoList2";
            this.btAddtoList2.Size = new System.Drawing.Size(94, 29);
            this.btAddtoList2.TabIndex = 13;
            this.btAddtoList2.Text = ">>>";
            this.btAddtoList2.UseVisualStyleBackColor = true;
            this.btAddtoList2.Click += new System.EventHandler(this.btAddtoList2_Click);
            // 
            // lsSelectedRooms
            // 
            this.lsSelectedRooms.FormattingEnabled = true;
            this.lsSelectedRooms.ItemHeight = 20;
            this.lsSelectedRooms.Location = new System.Drawing.Point(476, 116);
            this.lsSelectedRooms.Name = "lsSelectedRooms";
            this.lsSelectedRooms.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsSelectedRooms.Size = new System.Drawing.Size(267, 304);
            this.lsSelectedRooms.TabIndex = 12;
            // 
            // lsAllRooms
            // 
            this.lsAllRooms.FormattingEnabled = true;
            this.lsAllRooms.ItemHeight = 20;
            this.lsAllRooms.Location = new System.Drawing.Point(41, 116);
            this.lsAllRooms.Name = "lsAllRooms";
            this.lsAllRooms.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsAllRooms.Size = new System.Drawing.Size(267, 304);
            this.lsAllRooms.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "Update Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "New Price";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(619, 483);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown1.TabIndex = 19;
            // 
            // btViewRoom
            // 
            this.btViewRoom.Location = new System.Drawing.Point(41, 534);
            this.btViewRoom.Name = "btViewRoom";
            this.btViewRoom.Size = new System.Drawing.Size(94, 29);
            this.btViewRoom.TabIndex = 20;
            this.btViewRoom.Text = "View Room";
            this.btViewRoom.UseVisualStyleBackColor = true;
            this.btViewRoom.Click += new System.EventHandler(this.btViewRoom_Click);
            // 
            // frmUpdatePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.btViewRoom);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btReturnToList1);
            this.Controls.Add(this.btAddtoList2);
            this.Controls.Add(this.lsSelectedRooms);
            this.Controls.Add(this.lsAllRooms);
            this.Name = "frmUpdatePrice";
            this.Text = "frmUpdatePrice";
            this.Load += new System.EventHandler(this.frmUpdatePrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btReturnToList1;
        private System.Windows.Forms.Button btAddtoList2;
        private System.Windows.Forms.ListBox lsSelectedRooms;
        private System.Windows.Forms.ListBox lsAllRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btViewRoom;
    }
}