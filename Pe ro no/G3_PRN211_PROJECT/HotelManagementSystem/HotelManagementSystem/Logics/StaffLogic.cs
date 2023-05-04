using HotelManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Logics
{
    internal class StaffLogic
    {
        public List<staff> GetAllStaffs()
        {
            using (PRN211_HMSContext context = new PRN211_HMSContext())
            {
                return context.staff.ToList();
            }
        }
        public List<staff> GetStaffByName(string subname)
        {
            using (PRN211_HMSContext context = new PRN211_HMSContext())
            {
                return context.staff.Where(x => x.FullName.ToLower().Contains(subname.ToLower())).ToList();
            }
        }

        public void AddStaff(staff staff)
        {
            using (PRN211_HMSContext context = new PRN211_HMSContext())
            {
                context.staff.Add(staff);
                context.SaveChanges();
            }
        }

        public void EditStaff(staff staff)
        {
            using (PRN211_HMSContext context = new PRN211_HMSContext())
            {
                context.staff.Update(staff);
                context.SaveChanges();
            }
        }

        public void DeleteBooking(staff staff)
        {
            using (PRN211_HMSContext context = new PRN211_HMSContext())
            {
                List<Booking> bookings = context.Bookings.Where(x => x.StaffId == staff.StaffId).ToList();
                context.Bookings.RemoveRange(bookings);
                context.staff.Remove(staff);
                context.SaveChanges();
            }
        }

    }
}
