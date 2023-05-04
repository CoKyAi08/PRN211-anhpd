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
    public partial class frmViewBooking : Form
    {
        Booking CurBooking = new Booking();
        List<Booking> BookingList = new List<Booking>();
        public frmViewBooking()
        {
            InitializeComponent();
        }

        private void frmViewBooking_Load(object sender, EventArgs e)
        {
            dtpDate.Enabled = false;
            gbDetail.Visible = false;
            LoadRoom();
            LoadStaff();
            LoadDGVBooking();
        }

        private void LoadRoom()
        {
            Room room = new Room();
            room.RoomName = "All Rooms";
            room.RoomId = 0;
            List<Room> RoomList = new List<Room>();
            RoomList = (new RoomLogic()).GetAllRooms();
            RoomList.Insert(0, room);

            cbRoom.DisplayMember = "RoomName";
            cbRoom.ValueMember = "RoomId";
            cbRoom.DataSource = RoomList;
        }

        private void LoadStaff()
        {
            staff staff = new staff();
            staff.FullName = "All Staffs";
            staff.StaffId = 0;
            List<staff> StaffList = new List<staff>();
            StaffList = (new StaffLogic()).GetAllStaffs();
            StaffList.Insert(0,staff);

            cbStaff.DisplayMember = "FullName";
            cbStaff.ValueMember = "StaffId";
            cbStaff.DataSource = StaffList;
        }

        private void DesignDVGBooking()
        {
            dgvBooking.AutoGenerateColumns = false;

            dgvBooking.Columns.Add("RoomName", "RoomName");
            dgvBooking.Columns["RoomName"].DataPropertyName = "RoomName";

            dgvBooking.Columns.Add("FullName", "FullName");
            dgvBooking.Columns["FullName"].DataPropertyName = "FullName";

            dgvBooking.Columns.Add("CustomerId", "CustomerId");
            dgvBooking.Columns["CustomerId"].DataPropertyName = "CustomerId";

            dgvBooking.Columns.Add("CustomerName", "CustomerName");
            dgvBooking.Columns["CustomerName"].DataPropertyName = "CustomerName";

            dgvBooking.Columns.Add("CustomerPhone", "CustomerPhone");
            dgvBooking.Columns["CustomerPhone"].DataPropertyName = "CustomerPhone";

            dgvBooking.Columns.Add("DateFrom", "DateFrom");
            dgvBooking.Columns["DateFrom"].DataPropertyName = "DateFrom";

            dgvBooking.Columns.Add("DateFrom", "DateFrom");
            dgvBooking.Columns["DateFrom"].DataPropertyName = "DateFrom";
        }

        private void LoadDGVBooking()
        {
            using (PRN211_HMSContext context = new PRN211_HMSContext())
            {
                int roomId = Convert.ToInt32(cbRoom.SelectedValue);
                int staffId = Convert.ToInt32(cbStaff.SelectedValue);
                string cusPhone = tbCustomerPhone.Text;
                DateTime date = dtpDate.Value;


                List<Booking> BookingList = context.Bookings.ToList();
                if (roomId != 0)
                {
                    BookingList = BookingList.Where(x => x.RoomId == roomId).ToList();
                }
                if(staffId != 0)
                {
                    BookingList = BookingList.Where(x => x.StaffId == staffId).ToList();
                }
                if (!String.IsNullOrEmpty(cusPhone))
                {
                    BookingList = BookingList.Where(x => x.CustomerPhone.Contains(cusPhone)).ToList();
                }
                if(dtpDate.Enabled != false)
                {
                    BookingList = BookingList.Where(x => x.DateFrom <= date && x.DateTo >= date).ToList();
                }

                dgvBooking.DataSource = BookingList.Select(x => new
                {
                    x.BookingId,
                    context.Rooms.Where(o => o.RoomId == x.RoomId).FirstOrDefault().RoomName,
                    context.staff.Where(o => o.StaffId == x.StaffId).FirstOrDefault().FullName,
                    x.CustomerId,
                    x.CustomerName,
                    x.CustomerPhone,
                    x.DateFrom,
                    x.DateTo
                }).ToList();
            }
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            LoadDGVBooking();
        }

        private void btHideDate_Click(object sender, EventArgs e)
        {
            dtpDate.Enabled = !dtpDate.Enabled;
            LoadDGVBooking();
        }

        private void dgvBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PRN211_HMSContext context = new PRN211_HMSContext();
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            gbDetail.Visible = true;
            int CurBookingId = Convert.ToInt32(dgvBooking["BookingID", dgvBooking.CurrentCell.RowIndex].Value);
            CurBooking = context.Bookings.FirstOrDefault(x => x.BookingId == CurBookingId);


            cbRoominDetails.DisplayMember = "RoomName";
            cbRoominDetails.ValueMember = "RoomId";
            cbRoominDetails.DataSource = (new RoomLogic()).GetAllRooms();
            cbRoominDetails.SelectedValue = CurBooking.RoomId;


            cbStaffinDetail.DisplayMember = "FullName";
            cbStaffinDetail.ValueMember = "StaffId";
            cbStaffinDetail.DataSource = (new StaffLogic()).GetAllStaffs();
            cbStaffinDetail.SelectedValue = CurBooking.StaffId;

            tbCustomerId.Text = CurBooking.CustomerId;
            tbCustomerName.Text = CurBooking.CustomerName;
            tbCustomerPhoneinDetail.Text = CurBooking.CustomerPhone;
            dtpDateFrom.Value = (DateTime)CurBooking.DateFrom;
            dtpDateTo.Value = (DateTime)CurBooking.DateTo;

            LoadPrice();
        }

        private void LoadPrice()
        {
            PRN211_HMSContext context = new PRN211_HMSContext();
            int dayDiff = (dtpDateTo.Value - dtpDateFrom.Value).Days;
            if (dayDiff < 0) dayDiff = 0;
            else dayDiff = dayDiff + 1;
            double? price = context.Rooms.FirstOrDefault(x => x.RoomId == CurBooking.RoomId).RoomPrice;
            tbPrice.Text = (dayDiff * price).ToString();
        }

        private void dtpDateFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadPrice();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.BookingId = CurBooking.BookingId;
            booking.RoomId = Convert.ToInt32(cbRoominDetails.SelectedValue);
            booking.StaffId = (int?)cbStaffinDetail.SelectedValue;

            if (!Regex.IsMatch(tbCustomerId.Text, "[0-9]{12}"))
            {
                MessageBox.Show("CustomerId must be 12 digits");
                return;
            }
            else
            {
                booking.CustomerId = tbCustomerId.Text;
            }

            if (string.IsNullOrEmpty(tbCustomerName.Text))
            {
                MessageBox.Show("CustomerName must not empty");
                return;
            }
            else
            {
                booking.CustomerName = tbCustomerName.Text;
            }

            if (!Regex.IsMatch(tbCustomerPhoneinDetail.Text, "[0-9]{10,11}"))
            {
                MessageBox.Show("CustomerPhone must be 10-11 digits");
                return;
            }
            else
            {
                booking.CustomerPhone = tbCustomerPhoneinDetail.Text;
            }

            if (dtpDateFrom.Value > dtpDateTo.Value)
            {
                MessageBox.Show("Date To must after Date From");
                return;
            }
            if (!CheckTime(dtpDateFrom.Value, dtpDateTo.Value, Convert.ToInt32(cbRoominDetails.SelectedValue)))
            {
                MessageBox.Show("Time duplicated");
                return;
            }
            else
            {
                booking.DateFrom = dtpDateFrom.Value;
                booking.DateTo = dtpDateTo.Value;
            }

            (new BookingLogic()).EditBooking(booking);
            MessageBox.Show("Edit successfully");
        }

        private bool CheckTime(DateTime DateFrom, DateTime DateTo, int RoomId)
        {
            PRN211_HMSContext context = new PRN211_HMSContext();
            List<Booking> bookingList = context.Bookings.Where(x => ( x.BookingId!=CurBooking.BookingId && x.RoomId == RoomId && (x.DateFrom <= DateFrom && x.DateTo >= DateFrom))
            || (x.BookingId != CurBooking.BookingId && x.RoomId == RoomId && (x.DateFrom <= DateTo && x.DateTo >= DateTo))).ToList();

            if (bookingList.Count > 0) return false;
            return true;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int CurBookingId = CurBooking.BookingId;

            DialogResult result = MessageBox.Show($"Are you sure to delete?",
                "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                (new BookingLogic()).DeleteBooking(CurBooking);

            }
            LoadDGVBooking();
        }
    }
}
