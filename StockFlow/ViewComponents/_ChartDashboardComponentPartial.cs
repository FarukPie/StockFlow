using Microsoft.AspNetCore.Mvc;

namespace StockFlow.ViewComponents
{
    public class _ChartDashboardComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
