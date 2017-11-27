using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Entities
{
    public class Tratamento : IEntityBase
    {
        public Tratamento()
        {
            Tratamento_TipoTratamento = new List<Tratamento_TipoTratamento>();
            
        }
        public Guid ID { get; set; }
        public string Observacoes { get; set; }
        public Nullable<bool> TratamentoFinalizado { get; set; }
        public  Lesoes Lesoes { get; set; }
        public ICollection<Tratamento_TipoTratamento> Tratamento_TipoTratamento { get; set; }
    }
}
