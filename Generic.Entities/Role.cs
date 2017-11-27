using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Entities
{
    public class Role : IEntityBase
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
    }
}
