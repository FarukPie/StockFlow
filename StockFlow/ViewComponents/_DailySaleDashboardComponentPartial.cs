using Microsoft.AspNetCore.Mvc;

namespace StockFlow.ViewComponents
{
    public class _DailySaleDashboardComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
