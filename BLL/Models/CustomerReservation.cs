using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class CustomerReservation : Reservation
    {
       
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Username { get; set; }

        public int? RoomNumber { get; set; }

    }
}
