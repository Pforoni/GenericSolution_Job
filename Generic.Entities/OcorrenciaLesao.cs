using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Entities
{
    public class OcorrenciaLesao : IEntityBase
    {
        public OcorrenciaLesao()
        {
            Lesao = new List<Lesoes>();
        }
        public Guid ID { get; set; }
        public string Name { get; set; }
        public ICollection<Lesoes> Lesao { get; set; }
    }
}
