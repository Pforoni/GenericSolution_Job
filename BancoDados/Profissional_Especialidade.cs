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
    
    public partial class Profissional_Especialidade
    {
        public int Id { get; set; }
        public int IdProfissional { get; set; }
        public int IdEspecialidade { get; set; }
    
        public virtual Especialidade Especialidade { get; set; }
        public virtual Profissional Profissional { get; set; }
    }
}
