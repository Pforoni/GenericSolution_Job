using System;

namespace Generic.Entities
{
    public class Tratamento_TipoTratamento : IEntityBase
    {
        public Guid ID { get; set; }
        //public int IdTratamento { get; set; }
        //public int IdTipoTratamento { get; set; }

        public virtual TiposTratamento TiposTratamento { get; set; }
        public virtual Tratamento Tratamento { get; set; }
    }
}