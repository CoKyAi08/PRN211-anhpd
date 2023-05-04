using BusinessObject;
using System;
using System.Collections.Generic;
using DataAccess;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public int DeleteMember(int memberId)
        {
            MemberDAO memberDAO = new MemberDAO();
            return memberDAO.Remove(memberId);
        }

        public MemberObject GetMemberById(int memberId)
        {
           return new MemberDAO().GetMemberById(memberId);
        }

        public List<MemberObject> GetMembers()
        {
            MemberDAO memberDAO= new MemberDAO();   
            return memberDAO.GetMemberList();
        }

        public int InsertMember(MemberObject member)
        {
            return new MemberDAO().AddNew(member);
        }

        public int UpdateMember(MemberObject member)
        {
            return new MemberDAO().Update(member);
        }
    }
}
