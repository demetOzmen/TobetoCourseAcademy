using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TobetoETrade.Concretes;

namespace DataAccess.Concretes
{
    public class AdoNetProductDal
    {
        public void Add(Product product) 
        {
            Console.WriteLine("Ado .Net kullanılarak veri tabanına eklendi.");
        }
    }
}
