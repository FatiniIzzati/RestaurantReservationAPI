using Microsoft.AspNetCore.Mvc;

namespace RestaurantReservationAPI.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
