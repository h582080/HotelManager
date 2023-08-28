using System;
using System.Collections.Generic;

namespace BLL.Models;

public  class Room
{
    public int RoomId { get; set; }


    public int? Beds { get; set; }

    public string? Occupancy { get; set; }

    public string? Layout { get; set; }

    public int? Price { get; set; }

    public int RoomNumber { get; set; }

}
