using System;

namespace Generic.Entities
{
    public class Lesoes : IEntityBase
    {
        public Guid ID { get; set; }
        public System.DateTime DataLesao { get; set; }
        public string Diagnostico { get; set; }
    }
}