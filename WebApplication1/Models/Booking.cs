using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Booking
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int bookingID { get; set; }
        public string fullName { get; set; }
        public string customerAddress { get; set; }
        public string customerCity { get; set; }
        public string customerEmail { get; set; }

        public string customerPhone { get; set; }
        public string fromDate { get; set; }
        public string toDate { get; set; }
        public int roomsBooked { get; set; }
        public int creditCardNo { get; set; }
        public int hotelID { get; set; }

    }
}
