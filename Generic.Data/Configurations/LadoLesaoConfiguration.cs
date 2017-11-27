using Generic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Data.Configurations
{
    public class LadoLesaoConfiguration : EntityBaseConfiguration<LadoLesao>
    {
        public LadoLesaoConfiguration()
        {
            Property(ur => ur.Name).IsRequired().HasMaxLength(30);
        }
    }
}
