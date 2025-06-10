using Microsoft.AspNetCore.Mvc;

namespace StockFlow.ViewComponents
{
    public class _NavbarDashboardComponentPartial: ViewComponent
    {
      public IViewComponentResult Invoke()
      {
          return View();
        }



    }
}
