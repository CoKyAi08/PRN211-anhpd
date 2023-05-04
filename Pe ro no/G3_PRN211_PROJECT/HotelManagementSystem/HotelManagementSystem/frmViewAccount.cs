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
    public partial class frmViewAccount : Form
    {
        public frmViewAccount()
        {
            InitializeComponent();
        }
        private string rolen;

        private void frmViewAccount_Load(object sender, EventArgs e)
        {
            using (var context = new PRN211_HMSContext())
            {

                List<Account> accounts = context.Accounts.ToList();
                foreach (var account in accounts)
                {
                        if (account.Roleid == 1)
                        {
                            rolen = "Manager";
                        }
                        if (account.Roleid == 2)
                        {
                            rolen = "Staff";
                        }
                        if (account.Roleid == 3)
                        {
                            rolen = "Admin";
                        }
                    dataGridView1.Rows.Add(account.Username,account.Password,account.Address,account.Displayname,account.Phone, rolen);

                }

            }


        }
    }
}
