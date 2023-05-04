using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        List<MemberObject> GetMembers();
        MemberObject GetMemberById(int memberId);
        int InsertMember(MemberObject member);
        int UpdateMember(MemberObject member);
        int DeleteMember(int memberId);
    }
}
