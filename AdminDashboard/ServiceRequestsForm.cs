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
    public partial class ServiceRequestsForm : Form
    {
        IServiceRequestService _requestService;

        public ServiceRequestsForm(IServiceRequestService sr)
        {
            InitializeComponent();
            _requestService = sr;
            dgRequests.AutoGenerateColumns = false;
            populateRequestsData();
        }

        public async void populateRequestsData()
        {
            var requests = await _requestService.GetServiceRequests();
            dgRequests.DataSource = requests;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var selectedItem = dgRequests.SelectedRows[0].DataBoundItem as ServiceRequest;
            if (selectedItem != null)
            {
                _requestService.DeleteServiceRequest(selectedItem.ServiceRequestId);
                populateRequestsData();
            }
            else
            {
                MessageBox.Show("Please select a reqeust");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateRequestsData();
        }
    }
}
