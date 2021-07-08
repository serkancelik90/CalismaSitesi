using System;
using System.Collections.Generic;
using System.Text;

namespace CalismaSitesi.Core.DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
        void Rollback();
    }

}
