﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Entities
{
    public class LocalLesao : IEntityBase
    {
        public LocalLesao()
        {
            Lesao = new List<Lesoes>();
        }
        public Guid ID { get; set; }
        public string Name { get; set; }
        public ICollection<Lesoes> Lesao { get; set; }
    }
}
