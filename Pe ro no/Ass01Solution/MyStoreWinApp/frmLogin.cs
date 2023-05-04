using BusinessObject;
using DataAccess.Repository;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Email = textBox1.Text;
            string Password = textBox2.Text;
            MemberObject loginMember = memberRepository.Login(Email, Password);
            if (loginMember != null)
            {
                MessageBox.Show("Login successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string memberName = loginMember.MemberName;
                frmMemberManagement frmMemberManagement = null;
                if (memberName.Equals("Admin"))
                {
                    frmMemberManagement = new frmMemberManagement
                    {
                        loginMember = loginMember,
                    };
                    frmMemberManagement.Closed += (s, args) => this.Close();
                    this.Hide();
                    frmMemberManagement.Show();
                }
                else
                {
                    frmMemberAdd frmMemberAdd = new frmMemberAdd
                    {
                        Text = "Member Details",
                        memberInfo = loginMember,
                        InsertOrUpdate = false,
                        memberRepository = memberRepository
                    };
                    frmMemberAdd.Closed += (s, args) => this.Close();
                    this.Hide();
                    frmMemberAdd.Show();
                }
            }
            else
            {
                if (MessageBox.Show("Login failed!!", "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}