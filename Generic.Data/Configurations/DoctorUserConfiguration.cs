using Generic.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Data.Configurations
{
    public class DoctorUserConfiguration : EntityBaseConfiguration<DoctorUser>
    {
        public DoctorUserConfiguration()
        {
            Property(ur => ur.Tipo).IsRequired();
            Property(u => u.CRM).HasMaxLength(15);
        }

    }
}
