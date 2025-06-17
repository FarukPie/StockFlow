using Microsoft.AspNetCore.Mvc;
using StockFlow.Context;

namespace StockFlow.Controllers
{
    public class CategoryController : Controller
    {
        private readonly StoreContext _context;
        public CategoryController(StoreContext context)
        {
            _context = context;
        }

        public IActionResult CategoryList()
        {
            var value=_context.Categories.ToList();
            return View(value);
        }
    }
}
