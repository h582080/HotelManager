using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Room
{
    public int RoomId { get; set; }

    public int? Beds { get; set; }

    public string? Occupancy { get; set; }

    public string? Layout { get; set; }

    public int? Price { get; set; }

    public int RoomNumber { get; set; }

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    public virtual ICollection<ServiceRequest> ServiceRequestRoomNumberNavigations { get; set; } = new List<ServiceRequest>();

    public virtual ICollection<ServiceRequest> ServiceRequestRooms { get; set; } = new List<ServiceRequest>();
}
