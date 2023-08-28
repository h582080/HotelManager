using BLL.Services;
using BLL.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class RoomEditor : Form
    {
       IRoomService _roomService;
        Room _currentRoom = new Room();
        bool update = false;
        public RoomEditor()
        {
            InitializeComponent();
        }

        public RoomEditor(IRoomService roomService)
        {
            InitializeComponent();
            _roomService = roomService;
        }
        public RoomEditor(IRoomService roomService, Room currentRoom)
        {
            InitializeComponent();
            _currentRoom = currentRoom;
            _roomService = roomService;
            txtBeds.Text = currentRoom.Beds.ToString();
            txtOccpuncy.Text = currentRoom.Occupancy;
            txtLayout.Text = currentRoom.Layout;
            txtPrice.Text = currentRoom.Price.ToString();
            txtRoomNumber.Text = currentRoom.RoomNumber.ToString();
            update = true;



        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _currentRoom.Beds = int.Parse(txtBeds.Text);
            _currentRoom.Occupancy = txtOccpuncy.Text;
            _currentRoom.Layout = txtLayout.Text;
            _currentRoom.Price = int.Parse(txtPrice.Text);
            _currentRoom.RoomNumber = int.Parse(txtRoomNumber.Text);
            if (update)
            {
                 _roomService.UpdateRoom(_currentRoom);
            } else
            {
                
                _roomService.InsertRoom(_currentRoom);
            }
           
            this.Close();



        }

        private void RoomEditor_Load(object sender, EventArgs e)
        {

        }
    }
}
