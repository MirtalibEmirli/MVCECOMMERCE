using ECommerce.Application.Abstarcts;
using Microsoft.AspNetCore.Mvc;
using MVCECOMMERCE.Application.Abstarcts;
using MVCECOMMERCE.Domain.Models;

namespace ECommerce.Controllers;
public class CartController(ICartSessionService cartSessionService, IProductService productService, ICartService cartService) : Controller
{
    private readonly ICartSessionService _cartSessionService = cartSessionService;
    private readonly IProductService _productService = productService;
    private readonly ICartService _cartService = cartService;
    public IActionResult AddToCart(int productId)
    {
        var productToBeAdded = _productService.GetById(productId);
        var cart = _cartSessionService.GetCart();
        _cartService.AddToCart(cart, productToBeAdded);
        _cartSessionService.SetCart(cart);
        TempData["message"] = string.Format("Your Product ,{0} was added to cart", productToBeAdded.ProductName);

        return RedirectToAction("Index", "Product");
    }
    public IActionResult List()
    {
        var cart = _cartSessionService.GetCart();
        var model = new CartlistViewModel
        {
            Cart = cart
        };
        return View(model);
    }
    public IActionResult Remove(int productId)
    {
        var cart = _cartSessionService.GetCart();
        _cartService.RemoveFromCart(cart, productId);
        _cartSessionService.SetCart(cart);
        TempData["message"] = string.Format($"Your Product removed from card");
        return RedirectToAction("Index", "Product");
    }

    [HttpGet]
    public IActionResult Complete()
    {
        var shippingDetailsViewModel = new ShippingDetailsViewModel
        {
            ShippingDetails = new ShippingDetails { Address = string.Empty,
                Age = 15, City = string.Empty, Email = string.Empty, FirstName = string.Empty, LastName = string.Empty }
        };
        return View(shippingDetailsViewModel);
    }
    [HttpPost]
    public IActionResult Complete(ShippingDetailsViewModel shippingDetailsViewModel)
    {
        if (ModelState.IsValid)

        {
            return View();
        }

        TempData.Add("message", string.Format("thank you for buying"));
        return View();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           

    }
} 