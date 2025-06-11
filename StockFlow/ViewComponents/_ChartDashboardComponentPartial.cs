using Microsoft.AspNetCore.Mvc;

namespace StockFlow.ViewComponents
{
    public class _ChartDashBoardComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
