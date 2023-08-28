using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BLL.Models;
using BLL.Services.Contracts;

namespace AdminDashboard
{
    public partial class ReservationEditor : Form
    {
        // private readonly RoomService _roomService;
        private readonly IReservationService _reservationService;
        Room _room;

        public ReservationEditor(IReservationService rs, Room r) : base()
        {
            InitializeComponent();
            cbStatus.DataSource = new List<string> { "Confirmed", "Requested", "Active","Finished" };
            cbChecked.DataSource = new List<bool> { true, false };
            cbChecked.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            _reservationService = rs;
            _room = r;
            txtRoomId.Text = r.RoomNumber.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Reservation r = new Reservation();
            r.Status = cbStatus.SelectedItem as string;
            r.RoomId = _room.RoomId;
            r.CheckedIn = (bool)cbChecked.SelectedItem;
            r.StartOn = dtStartOn.Value;
            r.EndOn = dtEndOn.Value;
            if(txtUsername.Text!="")
            {
                try
                {
                    _reservationService.InsertReservationWithUsername(r, txtUsername.Text);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                MessageBox.Show("Please Enter Customer Email");
            }
           

        }
    }
}
