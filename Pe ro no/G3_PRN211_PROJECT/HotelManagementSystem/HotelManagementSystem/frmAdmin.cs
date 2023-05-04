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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {       
            frmAddAccount frmAddAccount = new frmAddAccount();
            frmAddAccount.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmViewAccount frmViewAccount = new frmViewAccount();
            frmViewAccount.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
