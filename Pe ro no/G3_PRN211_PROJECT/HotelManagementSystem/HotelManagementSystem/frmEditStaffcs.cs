using HotelManagementSystem.Logics;
using HotelManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class frmEditStaffcs : Form
    {
        public staff CurStaff { get; set; }
        public frmEditStaffcs(staff Staff)
        {
            CurStaff = Staff;
            InitializeComponent();
        }

        private void frmEditStaffcs_Load(object sender, EventArgs e)
        {
            tbID.Text = CurStaff.StaffId+"";
            tbFullName.Text = CurStaff.FullName;
            dtpDob.Value = (DateTime)CurStaff.Dob;
            tbPhone.Text = CurStaff.PhoneNumber;
            tbCity.Text = CurStaff.City;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            staff Staff = new staff();

            Staff.StaffId = Convert.ToInt32(tbID.Text);

            if (string.IsNullOrEmpty(tbFullName.Text))
            {
                MessageBox.Show("Name must not empty");
                return;
            }
            else
            {
                Staff.FullName = tbFullName.Text;
            }

            if (!Regex.IsMatch(tbPhone.Text, "[0-9]{10,11}"))
            {
                MessageBox.Show("Phone must be 10-11 digits");
                return;
            }
            else
            {
                Staff.PhoneNumber = tbPhone.Text;
            }

            Staff.Dob = dtpDob.Value;

            if (string.IsNullOrEmpty(tbCity.Text))
            {
                MessageBox.Show("City must not empty");
                return;
            }
            else
            {
                Staff.City = tbCity.Text;
            }

            (new StaffLogic()).EditStaff(Staff);
            MessageBox.Show("Edit Successfully!");
            
            this.Close();
        }
    }
}
