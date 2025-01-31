using MVCECOMMERCE.Domain.Models;

namespace ECommerce;

public interface ICartSessionService
{
    Cart GetCart();
    void SetCart(Cart cart);
}
