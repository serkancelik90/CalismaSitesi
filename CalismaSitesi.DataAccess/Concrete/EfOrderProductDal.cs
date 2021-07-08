using CalismaSitesi.Core.DataAccess.EntityFramework;
using CalismaSitesi.DataAccess.Abstract;
using CalismaSitesi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalismaSitesi.DataAccess.Concrete
{
    public class EfOrderProductDal:EfEntityRepositoryBase<OrderProduct,CalismaSitesiContext>,IOrderProductDal
    {
        public EfOrderProductDal(CalismaSitesiContext context):base(context)
        {

        }
    }
}
