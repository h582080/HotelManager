using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ServiceRequest
{
    public int ServiceRequestId { get; set; }

    public DateTime? RequestDate { get; set; }

    public string? Status { get; set; }

    public string? Notes { get; set; }

    public string? ServiceType { get; set; }

    public int RoomId { get; set; }

    public int RoomNumber { get; set; }

    public virtual Room Room { get; set; } = null!;

    public virtual Room RoomNumberNavigation { get; set; } = null!;
}
