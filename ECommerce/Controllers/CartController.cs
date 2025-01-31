using Microsoft.AspNetCore.Mvc;
using MVCECOMMERCE.Application.Abstarcts;

namespace ECommerce.Controllers;
public class CartController(ICartSessionService cartSessionService, IProductService productService) : Controller
{
    private readonly ICartSessionService _cartSessionService;
    private readonly IProductService _productService;
    public IActionResult Index()
    {
        return View();
    }
}