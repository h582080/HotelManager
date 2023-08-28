using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Reservation
{
    public int CustomerId { get; set; }

    public int RoomId { get; set; }

    public DateTime? StartOn { get; set; }

    public DateTime? EndOn { get; set; }

    public string? Status { get; set; }

    public bool? CheckedIn { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Room Room { get; set; } = null!;
}
