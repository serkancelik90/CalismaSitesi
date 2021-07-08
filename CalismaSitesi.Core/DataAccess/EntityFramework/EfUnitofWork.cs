using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalismaSitesi.Core.DataAccess.EntityFramework
{
    public class EfUnitofWork<TContext> : IUnitOfWork where TContext:DbContext,new()
    {
        private readonly TContext _context;
        public int Commit()
        {
           return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Rollback()
        {
            _context.ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
        }
    }
}
