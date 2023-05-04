using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProducts : Form
    {
        public frmProducts()
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


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProductId.TextLength == 0 || txtCategoryId.TextLength == 0 || txtProductName.TextLength == 0 ||
                txtUnitInStock.TextLength == 0 || txtUnitPrice.TextLength == 0 || txtWeight.TextLength == 0)
            {
                MessageBox.Show("Please enter full field information");
            }
            else
            {

                for (int i = 0; i < dgProductList.Rows.Count; i++)
                {
                    if (dgProductList.Rows[i].Cells[0].FormattedValue.ToString().Equals(txtProductId.Text))
                    {
                        MessageBox.Show("Product Id has exits.");
                        return;
                    }
                }

                string strInsert = @"INSERT INTO [Assignment_02_PRN].[dbo].[Product]
           ([ProductId],[CategoryId],[ProductName],[Weight],[UnitPrice],[UnitStock])
             VALUES(@pId, @catId, @pName, @weight, @UnitPrice, @UnitStock)";
                SqlCommand cmd = new SqlCommand(strInsert, cnn);
                cmd.Parameters.AddWithValue("@pId", txtProductId.Text);
                cmd.Parameters.AddWithValue("@catId", txtCategoryId.Text);
                cmd.Parameters.AddWithValue("@pName", txtProductName.Text);
                cmd.Parameters.AddWithValue("@weight", txtWeight.Text);
                cmd.Parameters.AddWithValue("@UnitPrice", txtUnitPrice.Text);
                cmd.Parameters.AddWithValue("@UnitStock", txtUnitInStock.Text);
                da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable tb = new DataTable();
                try
                {
                    cnn.Open();
                    da.Fill(ds, "Product");
                    cmd = new SqlCommand("select * from Product", cnn);
                    tb.Load(cmd.ExecuteReader());
                    dgProductList.DataSource = tb;

                    MessageBox.Show("Add sucessfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Add erorr: " + ex.Message);
                }
                finally
                {
                    cnn.Close();
                    connectDB();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtProductId.TextLength == 0 || txtCategoryId.TextLength == 0 || txtProductName.TextLength == 0 ||
                txtUnitInStock.TextLength == 0 || txtUnitPrice.TextLength == 0 || txtWeight.TextLength == 0)
            {
                MessageBox.Show("Please enter full field information");
            }
            else
            {
                string strInsert = @"UPDATE [Assignment_02_PRN].[dbo].[Product]
                                       SET [CategoryId] = @catId
                                          ,[ProductName] = @pName
                                          ,[Weight] = @weight
                                          ,[UnitPrice] = @UnitPrice
                                          ,[UnitStock] = @UnitStock where ProductId = @pId";
                SqlCommand cmd = new SqlCommand(strInsert, cnn);
                cmd.Parameters.AddWithValue("@pId", txtProductId.Text);
                cmd.Parameters.AddWithValue("@catId", txtCategoryId.Text);
                cmd.Parameters.AddWithValue("@pName", txtProductName.Text);
                cmd.Parameters.AddWithValue("@weight", txtWeight.Text);
                cmd.Parameters.AddWithValue("@UnitPrice", txtUnitPrice.Text);
                cmd.Parameters.AddWithValue("@UnitStock", txtUnitInStock.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable tb = new DataTable();
                try
                {
                    cnn.Open();
                    da.Fill(ds, "Product");
                    cmd = new SqlCommand("select * from Product", cnn);
                    tb.Load(cmd.ExecuteReader());
                    dgProductList.DataSource = tb;

                    MessageBox.Show("Update sucessfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update erorr: " + ex.Message);
                }
                finally
                {
                    cnn.Close();
                    connectDB();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you want to delete?", "Alert", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            try
            {
                string strDelete = "delete from Product where ProductId= @id";
                SqlCommand cmd = new SqlCommand(strDelete, cnn);
                cmd.Parameters.AddWithValue("@id", txtProductId.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable tb = new DataTable();
                cnn.Open();
                da.Fill(ds, "Product");
                cmd = new SqlCommand("select * from Product", cnn);
                tb.Load(cmd.ExecuteReader());
                dgProductList.DataSource = tb;
                MessageBox.Show("Delete sucessfully");
                txtProductId.Text = "";
                txtCategoryId.Text = "";
                txtProductName.Text = "";
                txtUnitInStock.Text = "";
                txtUnitPrice.Text = "";
                txtWeight.Text = "";


            }
            catch (Exception ex)
            {

                MessageBox.Show("Delete error: " + ex.Message);
            }
            finally
            {
                cnn.Close();
                connectDB();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void frmProducts_Load(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void LoadProductList()
        {
            try
            {
                string strSelect = "select * from Product";
                da = new SqlDataAdapter(strSelect, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgProductList.DataSource = dt;


            }
            catch (Exception ex)
            {

                MessageBox.Show("loadMember error: " + ex.Message);
            }
        }

        private void dgProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductId.Text = dgProductList.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtCategoryId.Text = dgProductList.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtProductName.Text = dgProductList.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtWeight.Text = dgProductList.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtUnitPrice.Text = dgProductList.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtUnitInStock.Text = dgProductList.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
        }
        private bool IsNumber(string s)
        {
            foreach (Char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

            string s = txtSearch.Text;
            if (IsNumber(s))
            {
                SqlCommand smd = new SqlCommand("Select * from Product where ProductId = @T or CategoryId = @T or UnitPrice = @T or UnitStock = @T", cnn);
                smd.Parameters.AddWithValue("@T", txtSearch.Text);

                try
                {
                    cnn.Open();
                    DataTable tb = new DataTable();
                    tb.Load(smd.ExecuteReader());
                    SqlDataReader dr = smd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dgProductList.DataSource = tb;
                    }
                    else
                    {
                        MessageBox.Show("Not Found");
                    }
                    cnn.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
                finally
                {
                    cnn.Close();
                }

            }
            else
            {
                SqlCommand cmd = new SqlCommand("Select * from Product where ProductName = @T or Weight = @T ", cnn);

                cmd.Parameters.AddWithValue("@T", txtSearch.Text);
                try
                {
                    cnn.Open();
                    DataTable tb = new DataTable();
                    tb.Load(cmd.ExecuteReader());
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dgProductList.DataSource = tb;
                    }
                    else
                    {
                        MessageBox.Show("Not Found");
                    }
                    cnn.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
                finally
                {
                    cnn.Close();
                }

            }
        }

        private void txtProductId_Enter(object sender, EventArgs e)
        {

            //for (int i = 0; i < dgProductList.Rows.Count; i++)
            //{
            //    if (dgProductList.Rows[i].Cells[0].FormattedValue.ToString().Equals(txtProductId.Text))
            //    {
            //        txtProductId.Text = dgProductList.Rows[i].Cells[0].FormattedValue.ToString();
            //        txtCategoryId.Text = dgProductList.Rows[i].Cells[1].FormattedValue.ToString();
            //        txtProductName.Text = dgProductList.Rows[i].Cells[2].FormattedValue.ToString();
            //        txtWeight.Text = dgProductList.Rows[i].Cells[3].FormattedValue.ToString();
            //        txtUnitPrice.Text = dgProductList.Rows[i].Cells[4].FormattedValue.ToString();
            //        txtUnitInStock.Text = dgProductList.Rows[i].Cells[5].FormattedValue.ToString();
            //    }

            //}


        }

        private void txtProductId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                for (int i = 0; i < dgProductList.Rows.Count; i++)
                {
                    if (dgProductList.Rows[i].Cells[0].FormattedValue.ToString().Equals(txtProductId.Text))
                    {
                        txtProductId.Text = dgProductList.Rows[i].Cells[0].FormattedValue.ToString();
                        txtCategoryId.Text = dgProductList.Rows[i].Cells[1].FormattedValue.ToString();
                        txtProductName.Text = dgProductList.Rows[i].Cells[2].FormattedValue.ToString();
                        txtWeight.Text = dgProductList.Rows[i].Cells[3].FormattedValue.ToString();
                        txtUnitPrice.Text = dgProductList.Rows[i].Cells[4].FormattedValue.ToString();
                        txtUnitInStock.Text = dgProductList.Rows[i].Cells[5].FormattedValue.ToString();
                    }
                    else
                    {
                        txtProductId.Text = "";
                        txtCategoryId.Text = "";
                        txtProductName.Text = "";
                        txtWeight.Text = "";
                        txtUnitPrice.Text = "";
                        txtUnitInStock.Text = "";
                    }

                }
            }
        }


    }
}
