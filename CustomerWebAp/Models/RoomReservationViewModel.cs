using System.ComponentModel.DataAnnotations;

namespace CustomerWebApp.Models
{
    public class RoomReservationViewModel
    {
      public  RoomReservationViewModel()
        {
            StartOn = DateTime.Now;
            EndOn = DateTime.Now.AddDays(1);
        }
        public int RoomId { get; set; }

        public int CustomerId { get; set; }


        public int Beds { get; set; }

        public string Occupancy { get; set; }

        public string Layout { get; set; }

        public int Price { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]

        public DateTime? StartOn { get; set; }


        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? EndOn { get; set; }

       
    }
}
