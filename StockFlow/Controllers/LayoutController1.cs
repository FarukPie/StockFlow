using Microsoft.AspNetCore.Mvc;

namespace StockFlow.Controllers
{
    public class LayoutController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
