using BLL.Models;
using BLL.Services.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminDashboard
{
    public partial class RequestEditor : Form
    {
       IServiceRequestService _serviceRequestService;
        Room _room;
        public RequestEditor(IServiceRequestService rs, Room r) 
        {
            InitializeComponent();
            _serviceRequestService = rs;
            _room = r;
            var workTypes = BModelHelper.GetWorkTypes();
            //cbWorkType.ValueMember = "Id";
            //cbWorkType.DisplayMember = "Title";
            cbWorkType.DataSource = workTypes;
            txtRoomNum.Text = _room.RoomNumber.ToString();
            cbWorkType.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ServiceRequest sr = new ServiceRequest();
            sr.RoomId = _room.RoomId;
            sr.RoomNumber = _room.RoomNumber;
            sr.Status = "New";
            sr.RequestDate = DateTime.Now;
            sr.ServiceType = ((string)cbWorkType.SelectedItem);
            try
            {
                _serviceRequestService.InsertServiceRequest(sr);
                this.Close();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
