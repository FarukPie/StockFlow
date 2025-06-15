using Microsoft.AspNetCore.Mvc;
using StockFlow.Context;

namespace StockFlow.ViewComponents._StatisticsViewComponent
{
    public class _StatisticsWidgetComponentPartial : ViewComponent
    {
        private readonly StoreContext _context;

        public _StatisticsWidgetComponentPartial(StoreContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.CategoryCount= _context.Categories.Count();
            ViewBag.ProductMaxPrice = _context.Products.Max(x => x.ProductPrice);
            ViewBag.ProductMinPrice = _context.Products.Min(x => x.ProductPrice);
            ViewBag.ProductMaxPriceProduct=_context.Products.Where(x=>x.ProductPrice==(_context.Products.Max(x=>x.ProductPrice))).Select(x=>x.ProductName).FirstOrDefault();
            ViewBag.ProductMinPriceProduct=_context.Products.Where(x=>x.ProductPrice==(_context.Products.Min(x=>x.ProductPrice))).Select(x=>x.ProductName).FirstOrDefault();
            return View();
        }
    }
}
