using CalismaSitesi.Core.DataAccess.EntityFramework;
using CalismaSitesi.DataAccess.Abstract;
using CalismaSitesi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalismaSitesi.DataAccess.Concrete
{
    public class EfCustomerDal:EfEntityRepositoryBase<Customer,CalismaSitesiContext>,ICustomerDal
    {
        public EfCustomerDal(CalismaSitesiContext context):base(context)
        {

        }
    }
}
