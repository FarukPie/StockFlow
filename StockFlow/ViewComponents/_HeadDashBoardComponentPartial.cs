using Microsoft.AspNetCore.Mvc;

namespace StockFlow.ViewComponents
{
    public class _HeadDashBoardComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
