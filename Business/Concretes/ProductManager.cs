using DataAccess.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TobetoETrade.Concretes;

namespace Business.Concretes
{
    public class ProductManager
    {
        public void Add(Product product) 
        {
            AdoNetProductDal productDal = new AdoNetProductDal();
            productDal.Add(product);
        }
    }
}
