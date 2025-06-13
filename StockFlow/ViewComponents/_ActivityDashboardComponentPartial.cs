using Microsoft.AspNetCore.Mvc;
using StockFlow.Context;

namespace StockFlow.ViewComponents
{
    public class _ActivityDashboardComponentPartial:ViewComponent
    {
        private readonly StoreContext _storeContext;

        public _ActivityDashboardComponentPartial(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        public IViewComponentResult Invoke()
        {
            var value = _storeContext.Activities.ToList();
            return View(value);
            
        }
    }
}
