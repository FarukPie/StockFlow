using Microsoft.AspNetCore.Mvc;

namespace StockFlow.ViewComponents
{
    public class _SaleStatusComponentPartial: ViewComponent

    {
        public  IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}
