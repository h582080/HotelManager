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
    public partial class CustomersManager : Form
    {
        ICustomerService _customerService;
        List<Customer> _customers;
        public CustomersManager(ICustomerService cs)
        {
            InitializeComponent();
            _customers = new List<Customer>();
            _customerService = cs;
             dgvCustomers.AutoGenerateColumns = false;
            populateCustomersData();

        }

        async void populateCustomersData()
        {
            // label1.Text = "Loading data";
            _customers = await _customerService.GetCustomers();
            dgvCustomers.DataSource = _customers;
           // label1.Text = "Loading done";

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var selectedItem = dgvCustomers.SelectedRows[0].DataBoundItem as Customer;
            if (selectedItem != null)
            {
                _customerService.DeleteCustomer(selectedItem.CustomerId);
                populateCustomersData();
            }
            else
            {
                MessageBox.Show("Please select a customer");
            }
        }
    }
}
