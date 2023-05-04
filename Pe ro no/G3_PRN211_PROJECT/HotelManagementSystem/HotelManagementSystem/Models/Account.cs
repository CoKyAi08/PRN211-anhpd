using System;
using System.Collections.Generic;

namespace HotelManagementSystem.Models
{
    public partial class Account
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int Accountid { get; set; }
        public string Phone { get; set; } = null!;
        public string Displayname { get; set; } = null!;
        public int Roleid { get; set; }

        public virtual Role Role { get; set; } = null!;
    }
}
