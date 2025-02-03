using ECommerce.Application.Abstarcts;
using MVCECOMMERCE.Domain.Entities;
using MVCECOMMERCE.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Concrete;

public class CartService : ICartService
{
    public void AddToCart(Cart cart, Product product)
    {
        CartLine line = cart.CartLines.FirstOrDefault(c => c.Product.ProductId == product.ProductId);
        if (line != null)
        {
            line.Quantity++;
        }
        else
        {
            cart.CartLines.Add(new CartLine { Quantity=1,Product=product});
        }
    }

    public List<CartLine> GetAllCartItems(Cart cart)
    {
        return cart.CartLines;
    }

    public void RemoveFromCart(Cart cart, int productId)
    {
        cart.CartLines.Remove(cart.CartLines.FirstOrDefault(cl=>cl.Product.ProductId==productId));  
    }
}
