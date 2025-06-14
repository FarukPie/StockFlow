using Microsoft.AspNetCore.Mvc;

namespace StockFlow.Controllers
{
    public class DashboardController1 : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Statistic() 
        { 
        return View();

        }
    }
}
