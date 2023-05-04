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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string use = "";
            
            
            string pass = "";

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("User Name must not empty");
                return;
            }
            else
            {
                use = textBox1.Text;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Pass Word must not empty");
                return;
            }
            else
            {
                pass = textBox2.Text;
            }

            using (var context = new PRN211_HMSContext())
            {
                List<Account> account = context.Accounts.ToList();
               // List<Account> accounts = context.Accounts.ToList();
                foreach (var acc in account)
                {
                    if (acc.Username == use && acc.Password == pass && acc.Roleid == 1)
                    {
                        this.Hide();
                        frmManage frmManage = new frmManage();
                        frmManage.ShowDialog();
                        this.Close();
                    }
                    if (acc.Username == use && acc.Password == pass && acc.Roleid == 2)
                    {
                        this.Hide();
                        frmHome frmHome = new frmHome();
                        frmHome.ShowDialog();
                        this.Close();
                    }
                    if (acc.Username == use && acc.Password == pass && acc.Roleid == 3)
                    {
                        this.Hide();
                        frmAdmin frmAdmin = new frmAdmin();
                        frmAdmin.ShowDialog();
                        this.Close();
                    }

                }

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeController homeController = new HomeController();
            homeController.ShowDialog();
            this.Close();


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
