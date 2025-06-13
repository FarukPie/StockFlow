using Microsoft.AspNetCore.Mvc;
using StockFlow.Context;

namespace StockFlow.ViewComponents
{
    public class _TodoDashboardComponentPartial:ViewComponent
    {
        private readonly StoreContext _context;
public _TodoDashboardComponentPartial(StoreContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
           var value=_context.Todos.OrderByDescending(x=>x.TodoID).Take(6).ToList();
            return View(value);
        }
    }
}
