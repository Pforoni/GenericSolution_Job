using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Entities
{
    public class Especialidade : IEntityBase
    {
        public Especialidade()
        {
            Profissional_Especialidade = new HashSet<Profissional_Especialidade>();
        }
        public Guid ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Profissional_Especialidade> Profissional_Especialidade { get; set; }

    }
}
