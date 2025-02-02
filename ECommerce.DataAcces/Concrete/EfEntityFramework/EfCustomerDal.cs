using MVCECOMMERCE.Repository.Infrastructure.EntityFrameworkAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCECOMMERCE.Domain.Entities;
using ECommerce.DataAcces.Abstracts;

namespace ECommerce.DataAcces.Concrete.EfEntityFramework;

public class EfCustomerDal:EFEntityRepositoryBase<Customer,EcommerceContext>,ICustomerDal
{

}
