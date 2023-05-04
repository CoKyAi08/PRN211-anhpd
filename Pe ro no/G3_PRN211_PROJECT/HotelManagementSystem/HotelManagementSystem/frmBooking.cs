using HotelManagementSystem.Logics;
using HotelManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class frmBooking : Form
    {
        Room SelectedRoom = new Room();
        public frmBooking()
        {
            InitializeComponent();
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
            LoadListRooms();
        }

        private void LoadListRooms()
        {
            lbRoom.DisplayMember = "RoomName";
            lbRoom.ValueMember = "RoomId";
            lbRoom.DataSource = (new RoomLogic()).GetAllRooms();
        }

        private void lbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedRoom = (Room)lbRoom.SelectedItem;
            tbRoom.Text = SelectedRoom.RoomName;
            tbRoomDetails.Text = SelectedRoom.RoomDescription;

            cbStaff.ValueMember = "StaffId";
            cbStaff.DisplayMember = "FullName";
            cbStaff.DataSource = (new StaffLogic()).GetAllStaffs();

            LoadPrice();

        }

        private void dtpDateFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadPrice();
        }

        private void LoadPrice()
        {
            int dayDiff = (dtpDateTo.Value - dtpDateFrom.Value).Days;
            if (dayDiff < 0) dayDiff = 0;
            else dayDiff = dayDiff + 1; 
            double? price = SelectedRoom.RoomPrice;
            tbPrice.Text = (dayDiff * price).ToString();
        }

        private void btBook_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.RoomId = SelectedRoom.RoomId;
            booking.StaffId = (int?)cbStaff.SelectedValue;
            
            if(!Regex.IsMatch(tbCustomerId.Text, "[0-9]{12}"))
            {
                MessageBox.Show("CustomerId must be 12 digits");
                return;
            } else
            {
                booking.CustomerId = tbCustomerId.Text;
            }

            if (string.IsNullOrEmpty(tbCustomerName.Text))
            {
                MessageBox.Show("CustomerName must not empty");
                return;
            } else
            {
                booking.CustomerName = tbCustomerName.Text;
            }

            if (!Regex.IsMatch(tbCustomerPhone.Text, "[0-9]{10,11}"))
            {
                MessageBox.Show("CustomerPhone must be 10-11 digits");
                return;
            }
            else
            {
                booking.CustomerPhone = tbCustomerPhone.Text;
            }

            if(dtpDateFrom.Value > dtpDateTo.Value)
            {
                MessageBox.Show("Date To must after Date From");
                return;
            }
            if (!CheckTime(dtpDateFrom.Value, dtpDateTo.Value, SelectedRoom.RoomId))
            {
                MessageBox.Show("Time duplicated");
                return;
            } else
            {
                booking.DateFrom = dtpDateFrom.Value;
                booking.DateTo = dtpDateTo.Value;
            }

            (new BookingLogic()).AddBooking(booking);
            MessageBox.Show("Book successfully");

        }

        private bool CheckTime(DateTime DateFrom, DateTime DateTo, int RoomId) 
        { 
            PRN211_HMSContext context = new PRN211_HMSContext();
            List<Booking> bookingList = context.Bookings.Where(x => ( x.RoomId == RoomId && (x.DateFrom <= DateFrom && x.DateTo >= DateFrom))
            || (x.RoomId == RoomId && (x.DateFrom <= DateTo && x.DateTo >= DateTo))).ToList();

            if (bookingList.Count > 0) return false;
            return true;
        }

        private void btViewBooking_Click(object sender, EventArgs e)
        {
            frmViewBooking frmViewBooking = new frmViewBooking();
            frmViewBooking.Show();
        }
    }
}
