using System;
using System.Collections.Generic;

namespace HotelManagementSystem.Models
{
    public partial class Booking
    {
        public int BookingId { get; set; }
        public int? RoomId { get; set; }
        public int? StaffId { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerPhone { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }

        public virtual Room? Room { get; set; }
        public virtual staff? Staff { get; set; }
    }
}
