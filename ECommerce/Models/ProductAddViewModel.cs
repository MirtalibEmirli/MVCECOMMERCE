using MVCECOMMERCE.Domain.Entities;

namespace ECommerce;

public class ProductAddViewModel
{
    public Product Product { get; set; }
    public List<Category> Categories { get; set; }
}