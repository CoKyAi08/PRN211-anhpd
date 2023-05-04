namespace SalesWinApp
{
    partial class frmMain
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            toolMember = new System.Windows.Forms.ToolStripMenuItem();
            toolProduct = new System.Windows.Forms.ToolStripMenuItem();
            toolOrder = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolMember, toolProduct, toolOrder });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            menuStrip1.Size = new System.Drawing.Size(560, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolMember
            // 
            toolMember.Name = "toolMember";
            toolMember.Size = new System.Drawing.Size(64, 22);
            toolMember.Text = "Member";
            toolMember.Click += toolMember_Click;
            // 
            // toolProduct
            // 
            toolProduct.Name = "toolProduct";
            toolProduct.Size = new System.Drawing.Size(61, 22);
            toolProduct.Text = "Product";
            toolProduct.Click += toolProduct_Click;
            // 
            // toolOrder
            // 
            toolOrder.Name = "toolOrder";
            toolOrder.Size = new System.Drawing.Size(49, 22);
            toolOrder.Text = "Order";
            toolOrder.Click += toolOrder_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(560, 270);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(1);
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolMember;
        private System.Windows.Forms.ToolStripMenuItem toolProduct;
        private System.Windows.Forms.ToolStripMenuItem toolOrder;
    }
}