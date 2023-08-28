using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class RoomQuery
    {
       
      
        public DateTime StartOn { get; set; }
        public DateTime EndOn { get; set; }
        public string RoomLayout { get; set; }
        public int PriceMin { get; set; }
        public int PriceMax { get; set; }
        public int BedsMin { get; set; }
        public int BedsMax { get; set; }
        public string RoomOccupancy { get; set; }
     


    }
}
