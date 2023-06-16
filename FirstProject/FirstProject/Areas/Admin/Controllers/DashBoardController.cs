using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Areas.Admin.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
