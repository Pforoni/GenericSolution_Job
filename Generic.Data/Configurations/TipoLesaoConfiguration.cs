using Generic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Data.Configurations
{
    public class TipoLesaoConfiguration : EntityBaseConfiguration<TipoLesao>
    {
        public TipoLesaoConfiguration()
        {
            Property(ur => ur.Name).IsRequired().HasMaxLength(30);
        }
    }
}
