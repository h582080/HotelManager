using BLL.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CustomerWebApp.Models
{
    public class RoomSearchModel
    {
        public RoomSearchModel()
        {
            SearchResults = new List<Room>();
            RoomLayout = "All";
            RoomOccupancy = "All";
            PriceMin = 200;
            PriceMax = 800;
            BedsMin = 1;
            BedsMax = 8;
            StartOn = DateTime.Now;
            EndOn = DateTime.Now.AddDays(1);
        }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
         public DateTime StartOn { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime EndOn { get; set; }

       

        public string RoomLayout { get; set; }
        public SelectList RoomLayoutList { 
            get {
                var values = BModelHelper.GetRoomLayouts();
                values.Add("All");
                values.Sort();
                return new SelectList(values);
            } 
        }

        public int PriceMin { get; set; }

        public int PriceMax { get; set; }

        public int BedsMin { get; set; }

        public int BedsMax { get; set; }
        public string RoomOccupancy { get; set; }
        public SelectList RoomOccupancyList {
            get
            {
                var values = BModelHelper.GetRoomOccupancy();
                values.Add("All");
                values.Sort();
                return new SelectList(values);
            }
        }


        public List<Room> SearchResults { get; set; }

    }
}
