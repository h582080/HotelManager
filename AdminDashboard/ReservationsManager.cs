using BLL.Models;
using BLL.Services;
using BLL.Services.Contracts;
using DAL.Repositories.Contracts;
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
    public partial class ReservationsManager : Form
    {
        private IReservationService _reservationService;
        public ReservationsManager(IReservationService reservationService)
        {
            InitializeComponent();
            _reservationService = reservationService;
            dgvReservations.AutoGenerateColumns = false;
            populateReservationData();


        }

         async void populateReservationData()
        {
            List<CustomerReservation> reservations = new List<CustomerReservation>();
            reservations = await _reservationService.GetReservationsWithCustomers();
            dgvReservations.DataSource = reservations;

        }

        private void dgvReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedItem = dgvReservations.SelectedRows[0].DataBoundItem as CustomerReservation;
         

            if (selectedItem != null)
            {
                _reservationService.DeleteReservation(selectedItem.CustomerId, selectedItem.RoomId);
                populateReservationData();


            }
            else
            {
                MessageBox.Show("Please select a reservation");

            }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var selectedItem = dgvReservations.SelectedRows[0].DataBoundItem as CustomerReservation;
           if (selectedItem != null)
            {
                if (selectedItem.Status == "Confirmed")
                {
                    MessageBox.Show("This reservation is already confirmed!");
                }
                else if(selectedItem.Status == "Requested")
                {
                    selectedItem.Status = "Confirmed";
                    _reservationService.UpdateReservation(selectedItem as Reservation);
                    populateReservationData();
                    MessageBox.Show("This reservation is now confirmed!");

                } else
                {
                    MessageBox.Show("Reservation should be in requsted state to be confirmed");
                }
            }
            else
            {
                MessageBox.Show("Please select a reservation");

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnChecked_Click(object sender, EventArgs e)
        {
            var selectedItem = dgvReservations.SelectedRows[0].DataBoundItem as CustomerReservation;
            if (selectedItem != null)
            {
                DateTime today = DateTime.Now;
                if(selectedItem.CheckedIn == true)
                {
                    MessageBox.Show("Customer has already checked in");
                }
                else if (selectedItem.Status == "Confirmed" &&  today >= selectedItem.StartOn && today <selectedItem.EndOn )
                {

                    selectedItem.Status = "Active";
                    selectedItem.CheckedIn = true;
                    _reservationService.UpdateReservation(selectedItem as Reservation);
                    populateReservationData();
                    MessageBox.Show("This user is now checked in!");
                }
                else
                {

                    MessageBox.Show("Make sure the reservation is confirmed and in correct date range");

                }
            }
            else
            {
                MessageBox.Show("Please select a reservation");

            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            var selectedItem = dgvReservations.SelectedRows[0].DataBoundItem as CustomerReservation;
            if (selectedItem != null)
            {
                DateTime today = DateTime.Now;
                if (selectedItem.CheckedIn == false)
                {
                    MessageBox.Show("Customer is not checked in to checkout!!");
                }
                else 
                {

                    selectedItem.Status = "Finished";
                    selectedItem.CheckedIn = false;
                    _reservationService.UpdateReservation(selectedItem as Reservation);
                    populateReservationData();
                    MessageBox.Show("This user is now checked out!");
                }
              
            }
            else
            {
                MessageBox.Show("Please select a reservation");

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateReservationData();
        }
    }
}
