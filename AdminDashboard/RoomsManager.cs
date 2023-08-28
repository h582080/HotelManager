using BLL.Services;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Services.Contracts;

namespace AdminDashboard
{
    public partial class RoomsManager : Form
    {
        IRoomService _roomService;
        IReservationService _reservationService;
        IServiceRequestService _requestService;
        List<Room>? rooms; 
        public RoomsManager(IRoomService roomService, IReservationService reservationService, IServiceRequestService requestService)
        {
            InitializeComponent();
            _roomService = roomService;
            _reservationService = reservationService;
            _requestService = requestService;
            dataGridRooms.AutoGenerateColumns = false;
            populateRoomsData();
            _requestService = requestService;
        }

        async void   populateRoomsData()
             {
            label1.Text = "Loading data";
             rooms = await _roomService.GetRooms();
             dataGridRooms.DataSource = rooms;
            label1.Text = "Loading done";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Room? r = dataGridRooms.SelectedRows[0].DataBoundItem as Room;
            if (r != null)
            {
                _roomService.DeleteRoom(r.RoomId);
                populateRoomsData();
            } else
            {
                MessageBox.Show("Pleas select a room");
            }
     
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            RoomEditor roomEditor = new RoomEditor(_roomService);
            roomEditor.FormClosed += RoomEditor_FormClosed;
            roomEditor.ShowDialog();
        }

        private void RoomEditor_FormClosed(object? sender, FormClosedEventArgs e)
        {
            populateRoomsData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Room? r = dataGridRooms.SelectedRows[0].DataBoundItem as Room;
            if (r != null)
            {
                RoomEditor roomEditor = new RoomEditor(_roomService, r);
                roomEditor.FormClosed += RoomEditor_FormClosed;
                roomEditor.ShowDialog();
            }
            else
            {
                MessageBox.Show("Pleas select a room");
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            Room? r = dataGridRooms.SelectedRows[0].DataBoundItem as Room;
            if (r != null)
            {
                ReservationEditor reservationEditor = new ReservationEditor(_reservationService,r);
              //  reservationEditor.FormClosed += ReservationEditor_FormClosed;
                reservationEditor.ShowDialog();
            }
            else
            {
                MessageBox.Show("Pleas select a room");
            }
        }

        private void ReservationEditor_FormClosed(object? sender, FormClosedEventArgs e)
        {

        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            Room? r = dataGridRooms.SelectedRows[0].DataBoundItem as Room;
            if (r != null)
            {
                var requestEditor = new RequestEditor(_requestService, r);
                requestEditor.FormClosed += RequestEditor_FormClosed;
                requestEditor.ShowDialog();
            }
            else
            {
                MessageBox.Show("Pleas select a room");
            }
            
        }

        private void RequestEditor_FormClosed(object? sender, FormClosedEventArgs e)
        {
            new ServiceRequestsForm(_requestService).ShowDialog();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            populateRoomsData();
        }
    }
}
