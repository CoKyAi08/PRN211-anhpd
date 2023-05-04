using HotelManagementSystem.Logics;
using HotelManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class frmManageStaff : Form
    {
        List<staff> StaffList = new List<staff>();
        public frmManageStaff()
        {
            InitializeComponent();
        }

        private void frmManageStaff_Load(object sender, EventArgs e)
        {
            FormatDataGridView();
            LoadDGVStaff();
        }

        private void FormatDataGridView()
        {
            dgvStaff.AutoGenerateColumns = false;


            dgvStaff.Columns.Add("idcol", "StaffId");
            dgvStaff.Columns["idcol"].DataPropertyName = "StaffId";

            dgvStaff.Columns.Add("namecol", "FullName");
            dgvStaff.Columns["namecol"].DataPropertyName = "FullName";

            dgvStaff.Columns.Add("dobcol", "DOB");
            dgvStaff.Columns["dobcol"].DataPropertyName = "DOB";

            dgvStaff.Columns.Add("phonecol", "PhoneNumber");
            dgvStaff.Columns["phonecol"].DataPropertyName = "PhoneNumber";

            dgvStaff.Columns.Add("citycol", "City");
            dgvStaff.Columns["citycol"].DataPropertyName = "City";

            DataGridViewButtonColumn editcol = new DataGridViewButtonColumn();
            editcol.Name = "editcol";
            editcol.HeaderText = "Action";
            editcol.Text = "Edit Staff";
            editcol.UseColumnTextForButtonValue = true;
            dgvStaff.Columns.Add(editcol);

            DataGridViewLinkColumn delcol = new DataGridViewLinkColumn();
            delcol.Name = "delcol";
            delcol.HeaderText = "Action";
            delcol.Text = "Delete Staff";
            delcol.UseColumnTextForLinkValue = true;
            dgvStaff.Columns.Add(delcol);
        }

        private void LoadDGVStaff()
        {
            StaffList = (new StaffLogic()).GetAllStaffs();
            dgvStaff.DataSource = StaffList;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string subname = tbSearch.Text;
            dgvStaff.DataSource = (new StaffLogic()).GetStaffByName(subname);
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStaff.Columns[e.ColumnIndex].Name.Equals("editcol"))
            {
                staff CurStaff = StaffList[e.RowIndex];

                frmEditStaffcs editform = new frmEditStaffcs(CurStaff);
                editform.FormClosed += frmEditForm_Close;
                editform.Show();

            }
            if (dgvStaff.Columns[e.ColumnIndex].Name.Equals("delcol"))
            {
                staff CurStaff = StaffList[e.RowIndex];

                DialogResult result = MessageBox.Show($"Are you sure to delete?",
                    "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    (new StaffLogic()).DeleteBooking(CurStaff);
                    LoadDGVStaff();
                }

            }
        }

        private void frmEditForm_Close(object sender, EventArgs e)
        {
            LoadDGVStaff();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmAddStaff addform = new frmAddStaff();
            addform.FormClosed += frmEditForm_Close;
            addform.Show();
        }
    }
}
