using Microsoft.AspNetCore.Mvc;

namespace StockFlow.ViewComponents._StatisticsViewComponent
{
    public class _StatisticsWidgetComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
