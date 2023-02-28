using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Hotels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int hotelID { get; set; }
        public string hotelName { get; set;}
        public string hotelAddress { get; set;}
        public string hotelCity { get; set;}
        public int hotelRatings { get; set; }
        public int roomAvailability { get; set;}

    }
}
