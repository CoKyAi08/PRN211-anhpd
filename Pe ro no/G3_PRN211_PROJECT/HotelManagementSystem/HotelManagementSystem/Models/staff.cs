using System;
using System.Collections.Generic;

namespace HotelManagementSystem.Models
{
    public partial class staff
    {
        public staff()
        {
            Bookings = new HashSet<Booking>();
        }

        public int StaffId { get; set; }
        public string? FullName { get; set; }
        public DateTime? Dob { get; set; }
        public string? PhoneNumber { get; set; }
        public string? City { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
