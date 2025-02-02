using ECommerce.Application.Abstarcts;
 
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCECOMMERCE.DataAcces.Abstracts;
using ECommerce.DataAcces.Abstracts;

namespace ECommerce.Application.Concrete
{
    public class CustomerService(ICustomerDal customerDal) :ICustomerService
    {
        private readonly  ICustomerDal _customerDal= customerDal;
    }
}
