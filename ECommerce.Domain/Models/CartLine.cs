using MVCECOMMERCE.Domain.Abstracts;
using MVCECOMMERCE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCECOMMERCE.Domain.Models;

public class CartLine
{
    public Product? Product { get; set; }
    public int Quantity { get; set; }
}
