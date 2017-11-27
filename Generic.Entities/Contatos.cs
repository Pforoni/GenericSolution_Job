using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Entities
{
    public class Contatos : IEntityBase
    {
        public Guid ID { get; set; }
        public string FoneResidencial { get; set; }
        public string FoneComercial { get; set; }
        public string Celular { get; set; }
        public Nullable<bool> IsEmergencia { get; set; }
        public string Nome { get; set; }
        public  User Usurario { get; set; }
    }
}
