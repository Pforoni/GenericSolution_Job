using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Entities
{
    public interface IEntityBase
    {
        Guid ID { get; set; }
    }
    //public abstract class IEntityBase
    //{
    //    public Guid ID { get; protected set; }
    //}
}
