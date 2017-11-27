using Generic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Data.Configurations
{
    public class LocalLesaoConfiguration : EntityBaseConfiguration<LocalLesao>
    {
        public LocalLesaoConfiguration()
        {
            Property(ur => ur.Name).IsRequired().HasMaxLength(30);
        }
    }
}
