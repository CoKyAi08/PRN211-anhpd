using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolMember_Click(object sender, EventArgs e)
        {/*
            openWorkForm(new frmMembers());*/
            frmMembers frmMembers = new frmMembers();
            frmMembers.ShowDialog();
        }

        /*private void openWorkForm(Form workForm)
        {
            workForm.Show();
        }*/

        private void toolProduct_Click(object sender, EventArgs e)
        {
            /*openWorkForm(new frmProducts());*/
            frmProducts frmProducts = new frmProducts();
            frmProducts.ShowDialog();
        }

        private void toolOrder_Click(object sender, EventArgs e)
        {
            /*openWorkForm(new frmOrders());*/
            frmOrders frmOrders = new frmOrders();
            frmOrders.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }


    }
}
