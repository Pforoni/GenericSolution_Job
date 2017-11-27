using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Entities
{
    [Table("DoctorUser")]
    public class DoctorUser : User
    {        
        public int Tipo { get; set; }
        public string CRM { get; set; }

    }
}
