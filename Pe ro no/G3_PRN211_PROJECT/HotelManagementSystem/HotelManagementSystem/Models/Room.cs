using System;
using System.Collections.Generic;

namespace HotelManagementSystem.Models
{
    public partial class Room
    {
        public Room()
        {
            Bookings = new HashSet<Booking>();
        }

        public int RoomId { get; set; }
        public string? RoomName { get; set; }
        public string? RoomDescription { get; set; }
        public double? RoomPrice { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
