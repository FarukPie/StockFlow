using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockFlow.Context;

namespace StockFlow.ViewComponents
{
    public class _SaleDataDashboardComponentPartial: ViewComponent
    {
        private readonly StoreContext _context;

        public _SaleDataDashboardComponentPartial(StoreContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {

            var degerler = _context.Orders.OrderByDescending(x=>x.OrderID).Include(x=>x.Customer).Include(x => x.Product).Take(5).ToList();
            return View(degerler);
        }
    }
}
