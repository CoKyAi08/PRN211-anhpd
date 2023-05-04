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
    public partial class frmOrders : Form
    {
        public frmOrders()
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




        private void frmOrders_Load(object sender, EventArgs e)
        {
            try
            {
                string strLoad = "Select * from [Order]";
                da = new SqlDataAdapter(strLoad, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgOrderList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Order eroor:" + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtOrderId.TextLength == 0 || txtOrderId.TextLength == 0)
            {
                MessageBox.Show("Please enter full field information");
            }

            try
            {
                string sqlAdd = @"INSERT INTO [Assignment_02_PRN].[dbo].[Order]
           ([OrderId],[MemberId] ,[OrderDate],[RequireDate],[ShippedDate],[Freight])
            VALUES(@oId, @mId, @orderDate, @requireDate, @shipDate, @freight)";
                cmd = new SqlCommand(sqlAdd, cnn);
                cmd.Parameters.AddWithValue("@oId", txtOrderId.Text);
                cmd.Parameters.AddWithValue("@mId", txtMemberId.Text);
                cmd.Parameters.AddWithValue("@orderDate", dtOrder.Value);
                cmd.Parameters.AddWithValue("@requireDate", dtRequired.Value);
                cmd.Parameters.AddWithValue("@shipDate", dtShipped.Value);
                cmd.Parameters.AddWithValue("@freight", txtFreight.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable tb = new DataTable();
                cnn.Open();
                da.Fill(ds, "[Order]");
                cmd = new SqlCommand("select * from [Order]", cnn);
                tb.Load(cmd.ExecuteReader());
                dgOrderList.DataSource = tb;
                cnn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Check the values");
                MessageBox.Show("Add Order erorr: " + ex.Message);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "It will delete all detail of this id! Are you want to delete?", "Alert", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            try
            {
                string strDelete = "delete from [Order] where OrderId= @id";
                SqlCommand cmd = new SqlCommand(strDelete, cnn);
                cmd.Parameters.AddWithValue("@id", txtOrderId.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable tb = new DataTable();
                deleteDetail();
                cnn.Open();
                da.Fill(ds, "[Order]");
                cmd = new SqlCommand("select * from [Order]", cnn);
                tb.Load(cmd.ExecuteReader());
                dgOrderList.DataSource = tb;
                MessageBox.Show("Delete sucessfully");
                dgOrderList.DataSource = tb;

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

        private void deleteDetail()
        {
            SqlCommand cmd = new SqlCommand("Select * from OrderDetail where OrderId = @orderId", cnn);
            cmd.Parameters.AddWithValue("@orderId", txtOrderId.Text);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                cnn.Close();
                try
                {
                    cnn.Open();
                    cmd = new SqlCommand("delete from OrderDetail where OrderId = @orderId", cnn);
                    cmd.Parameters.AddWithValue("@orderId", txtOrderId.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    DataTable tb = new DataTable();
                    da.Fill(ds, "OrderDetail");
                    cmd = new SqlCommand("Select * from OrderDetail", cnn);
                    tb.Load(cmd.ExecuteReader());
                    dgOrderDetail.DataSource = tb;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete detail erorr: " + ex.Message);
                }
                finally
                {
                    cnn.Close();
                }
            }
            else
            {
                cnn.Close();
            }
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (txtOrderId.TextLength == 0)
            {
                MessageBox.Show("Please enter full field information");
            }
            else
            {
                string strView = "Select * from OrderDetail where OrderId = @id";
                cmd = new SqlCommand(strView, cnn);
                cmd.Parameters.AddWithValue("@id", txtOrderId.Text);
                DataTable tb = new DataTable();
                try
                {
                    cnn.Open();
                    tb.Load(cmd.ExecuteReader());
                    dgOrderDetail.DataSource = tb;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("View Detail erorr: " + ex.Message);
                }
                finally
                {
                    cnn.Close();
                }

            }
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            if (txtOrderDetailId.TextLength == 0 || txtQuantity.TextLength == 0 || txtProductId.TextLength == 0 || txtUnitPrice.TextLength == 0)
            {
                MessageBox.Show("Please enter full field information");
            }
            else
            {
                try
                {
                    string sqlAdd = @"INSERT INTO [Assignment_02_PRN].[dbo].[OrderDetail]
           ([OrderId],[ProductId],[UnitPrice] ,[Quantity],[Discount])
            VALUES(@oId, @pId, @unitPrice, @quantity, @discount)";
                    cmd = new SqlCommand(sqlAdd, cnn);
                    cmd.Parameters.AddWithValue("@oId", txtOrderId.Text);
                    cmd.Parameters.AddWithValue("@pId", txtProductId.Text);
                    cmd.Parameters.AddWithValue("@unitPrice", txtUnitPrice.Text);
                    cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                    cmd.Parameters.AddWithValue("@discount", txtDiscount.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds1 = new DataSet();
                    DataTable tb1 = new DataTable();
                    cnn.Open();
                    da.Fill(ds1, "[OrderDetail]");
                    cmd = new SqlCommand("select * from [OrderDetail]", cnn);
                    tb1.Load(cmd.ExecuteReader());
                    dgOrderList.DataSource = tb1;
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Check the values");
                    MessageBox.Show("Add OrderDetail erorr: " + ex.Message);
                }
            }
        }

        private void btnUpdateDetail_Click(object sender, EventArgs e)
        {
            if (txtOrderDetailId.TextLength == 0 || txtQuantity.TextLength == 0 || txtProductId.TextLength == 0 || txtUnitPrice.TextLength == 0)
            {
                MessageBox.Show("Please enter full field information");
            }
            else
            {
                string strInsert = @"UPDATE [Assignment_02_PRN].[dbo].[OrderDetail]
                                       SET [OrderId] = @oId
                                          ,[ProductId] = @pId
                                          ,[UnitPrice] = @unitPrice
                                          ,[Quantity] = @quantity
                                          ,[Discount] = @discount where OrderId = @oId";
                SqlCommand cmd = new SqlCommand(strInsert, cnn);
                cmd.Parameters.AddWithValue("@oId", txtOrderId.Text);
                cmd.Parameters.AddWithValue("@pId", txtProductId.Text);
                cmd.Parameters.AddWithValue("@unitPrice", txtUnitPrice.Text);
                cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@discount", txtDiscount.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable tb = new DataTable();
                try
                {
                    cnn.Open();
                    da.Fill(ds, "OrderDetail");
                    cmd = new SqlCommand("select * from OrderDetail", cnn);
                    tb.Load(cmd.ExecuteReader());
                    dgOrderDetail.DataSource = tb;

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

        private void DeleteDetail_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "It will delete all detail of this id! Are you want to delete?", "Alert", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            try
            {
                string strDelete = "delete from [OrderDetail] where OrderId= @id";
                SqlCommand cmd = new SqlCommand(strDelete, cnn);
                cmd.Parameters.AddWithValue("@id", txtOrderId.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable tb = new DataTable();
                deleteDetail();
                cnn.Open();
                da.Fill(ds, "[OrderDetail]");
                cmd = new SqlCommand("select * from [OrderDetail]", cnn);
                tb.Load(cmd.ExecuteReader());
                dgOrderList.DataSource = tb;
                MessageBox.Show("Delete sucessfully");
                txtOrderId.Text = "";
                txtProductId.Text = "";
                txtUnitPrice.Text = "";
                txtQuantity.Text = "";
                txtFreight.Text = "";
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
