﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ManagementAthletesEntities : DbContext
    {
        public ManagementAthletesEntities()
            : base("name=ManagementAthletesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Atleta> Atleta { get; set; }
        public virtual DbSet<Contatos> Contatos { get; set; }
        public virtual DbSet<Especialidade> Especialidade { get; set; }
        public virtual DbSet<Gravidade> Gravidade { get; set; }
        public virtual DbSet<LadoLesao> LadoLesao { get; set; }
        public virtual DbSet<Lesoes> Lesoes { get; set; }
        public virtual DbSet<LocalLesao> LocalLesao { get; set; }
        public virtual DbSet<Ocorrencia> Ocorrencia { get; set; }
        public virtual DbSet<Profissional> Profissional { get; set; }
        public virtual DbSet<Profissional_Especialidade> Profissional_Especialidade { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TipoLesao> TipoLesao { get; set; }
        public virtual DbSet<TiposTratamento> TiposTratamento { get; set; }
        public virtual DbSet<Tratamento> Tratamento { get; set; }
        public virtual DbSet<Tratamento_TipoTratamento> Tratamento_TipoTratamento { get; set; }
    }
}
