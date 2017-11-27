using Generic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Data.Configurations
{
    public class ContatosConfiguration : EntityBaseConfiguration<Contatos>
    {
        public ContatosConfiguration()
        {
            Property(ur => ur.FoneResidencial).HasMaxLength(15);
            Property(ur => ur.FoneComercial).HasMaxLength(15);
            Property(ur => ur.Celular).HasMaxLength(15);
            Property(ur => ur.Nome).HasMaxLength(50);
        }
    }
}
