using BusinessObject;
using DemoDataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO
    {
        //Get List Member
        public List<MemberObject> GetMemberList()
        {
            string sqlSelect = "select * from Member";
            DataTable members = DAO.GetDataBySQL(sqlSelect); //members la list member duoc lay tu sql ve
            List<MemberObject> membersList = new List<MemberObject>();
            foreach (DataRow item in members.Rows)
            {
                MemberObject m = new MemberObject(
                    Convert.ToInt32(item["MemberId"]),
                    item["Email"].ToString(),
                    item["CompanyName"].ToString(),
                    item["City"].ToString(),
                    item["Country"].ToString(),
                    item["Password"].ToString()
                    );
                membersList.Add(m);
            }
            return membersList;
        }
        //Add new Member
        public int AddNew(MemberObject member)
        {
            string sqlInsert = @"INSERT INTO [Assignment_02_PRN.[dbo].[Member]
                            ([MemberId],[Email],[CompanyName],[City],[Country],[Password])
                            VALUES(@id, @email, @companyName, @city, @country, @password)";
            List<SqlParameter> para = new List<SqlParameter>();

            SqlParameter param = new SqlParameter("@id", SqlDbType.Int);
            param.Value = member.MemberId;
            para.Add(param);

            param = new SqlParameter("@email", SqlDbType.NVarChar);
            param.Value = member.Email;
            para.Add(param);

            param = new SqlParameter("@companyName", SqlDbType.NVarChar);
            param.Value = member.CompanyName;
            para.Add(param);

            param = new SqlParameter("@city", SqlDbType.NVarChar);
            param.Value = member.City;
            para.Add(param);

            param = new SqlParameter("@country", SqlDbType.NVarChar);
            param.Value = member.Country;
            para.Add(param);

            param = new SqlParameter("@password", SqlDbType.NVarChar);
            param.Value = member.Password;
            para.Add(param);

            return DAO.ExecuteSql(sqlInsert, para);

        }
        //Update a Member
        public int Update(MemberObject member)
        {
            MemberObject pro = GetMemberById(member.MemberId);
            if (pro != null)
            {
                string sqlUpdate = @"UPDATE [Assignment_02_PRN].[dbo].[Member] set MemberId = @id,Email =@email,CompanyName=@companyName,City=@city,Country=@country,Password=@password";
                var para = new List<SqlParameter>();
                SqlParameter param = new SqlParameter("@id", SqlDbType.Int);
                param.Value = member.MemberId;
                para.Add(param);

                param = new SqlParameter("@email", SqlDbType.NVarChar);
                param.Value = member.Email;
                para.Add(param);

                param = new SqlParameter("@companyName", SqlDbType.NVarChar);
                param.Value = member.CompanyName;
                para.Add(param);

                param = new SqlParameter("@city", SqlDbType.NVarChar);
                param.Value = member.City;
                para.Add(param);

                param = new SqlParameter("@country", SqlDbType.NVarChar);
                param.Value = member.Country;
                para.Add(param);

                param = new SqlParameter("@password", SqlDbType.NVarChar);
                param.Value = member.Password;
                para.Add(param);

                return DAO.ExecuteSql(sqlUpdate, para);
            }
            else
            {
                return -1;
            }
        }
        //Remove a Member
        public int Remove(int memberId)
        {
            MemberObject member = GetMemberById(memberId);
            if (member != null)
            {
                string sqlDelete = "delete from Member where MemberId='" + memberId + "'";
                var para = new List<SqlParameter>();
                return DAO.ExecuteSql(sqlDelete, para);
            }
            else
            {
                return -1;
            }

        }

        public MemberObject GetMemberById(int memberId)
        {
            string sqlGet = "select * from Member where MemberId = '"+ memberId+ "'";
            DataTable members = DAO.GetDataBySQL(sqlGet); //members la list member duoc lay tu sql ve
            //MemberObject member = new MemberObject();
            DataRow item = members.Rows[0];
                MemberObject m = new MemberObject(
                    Convert.ToInt32(item["MemberId"]),
                    item["Email"].ToString(),
                    item["CompanyName"].ToString(),
                    item["City"].ToString(),
                    item["Country"].ToString(),
                    item["Password"].ToString()
                    );
            return m;
        }
    }
}
