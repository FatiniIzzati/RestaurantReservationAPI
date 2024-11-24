using Microsoft.AspNetCore.Mvc;

namespace RestaurantReservationAPI.Controllers
{
    public class FAQController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
