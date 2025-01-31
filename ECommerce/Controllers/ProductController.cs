using Microsoft.AspNetCore.Mvc;
using MVCECOMMERCE.Application.Abstarcts;
using MVCECOMMERCE.Application.Concrete;
using MVCECOMMERCE.Domain.Entities;

namespace ECommerce.Controllers;

public class ProductController(IProductService prouductService, ICategoryService categoryService) : Controller
{
    private readonly IProductService _productService = prouductService;
    private readonly ICategoryService _categoryService = categoryService;

    public IActionResult Index(int page = 1, int categoryId = 0)
    {
        int pageSize = 10;
        var products = _productService.GetAllByCategory(categoryId);
        //bax
        var pagedProducts = products.Skip((page - 1) * pageSize).Take(pageSize).ToList();

        var model = new ProductListViewModel
        {
            CurrentCategory = categoryId,
            PageCount = (int)Math.Ceiling(products.Count / (double)(pageSize)),
            PageSize = pageSize,
            CurrentPage = page,
            Products = pagedProducts

        };
        return View(model);
    }
    ///abstractla interface ferqi
    [HttpGet]
    public IActionResult Add()
    {
        var model = new ProductAddViewModel();
        model.Product = new Product();
        model.Categories = _categoryService.GetAll();
        return View(model);
    }
    [HttpPost]
    public IActionResult Add(ProductAddViewModel model)
    {
        _productService.Add(model.Product);
        return RedirectToAction("Index");
    }

}
