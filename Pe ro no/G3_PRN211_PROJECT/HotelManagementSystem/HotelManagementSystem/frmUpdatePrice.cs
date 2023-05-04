using HotelManagementSystem.Logics;
using HotelManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class frmUpdatePrice : Form
    {
        List<Room> rooms, selectedRooms = new List<Room>();

        public frmUpdatePrice()
        {
            InitializeComponent();
        }

        private void frmUpdatePrice_Load(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void btAddtoList2_Click(object sender, EventArgs e)
        {
            foreach (object o in lsAllRooms.SelectedItems)
            {
                Room room = (Room)o;
                rooms.Remove(room);
                selectedRooms.Add(room);
            }
            rooms = rooms.OrderBy(x => x.RoomId).ToList();
            selectedRooms = selectedRooms.OrderBy(x => x.RoomId).ToList();
            ClearListBox();
            lsAllRooms.DataSource = rooms;
            lsSelectedRooms.DataSource = selectedRooms;
        }

        private void btReturnToList1_Click(object sender, EventArgs e)
        {
            foreach (object o in lsSelectedRooms.SelectedItems)
            {
                Room room = (Room)o;
                selectedRooms.Remove(room);
                rooms.Add(room);
            }
            rooms = rooms.OrderBy(x => x.RoomId).ToList();
            selectedRooms = selectedRooms.OrderBy(x => x.RoomId).ToList();
            ClearListBox();
            lsAllRooms.DataSource = rooms;
            lsSelectedRooms.DataSource = selectedRooms;
        }

        private void ClearListBox()
        {
            lsAllRooms.DataSource = null;
            lsSelectedRooms.DataSource = null;
            lsAllRooms.DisplayMember = "RoomName";
            lsAllRooms.ValueMember = "RoomId";
            lsSelectedRooms.DisplayMember = "RoomName";
            lsSelectedRooms.ValueMember = "RoomId";
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            double newPrice = (double)numericUpDown1.Value;
            List<Room> roomList = new List<Room>();
            foreach (Room room in selectedRooms)
            {
                room.RoomPrice = newPrice;
                roomList.Add(room);
            }
            (new RoomLogic()).UpdatePrice(roomList);
            MessageBox.Show("Update successfully");
        }

        private void btViewRoom_Click(object sender, EventArgs e)
        {
            frmViewRoom frmViewRoom = new frmViewRoom();
            frmViewRoom.Show();
        }

        private void LoadRooms()
        {
            lsAllRooms.DisplayMember = "RoomName";
            lsAllRooms.ValueMember = "RoomId";
            rooms = (new RoomLogic()).GetAllRooms();
            lsAllRooms.DataSource = rooms.OrderBy(x => x.RoomId).ToList();
        }
    }
}
