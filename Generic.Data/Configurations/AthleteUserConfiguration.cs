using Generic.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Data.Configurations
{
    public class AthleteUserConfiguration : EntityBaseConfiguration<AthleteUser>
    {
        public AthleteUserConfiguration()
        {
            Property(ur => ur.Tipo).IsRequired();
            Property(u => u.CRA).HasMaxLength(15);
        }
    }
}
