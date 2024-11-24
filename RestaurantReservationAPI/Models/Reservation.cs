using System.ComponentModel.DataAnnotations;
namespace RestaurantReservationAPI.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }

        [Required]
        [MaxLength(50)]
        public string TableNumber { get; set; }

        public DateTime Date { get; set; }
        public override string ToString()
        {
            return $"Reservation ID: {ReservationID}, Table: {TableNumber}, Date and Time: {Date:yyyy-MM-dd HH:mm:ss}";
        }
    }
}
  