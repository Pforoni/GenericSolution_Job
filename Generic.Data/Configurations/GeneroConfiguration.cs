using Generic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Data.Configurations
{
    public class GeneroConfiguration : EntityBaseConfiguration<Genero>
    {
        public GeneroConfiguration()
        {
            Property(ur => ur.Name).IsRequired().HasMaxLength(30);
        }
    }
}
