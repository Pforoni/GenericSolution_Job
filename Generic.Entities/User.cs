using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Entities
{
    public abstract class User : IEntityBase
    {
        public User()
        {
            UserRoles = new List<UserRole>();
            ContatosUser = new List<Contatos>();
        }
        public Guid ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public string Salt { get; set; }
        public bool IsLocked { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateNasc { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Naturalidade { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<Contatos> ContatosUser { get; set; }
        public Guid Genero_Id { get; set; }
        //public Genero Genero { get; set; }

    }
}
