using Generic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Data.Configurations
{
    public class OcorrenciaLesaoConfiguration : EntityBaseConfiguration<OcorrenciaLesao>
    {
        public OcorrenciaLesaoConfiguration()
        {
            Property(ur => ur.Name).IsRequired().HasMaxLength(30);
        }
    }
}
