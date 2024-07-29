using DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace E_TicaretSite.Web.ViewComponents
{
    public class CartCount : ViewComponent
    {
        DataContext c = new DataContext();
        public IViewComponentResult Invoke()
        {
            var cart = c.Carts.Where(x => x.Statu == true).Count();
            ViewBag.Cart = cart;
            return View();
        }
    }
}
