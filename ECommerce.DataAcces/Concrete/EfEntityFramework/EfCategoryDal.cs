using MVCECOMMERCE.DataAcces.Abstracts;
using MVCECOMMERCE.Domain.Entities;
using MVCECOMMERCE.Repository.Infrastructure.EntityFrameworkAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCECOMMERCE.DataAcces.Concrete.EfEntityFramework;

//burda gedib spesifik crud a catr
public class EFCategoryDal : EFEntityRepositoryBase<Category, EcommerceContext>, ICategoryDal
{
}
