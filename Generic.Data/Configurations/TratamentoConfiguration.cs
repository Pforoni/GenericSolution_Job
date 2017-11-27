using Generic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Data.Configurations
{
    public class TratamentoConfiguration : EntityBaseConfiguration<Tratamento>
    {
        public TratamentoConfiguration()
        {
            Property(ur => ur.Observacoes).IsRequired().HasMaxLength(200);
        }
    }
}
