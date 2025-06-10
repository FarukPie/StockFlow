using Microsoft.AspNetCore.Mvc;

namespace StockFlow.ViewComponents
{
    public class _RightSidebarDashboardComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

} }
