using MVCECOMMERCE.Application.Abstarcts;
using MVCECOMMERCE.DataAcces.Abstracts;
using MVCECOMMERCE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCECOMMERCE.Application.Concrete;

public class ProductService(IProductDal productDal) : IProductService
{
    private readonly IProductDal _productDal = productDal;
    public void Add(Product product)
    {
        _productDal.Add(product);
    }

    public void Delete(int id)
    {
        var product = _productDal.Get(p => p.ProductId == id);
        _productDal.Delete(product);
    }

    public List<Product> GetAll()
    {
        return _productDal.GetList();
    }

    public List<Product> GetAllByCategory(int CategoryId)
    {
        return _productDal.GetList(p=>p.CategoryId == CategoryId||CategoryId==0);  
    }

    public Product GetById(int id)
    {

        return _productDal.Get(p => p.ProductId == id);
    }

    public void Update(Product product)
    {
        _productDal.Update(product);
    }
}
