//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BancoDados
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contatos
    {
        public int Id { get; set; }
        public string FoneResidencial { get; set; }
        public string FoneComercial { get; set; }
        public string Celular { get; set; }
        public Nullable<bool> IsEmergencia { get; set; }
        public string Nome { get; set; }
        public Nullable<int> IdUser { get; set; }
        public Nullable<int> IdProfissional { get; set; }
    
        public virtual Atleta Atleta { get; set; }
        public virtual Profissional Profissional { get; set; }
    }
}
