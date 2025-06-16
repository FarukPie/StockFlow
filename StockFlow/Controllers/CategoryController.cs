using Microsoft.AspNetCore.Mvc;

namespace StockFlow.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult CategoryList()
        {
            return View();
        }
    }
}
