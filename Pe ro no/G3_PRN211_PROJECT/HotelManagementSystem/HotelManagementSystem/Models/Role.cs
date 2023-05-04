using System;
using System.Collections.Generic;

namespace HotelManagementSystem.Models
{
    public partial class Role
    {
        public Role()
        {
            Accounts = new HashSet<Account>();
        }

        public int Roleid { get; set; }
        public string Rolename { get; set; } = null!;

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
