 
using Microsoft.AspNetCore.Mvc;
using MVCECOMMERCE.Application.Abstarcts;

namespace ECommerce.ViewComponents
{
    public class CategoryListViewComponent(ICategoryService categoryService) : ViewComponent
    {
        private readonly ICategoryService _categoryService = categoryService;

        public IViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }
    }
}
