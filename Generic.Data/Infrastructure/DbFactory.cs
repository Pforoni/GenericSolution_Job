using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        GenericContext dbContext;

        public GenericContext Init()
        {
            return dbContext ?? (dbContext = new GenericContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }

        
    }
}
