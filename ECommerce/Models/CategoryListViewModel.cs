using MVCECOMMERCE.Domain.Entities;

namespace ECommerce;

public class CategoryListViewModel
{
    public List<Category> Categories { get; set; }
    public int CurrentCategory { get; set; }
}