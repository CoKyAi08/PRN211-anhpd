using HotelManagementSystem.Logics;
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
    public partial class frmViewRoom : Form
    {
        public frmViewRoom()
        {
            InitializeComponent();
        }

        private void frmViewRoom_Load(object sender, EventArgs e)
        {
            LoadRoomDGV();
        }

        private void LoadRoomDGV()
        {
            dgvRoom.DataSource = (new RoomLogic()).GetAllRooms();
        }
    }
}
