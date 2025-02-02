using ECommerce.DataAcces.Abstracts;
using MVCECOMMERCE.Domain.Entities;
using MVCECOMMERCE.Repository.Infrastructure.EntityFrameworkAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAcces.Concrete.EfEntityFramework;

public class EFIOrderDetailDal : EFEntityRepositoryBase<OrderDetail, EcommerceContext>,IOrderDetailDal

{  
    
}
