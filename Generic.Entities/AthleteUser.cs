using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Entities
{
    [Table("AthleteUser")]
    public class AthleteUser : User
    {
        public AthleteUser()
        {
            Lesoes = new HashSet<Lesoes>();
        }
        public int Tipo { get; set; }
        public string CRA { get; set; }
        public virtual ICollection<Lesoes> Lesoes { get; set; }
    }
}
