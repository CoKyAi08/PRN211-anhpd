using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDataAccess.DataAccess
{
    class DAO
    {
        public static SqlConnection GetConnection()
        {
            string ConStr = "Server=localhost;database=Assignment_02_PRN;uid=CoKyAi;pwd=04112002";
            return new SqlConnection(ConStr);
        }
        public static DataTable GetDataBySQL(string sql)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());            
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static DataTable GetDataBySQL(string sql, List<SqlParameter> parameters)
        {
            //
            return null;
        }

        public static int ExecuteSql(string sql)
        {
            return 0;
        }

        public static int ExecuteSql(string sql, List<SqlParameter> parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddRange(parameters.ToArray());
            command.Connection.Open();
            int k = command.ExecuteNonQuery();
            command.Connection.Close();
            return k;
        }
    }
}
