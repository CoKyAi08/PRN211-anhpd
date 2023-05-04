using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberAdd : Form
    {
        public bool InsertOrUpdate { get; set; }
        public IMemberRepository memberRepository { get; set; }
        public MemberObject memberInfo { get; set; }

        public frmMemberAdd()
        {
            InitializeComponent();
        }

        private void frmMemberAdd_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate) // Insert
            {
                btnAdd.Visible = true;
                button1.Visible = false;

            }
            else
            {
                btnAdd.Visible = false;
                button1.Visible = true;
                textBox1.Enabled = false;

                textBox1.Text = memberInfo.MemberID.ToString();
                textBox2.Text = memberInfo.MemberName;
                textBox3.Text = memberInfo.Email;
                textBox4.Text = memberInfo.Password;
                textBox5.Text = memberInfo.Password;
                textBox6.Text = memberInfo.City;
                textBox7.Text = memberInfo.Country;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                MemberObject member = new MemberObject
                {
                    MemberID = int.Parse(textBox1.Text),
                    MemberName = textBox2.Text,
                    Email = textBox3.Text,
                    Password = textBox4.Text,
                    City = textBox6.Text,
                    Country = textBox7.Text
                };
                memberRepository.AddMember(member);
                MessageBox.Show("Add successfully!!", "Add new member", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add new member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Application.Exit();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MemberObject member = new MemberObject
                {
                    MemberID = memberInfo.MemberID,
                    MemberName = textBox2.Text,
                    Email = textBox3.Text,
                    Password = textBox4.Text,
                    City = textBox6.Text,
                    Country = textBox7.Text
                };
                memberRepository.UpdateMember(member);
                MessageBox.Show("Update successfully!!", "Update member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Text = member.MemberName;
                textBox3.Text = member.Email;
                textBox4.Text = member.Password;
                textBox5.Text = member.Password;
                textBox6.Text = member.City;
                textBox7.Text = member.Country;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
