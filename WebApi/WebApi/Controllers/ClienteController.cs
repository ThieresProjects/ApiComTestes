using Microsoft.AspNetCore.Mvc;

namespace Domain.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
