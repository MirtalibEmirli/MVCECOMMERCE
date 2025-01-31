using MVCECOMMERCE.Application.Abstarcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCECOMMERCE.DataAcces.Abstracts;
using MVCECOMMERCE.Domain.Entities;
namespace MVCECOMMERCE.Application.Concrete;

public class CategoryService(ICategoryDal categoryDal) : ICategoryService
{
    private readonly ICategoryDal _categoryDal = categoryDal;
    public List<Category> GetAll()
    {
        return _categoryDal.GetList();  
    }
}
