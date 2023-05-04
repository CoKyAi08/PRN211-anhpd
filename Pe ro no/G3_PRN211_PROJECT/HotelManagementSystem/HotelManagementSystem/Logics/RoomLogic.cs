using HotelManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Logics
{
    internal class RoomLogic
    {
        public List<Room> GetAllRooms()
        {
            using (PRN211_HMSContext context = new PRN211_HMSContext())
            {
                return context.Rooms.ToList();
            }
        }

        public void UpdatePrice(List<Room> roomList)
        {
            using (PRN211_HMSContext context = new PRN211_HMSContext())
            {
                foreach (Room room in roomList)
                {
                    context.Rooms.Update(room);
                }
                context.SaveChanges();
            }
        }
    }
}
