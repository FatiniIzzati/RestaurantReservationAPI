using Microsoft.EntityFrameworkCore;
using RestaurantReservationAPI.Models;

namespace RestaurantReservationAPI.Data
{
    public class RestaurantReservationContext : DbContext
    {
        public RestaurantReservationContext(DbContextOptions <RestaurantReservationContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

    }
}
