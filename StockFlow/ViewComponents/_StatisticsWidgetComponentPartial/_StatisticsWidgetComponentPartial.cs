﻿using Microsoft.AspNetCore.Mvc;
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

            ViewBag.totalSumProductStock=_context.Products.Sum(x => x.ProductStock);
            ViewBag.averageProductStock=_context.Products.Average(x => x.ProductStock);
            ViewBag.averageProductPrice=_context.Products.Average(x => x.ProductPrice);

            ViewBag.biggerPriceThen1000ProductCount = _context.Products.Where(x => x.ProductPrice > 1000).Count();
            ViewBag.getIDIs4ProductName = _context.Products.Where(x => x.ProductID == 4).Select(y => y.ProductName).FirstOrDefault();
            ViewBag.stockCountBigger50AndSmaller100ProductCount = _context.Products.Where(x => x.ProductStock > 50 && x.ProductStock < 100).Count();
            return View();
        }
    }
}
