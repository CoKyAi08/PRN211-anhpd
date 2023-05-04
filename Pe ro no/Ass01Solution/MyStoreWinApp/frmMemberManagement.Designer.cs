
namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            this.lbMemberID = new System.Windows.Forms.Label();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grSearch = new System.Windows.Forms.GroupBox();
            this.radioByName = new System.Windows.Forms.RadioButton();
            this.radioByID = new System.Windows.Forms.RadioButton();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.grFilter = new System.Windows.Forms.GroupBox();
            this.cboSearchCity = new System.Windows.Forms.ComboBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.lbSearchCity = new System.Windows.Forms.Label();
            this.lbSearchCountry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.grSearch.SuspendLayout();
            this.grFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(37, 32);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(80, 20);
            this.lbMemberID.TabIndex = 0;
            this.lbMemberID.Text = "MemberID";
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Location = new System.Drawing.Point(37, 91);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(109, 20);
            this.lbMemberName.TabIndex = 1;
            this.lbMemberName.Text = "Member Name";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(37, 148);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 20);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(37, 209);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 20);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(37, 269);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(34, 20);
            this.lbCity.TabIndex = 4;
            this.lbCity.Text = "City";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(37, 339);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(60, 20);
            this.lbCountry.TabIndex = 5;
            this.lbCountry.Text = "Country";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(168, 32);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(167, 27);
            this.txtMemberID.TabIndex = 6;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(168, 91);
            this.txtMemberName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(167, 27);
            this.txtMemberName.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(168, 148);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(167, 27);
            this.txtEmail.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(168, 209);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '.';
            this.txtPassword.Size = new System.Drawing.Size(167, 27);
            this.txtPassword.TabIndex = 9;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(168, 269);
            this.txtCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(167, 27);
            this.txtCity.TabIndex = 10;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(168, 339);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(167, 27);
            this.txtCountry.TabIndex = 11;
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(37, 448);
            this.dgvMemberList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.RowHeadersWidth = 51;
            this.dgvMemberList.RowTemplate.Height = 25;
            this.dgvMemberList.Size = new System.Drawing.Size(822, 248);
            this.dgvMemberList.TabIndex = 12;
            this.dgvMemberList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberList_CellContentClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(37, 385);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 31);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "&View Member";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(434, 385);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(86, 31);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "&Sign Up";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(773, 385);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 31);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grSearch
            // 
            this.grSearch.Controls.Add(this.radioByName);
            this.grSearch.Controls.Add(this.radioByID);
            this.grSearch.Controls.Add(this.txtSearchValue);
            this.grSearch.Controls.Add(this.btnSearch);
            this.grSearch.Controls.Add(this.lbSearch);
            this.grSearch.Location = new System.Drawing.Point(520, 32);
            this.grSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grSearch.Name = "grSearch";
            this.grSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grSearch.Size = new System.Drawing.Size(339, 137);
            this.grSearch.TabIndex = 16;
            this.grSearch.TabStop = false;
            this.grSearch.Text = "Search Member";
            this.grSearch.Enter += new System.EventHandler(this.grSearch_Enter);
            // 
            // radioByName
            // 
            this.radioByName.AutoSize = true;
            this.radioByName.Location = new System.Drawing.Point(143, 83);
            this.radioByName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioByName.Name = "radioByName";
            this.radioByName.Size = new System.Drawing.Size(70, 24);
            this.radioByName.TabIndex = 4;
            this.radioByName.TabStop = true;
            this.radioByName.Text = "Name";
            this.radioByName.UseVisualStyleBackColor = true;
            // 
            // radioByID
            // 
            this.radioByID.AutoSize = true;
            this.radioByID.Location = new System.Drawing.Point(80, 83);
            this.radioByID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioByID.Name = "radioByID";
            this.radioByID.Size = new System.Drawing.Size(45, 24);
            this.radioByID.TabIndex = 3;
            this.radioByID.TabStop = true;
            this.radioByID.Text = "ID";
            this.radioByID.UseVisualStyleBackColor = true;
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(7, 29);
            this.txtSearchValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(201, 27);
            this.txtSearchValue.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(235, 29);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 31);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(7, 83);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(72, 20);
            this.lbSearch.TabIndex = 0;
            this.lbSearch.Text = "SearchBy:";
            // 
            // grFilter
            // 
            this.grFilter.Controls.Add(this.cboSearchCity);
            this.grFilter.Controls.Add(this.cboCountry);
            this.grFilter.Controls.Add(this.lbSearchCity);
            this.grFilter.Controls.Add(this.lbSearchCountry);
            this.grFilter.Location = new System.Drawing.Point(520, 216);
            this.grFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grFilter.Name = "grFilter";
            this.grFilter.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grFilter.Size = new System.Drawing.Size(339, 143);
            this.grFilter.TabIndex = 17;
            this.grFilter.TabStop = false;
            this.grFilter.Text = "FilterBy";
            // 
            // cboSearchCity
            // 
            this.cboSearchCity.FormattingEnabled = true;
            this.cboSearchCity.Location = new System.Drawing.Point(103, 39);
            this.cboSearchCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSearchCity.Name = "cboSearchCity";
            this.cboSearchCity.Size = new System.Drawing.Size(219, 28);
            this.cboSearchCity.TabIndex = 3;
            this.cboSearchCity.SelectedIndexChanged += new System.EventHandler(this.cboSearchCity_SelectedIndexChanged);
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(103, 95);
            this.cboCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(218, 28);
            this.cboCountry.TabIndex = 2;
            this.cboCountry.SelectedIndexChanged += new System.EventHandler(this.cboCountry_SelectedIndexChanged);
            // 
            // lbSearchCity
            // 
            this.lbSearchCity.AutoSize = true;
            this.lbSearchCity.Location = new System.Drawing.Point(7, 43);
            this.lbSearchCity.Name = "lbSearchCity";
            this.lbSearchCity.Size = new System.Drawing.Size(34, 20);
            this.lbSearchCity.TabIndex = 1;
            this.lbSearchCity.Text = "City";
            // 
            // lbSearchCountry
            // 
            this.lbSearchCountry.AutoSize = true;
            this.lbSearchCountry.Location = new System.Drawing.Point(7, 99);
            this.lbSearchCountry.Name = "lbSearchCountry";
            this.lbSearchCountry.Size = new System.Drawing.Size(60, 20);
            this.lbSearchCountry.TabIndex = 0;
            this.lbSearchCountry.Text = "Country";
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 729);
            this.Controls.Add(this.grFilter);
            this.Controls.Add(this.grSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvMemberList);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbMemberName);
            this.Controls.Add(this.lbMemberID);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMemberManagement";
            this.Text = "frmMemberManagement";
            this.Load += new System.EventHandler(this.frmMemberManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.grSearch.ResumeLayout(false);
            this.grSearch.PerformLayout();
            this.grFilter.ResumeLayout(false);
            this.grFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbMemberID;
        private Label lbMemberName;
        private Label lbEmail;
        private Label lbPassword;
        private Label lbCity;
        private Label lbCountry;
        private TextBox txtMemberID;
        private TextBox txtMemberName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtCity;
        private TextBox txtCountry;
        private DataGridView dgvMemberList;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private GroupBox grSearch;
        private TextBox txtSearchValue;
        private Button btnSearch;
        private Label lbSearch;
        private GroupBox grFilter;
        private RadioButton radioByName;
        private RadioButton radioByID;
        private ComboBox cboSearchCity;
        private ComboBox cboCountry;
        private Label lbSearchCity;
        private Label lbSearchCountry;
    }
}