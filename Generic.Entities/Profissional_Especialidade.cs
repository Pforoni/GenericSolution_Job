using System;

namespace Generic.Entities
{
    public class Profissional_Especialidade : IEntityBase
    {
        public Guid ID { get; set; }
        public virtual Especialidade Especialidade { get; set; }
        public virtual DoctorUser Profissional { get; set; }
    }
}