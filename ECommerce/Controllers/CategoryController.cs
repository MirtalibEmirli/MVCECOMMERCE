using Microsoft.AspNetCore.Mvc;
using MVCECOMMERCE.Application.Abstarcts;

namespace ECommerce.Controllers;

public class CategoryController(ICategoryService categoryService) : Controller
{
    private readonly ICategoryService _categoryService = categoryService;
    public IActionResult Index()
    {
        var category = _categoryService.GetAll();
        return Json(category);
    }
} //Request ilk once gedir Service layer
  //2.DataAccesLayer
  //3.
  //4.
