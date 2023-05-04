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
    public partial class frmManage : Form
    {
        public frmManage()
        {
            InitializeComponent();
        }

        private void btManage_Click(object sender, EventArgs e)
        {
            frmManageStaff frmManageStaff = new frmManageStaff();
            frmManageStaff.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmManage_Load(object sender, EventArgs e)
        {
         
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            frmUpdatePrice frmUpdatePrice = new frmUpdatePrice();
            frmUpdatePrice.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}
