using Generic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Data.Configurations
{
    public class LesoesConfiguration : EntityBaseConfiguration<Lesoes>
    {
        public LesoesConfiguration()
        {
            Property(ur => ur.DataLesao).IsRequired();
            Property(ur => ur.Diagnostico).HasMaxLength(200);
        }
    }
}
