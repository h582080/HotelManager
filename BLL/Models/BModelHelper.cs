using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public static class BModelHelper
    {
        //public int Id { get; set; }
        //public string Title { get; set; }
        //public WorkType(int i, string t)
        //{ Id = i; Title = t; }
        
        public static List<string> GetWorkTypes()
        {
           return new List<string>
            {
                "Cleaning",
                "RoomService",
                "Maintenance"
            };
        }

        public static List<string> GetStatusUpdates()
        {
            return new List<string>
            {
                "InProgress",
                "Finished",
            };
        }

        public static List<string> GetRoomLayouts()
        {
            return new List<string>
            {
                "Standard",
                "Joint",
                "Connecting",
                "Suite"
            };
        }

        public static List<string> GetRoomOccupancy()
        {
            return new List<string>
            {
                "Single",
                "Double",
                "Triple",
                "Quad"
            };
        }
    };
}
