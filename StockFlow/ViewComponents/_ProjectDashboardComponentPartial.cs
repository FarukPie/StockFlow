using Microsoft.AspNetCore.Mvc;
using StockFlow.Context;

namespace StockFlow.ViewComponents
{
    public class _ProjectDashboardComponentPartial : ViewComponent

    {
        private readonly StoreContext _context;

        public _ProjectDashboardComponentPartial(StoreContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
           
            return View();
        }

    }
}