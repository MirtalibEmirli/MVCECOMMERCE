
using MVCECOMMERCE.Domain.Entities;
using MVCECOMMERCE.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAcces.Abstracts
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
    }
}
