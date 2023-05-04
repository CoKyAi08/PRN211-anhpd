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
    public partial class frmAddAccount : Form
    {
        public frmAddAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (PRN211_HMSContext context = new PRN211_HMSContext())
            {
                Account acc = new Account();

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("UserName must not empty");
                    return;
                }
                else
                {
                    acc.Username = textBox1.Text;
                }

                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Password must not empty");
                    return;
                }
                else
                {
                    acc.Password = textBox2.Text;
                }
                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("Address must not empty");
                    return;
                }
                else
                {
                    acc.Address = textBox3.Text;
                }


                if (!Regex.IsMatch(textBox4.Text, "[0-9]{10}"))
                {
                    MessageBox.Show("Phone must be 10 digits");
                    return;
                }
                else
                {
                    acc.Phone = textBox4.Text;
                }

                if (string.IsNullOrEmpty(textBox5.Text))
                {
                    MessageBox.Show("Display Name must not empty");
                    return;
                }
                else
                {
                    acc.Displayname = textBox5.Text;
                }
                int combo = comboBox1.SelectedIndex + 1;

                acc.Roleid = combo;

                context.Accounts.Add(acc);
                context.SaveChanges();
                MessageBox.Show("Add Successfully!");
            }

        }

        private void frmAddAccount_Load(object sender, EventArgs e)
        {
            using (var context = new PRN211_HMSContext())
            {
                List<Role> roles = context.Roles.ToList();
                comboBox1.DisplayMember = "rolename";
                comboBox1.ValueMember = "rolename";
                comboBox1.DataSource = roles;
            }


        }
    }
}
