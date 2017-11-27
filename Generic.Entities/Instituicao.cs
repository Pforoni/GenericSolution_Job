using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Entities
{
    public class Instituicao : IEntityBase
    {
        public Instituicao()
        {
            User = new List<User>();
        }
        public Guid ID { get; set; }
        public string Name { get; set; }
        public ICollection<User> User { get; set; }
    }

}
