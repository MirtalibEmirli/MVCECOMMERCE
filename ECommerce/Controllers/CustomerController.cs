using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers;

public class CustomerController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
