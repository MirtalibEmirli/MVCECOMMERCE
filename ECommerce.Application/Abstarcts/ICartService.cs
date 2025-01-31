using MVCECOMMERCE.Domain.Entities;
using MVCECOMMERCE.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Abstarcts;

public interface ICartService
{
    void AddToCart(Cart cart, Product product);
    void RemoveFromCart(Cart cart, int productId);
    List<CartLine> GetAllCartItems(Cart cart);

}
