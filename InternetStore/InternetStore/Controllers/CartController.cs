using InternetStore.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InternetStore.Entities;
using InternetStore.Models;
using Newtonsoft.Json;
namespace InternetStore.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View(new CartIndexViewModel
            {
                Cart = GetCart()
            });
        }

        public IActionResult AddToCart(ProductModel model)
        {
            
            if (model != null)
            {
                var cart = GetCart();
                cart.AddItem(model, 1);
                HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(cart));

            }
            return RedirectToAction("Index");
        }

        public Cart GetCart()
        {
            Cart cart = null;
            var cartSerializated = HttpContext.Session.GetString("Cart");

            if (!string.IsNullOrEmpty(cartSerializated))
            {
                cart = JsonConvert.DeserializeObject<Cart>(cartSerializated);
                return cart;
            }

            if (cart == null)
            {
                cart = new Cart();
                HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(cart));
            }
            return cart;
        }
    }
}
