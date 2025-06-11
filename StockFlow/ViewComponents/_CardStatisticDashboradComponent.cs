using Microsoft.AspNetCore.Mvc;
using StockFlow.Context;
using System.Globalization;

namespace StockFlow.ViewComponents
{
    public class _CardStatisticDashboradComponent : ViewComponent
    {
        private readonly StoreContext _storeContext;

        public _CardStatisticDashboradComponent(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.TotalCustomerCount= _storeContext.Customers.Count();
            ViewBag.TotalProductCount= _storeContext.Products.Count();
            ViewBag.TotalCategoryCount= _storeContext.Categories.Count();
            ViewBag.AvgCustomerBalance= _storeContext.Customers.Average(c => c.CustomerBalance).ToString("N1");
            ViewBag.TotalOrderCount= _storeContext.Orders.Count();
            ViewBag.SumOrderProductCount = _storeContext.Orders.Sum(x => x.OrderCount);
            return View();
        }
    }
}
