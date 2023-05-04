using BusinessObject;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
namespace SalesWinApp
{
    public partial class frmMembers : Form
    {
        public frmMembers()
        {
            InitializeComponent();
            connectDB();
        }
        SqlConnection cnn = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand cmd = new SqlCommand();
        private void connectDB()
        {
            try
            {
                string strCnn = getConnectionString();
                cnn = new SqlConnection(strCnn);
                cnn.Open();
                // MessageBox.Show("Connect succesfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Connect error: " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }
        private string getConnectionString()
        {
            string connectionstring;

            IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
            connectionstring = config["ConnectionStrings:Assignment_02_PRN"];
            return connectionstring;
        }



        private void frmMembers_Load(object sender, EventArgs e)
        {
            loadMemberList();
        }

        private void loadMemberList()
        {
            try
            {
                string strSelect = "select * from Member";
                da = new SqlDataAdapter(strSelect, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgMemberList.DataSource = dt;


            }
            catch (Exception ex)
            {

                MessageBox.Show("loadMember error: " + ex.Message);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (txtMemberId.TextLength == 0 || txtEmail.TextLength == 0 || txtCountry.TextLength == 0 ||
                txtCompanyName.TextLength == 0 || txtCity.TextLength == 0 || txtPassword.TextLength == 0)
            {
                MessageBox.Show("Please enter full field information");
            }
            else
            {
                string strInsert = @"INSERT INTO [Assignment_02_PRN].[dbo].[Member]
                            ([MemberId],[Email],[CompanyName],[City],[Country],[Password])
                            VALUES(@id, @email, @companyName, @city, @country, @password)";
                SqlCommand cmd = new SqlCommand(strInsert, cnn);
                cmd.Parameters.AddWithValue("@id", txtMemberId.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@companyName", txtCompanyName.Text);
                cmd.Parameters.AddWithValue("@city", txtCity.Text);
                cmd.Parameters.AddWithValue("@country", txtCountry.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable tb = new DataTable();
                try
                {
                    cnn.Open();
                    da.Fill(ds, "Member");
                    cmd = new SqlCommand("select * from Member", cnn);
                    tb.Load(cmd.ExecuteReader());
                    dgMemberList.DataSource = tb;

                    MessageBox.Show("Add sucessfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Add erorr: " + ex.Message);
                }
                finally
                {
                    cnn.Close();
                    //connectDB();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMemberId.TextLength == 0 || txtEmail.TextLength == 0 || txtCountry.TextLength == 0 ||
                txtCompanyName.TextLength == 0 || txtCity.TextLength == 0 || txtPassword.TextLength == 0)
            {
                MessageBox.Show("Please enter full field information");
            }
            else
            {
                string strInsert = @"UPDATE Member set Email =@email,CompanyName=@companyName,City=@city,Country=@country,Password=@password where MemberId=@id";
                SqlCommand cmd = new SqlCommand(strInsert, cnn);
                cmd.Parameters.AddWithValue("@id", txtMemberId.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@companyName", txtCompanyName.Text);
                cmd.Parameters.AddWithValue("@city", txtCity.Text);
                cmd.Parameters.AddWithValue("@country", txtCountry.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable tb = new DataTable();
                try
                {
                    cnn.Open();
                    da.Fill(ds, "Member");
                    cmd = new SqlCommand("select * from Member", cnn);
                    tb.Load(cmd.ExecuteReader());
                    dgMemberList.DataSource = tb;

                    MessageBox.Show("Update sucessfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update erorr: " + ex.Message);
                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //finished = false;
            if (MessageBox.Show(this, "Are you want to delete?", "Alert", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            try
            {
                if (txtMemberId.TextLength == 0 || txtEmail.TextLength == 0 || txtCountry.TextLength == 0 ||
                txtCompanyName.TextLength == 0 || txtCity.TextLength == 0 || txtPassword.TextLength == 0)
                {
                    MessageBox.Show("Please choose member");
                    return;
                }
                string strDelete = "delete from Member where MemberId= @id";
                SqlCommand cmd = new SqlCommand(strDelete, cnn);
                cmd.Parameters.AddWithValue("@id", txtMemberId.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable tb = new DataTable();
                cnn.Open();
                da.Fill(ds, "Member");
                cmd = new SqlCommand("select * from Member", cnn);
                tb.Load(cmd.ExecuteReader());
                dgMemberList.DataSource = tb;
                MessageBox.Show("Delete sucessfully");
                loadMemberList();
                txtMemberId.Text = "";
                txtEmail.Text = "";
                txtCity.Text = "";
                txtCompanyName.Text = "";
                txtCountry.Text = "";
                txtPassword.Text = "";


            }
            catch (Exception ex)
            {

                MessageBox.Show("Delete error: " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void dgMemberList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMemberId.Text = dgMemberList.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtEmail.Text = dgMemberList.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtCompanyName.Text = dgMemberList.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtCity.Text = dgMemberList.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtCountry.Text = dgMemberList.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtPassword.Text = dgMemberList.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
