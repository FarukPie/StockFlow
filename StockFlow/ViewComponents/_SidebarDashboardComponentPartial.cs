using Microsoft.AspNetCore.Mvc;

namespace StockFlow.ViewComponents
{
    public class _SidebarDashboardComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
    
    
}
