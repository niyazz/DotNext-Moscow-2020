using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using InternetStore.Entities;
using Newtonsoft.Json;
using InternetStore.Models;
using InternetStore.Database;
using Microsoft.EntityFrameworkCore;
using InternetStore.Enums;

namespace InternetStore.Controllers
{
    public class OrderController : Controller
    {

        private ApplicationDbContext _context;
        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var orders = _context.Orders.Include(x => x.OrderToProduct)
                 .ThenInclude(sc => sc.Product)
                 .AsNoTracking()
                 .ToList();
            var statuses = Enum.GetValues(
               typeof(OrderStatus)).Cast<OrderStatus>().ToList();

            ViewBag.Statuses = statuses;

            return View(orders);
        }

        public async Task<IActionResult> CreateOrder(CartIndexViewModel model)
        {
            Cart cart = JsonConvert.DeserializeObject<Cart>(HttpContext.Session.GetString("Cart"));

            if(cart != null)
            {
                Order newOrder = new Order(cart, model.CustomerPassportNumber);

                foreach (var item in cart.Lines)
                {
                    newOrder.OrderToProduct.Add(
                        new OrderToProduct {
                            Order = newOrder, 
                            ProductId = item.Product.Id, 
                            Quanity = item.Quantity
                        });
                }
                await _context.AddAsync(newOrder);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");

        }

        public async Task<IActionResult> UpdateOrder(OrderEditModel model)
        {
            var orderToEdit = await _context.Orders
                .Where(_ => _.Id == model.Id)
                .FirstOrDefaultAsync();

            if(orderToEdit != null)
            {
                orderToEdit.Status = model.Status;
            }

            _context.Update(orderToEdit);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }
}
