using Microsoft.AspNetCore.Mvc;

namespace StockFlow.ViewComponents
{
    public class _CardStatisticDashboradComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
