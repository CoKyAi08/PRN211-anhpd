using HotelManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Logics
{
    internal class BookingLogic
    {
        public List<Booking> GetAllBookings()
        {
            using (PRN211_HMSContext context = new PRN211_HMSContext())
            {
                return context.Bookings.ToList();
            }
        }

        public void AddBooking(Booking booking)
        {
            using (PRN211_HMSContext context = new PRN211_HMSContext())
            {
                context.Bookings.Add(booking);
                context.SaveChanges();
            }
        }

        public void EditBooking(Booking booking)
        {
            using (PRN211_HMSContext context = new PRN211_HMSContext())
            {
                context.Bookings.Update(booking);
                context.SaveChanges();
            }
        }

        public void DeleteBooking(Booking booking)
        {
            using (PRN211_HMSContext context = new PRN211_HMSContext())
            {
                context.Bookings.Remove(booking);
                context.SaveChanges();
            }
        }
    }
}
