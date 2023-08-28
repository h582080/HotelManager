using BLL.Services;
using BLL.Services.Contracts;

namespace AdminDashboard
{
    public partial class MainAdministrationDashboard : Form
    {
        private readonly IReservationService _reservationService;
        private readonly IRoomService _roomService;
        private readonly ICustomerService _customerService;
        private readonly IServiceRequestService _requestService;
        public MainAdministrationDashboard()
        {
            InitializeComponent();
            _roomService = new RoomService();
            _reservationService = new ReservationService();
            _customerService = new CustomerService();
            _requestService = new ServiceRequestService();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            new RoomsManager(_roomService, _reservationService, _requestService).ShowDialog();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            new ReservationsManager(_reservationService).ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            new CustomersManager(_customerService).ShowDialog();
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            new ServiceRequestsForm(_requestService).ShowDialog();
        }
    }
}
