using MVCECOMMERCE.Domain.Entities;
using MVCECOMMERCE.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCECOMMERCE.DataAcces.Abstracts;

public interface IProductDal : IEntityRepository<Product>
{
}
