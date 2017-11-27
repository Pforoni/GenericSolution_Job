using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Entities
{
    public class TiposTratamento : IEntityBase
    {
        public TiposTratamento()
        {
            Tratamento_TipoTratamento = new List<Tratamento_TipoTratamento>();
        }
        public Guid ID { get; set; }
        public string Name { get; set; }
        public ICollection<Tratamento_TipoTratamento> Tratamento_TipoTratamento { get; set; }
    }
}
