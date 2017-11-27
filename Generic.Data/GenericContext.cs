using Generic.Data.Configurations;
using Generic.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Data
{
    public class GenericContext : DbContext
    {
        public GenericContext()
           : base("GenericBD_Her")
        {
            Database.SetInitializer<GenericContext>(null);
        }

        #region Entity Sets
        public IDbSet<User> UserSet { get; set; }
        public IDbSet<Role> RoleSet { get; set; }
        public IDbSet<UserRole> UserRoleSet { get; set; }
        public IDbSet<Contatos> ContatosSet { get; set; }
        public IDbSet<DoctorUser> DoctorUserSet { get; set; }
        public IDbSet<AthleteUser> AthleteUserSet { get; set; }
        public IDbSet<Lesoes> LesoesSet { get; set; }
        public IDbSet<Gravidade> GravidadeSet { get; set; }
        public IDbSet<LadoLesao> LadoLesaoSet { get; set; }
        public IDbSet<LocalLesao> LocalLesaoSet { get; set; }
        public IDbSet<OcorrenciaLesao> OcorrenciaLesaoSet { get; set; }
        public IDbSet<TipoLesao> TipoLesaoSet { get; set; }
        public IDbSet<TiposTratamento> TiposTratamentoSet { get; set; }
        public IDbSet<Tratamento> TratamentoSet { get; set; }
        public IDbSet<Tratamento_TipoTratamento> Tratamento_TipoTratamentoSet { get; set; }
        public IDbSet<Especialidade> EspecialidadeSet { get; set; }
        public IDbSet<Profissional_Especialidade> Profissional_EspecialidadeSet { get; set; }
        public IDbSet<Instituicao> InstituicaoSet { get; set; }
        public IDbSet<Genero> GeneroSet { get; set; }
        #endregion

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new UserRoleConfiguration());
            modelBuilder.Configurations.Add(new RoleConfiguration());
            modelBuilder.Configurations.Add(new DoctorUserConfiguration());
            modelBuilder.Configurations.Add(new AthleteUserConfiguration());
            modelBuilder.Configurations.Add(new ContatosConfiguration());
            modelBuilder.Configurations.Add(new GravidadeConfiguration());
            modelBuilder.Configurations.Add(new LadoLesaoConfiguration());
            modelBuilder.Configurations.Add(new LesoesConfiguration());
            modelBuilder.Configurations.Add(new LocalLesaoConfiguration());
            modelBuilder.Configurations.Add(new OcorrenciaLesaoConfiguration());
            modelBuilder.Configurations.Add(new TipoLesaoConfiguration());
            modelBuilder.Configurations.Add(new TipoTratamentoConfiguration());
            modelBuilder.Configurations.Add(new TratamentoConfiguration());
            modelBuilder.Configurations.Add(new EspecialidadeConfiguration());
            modelBuilder.Configurations.Add(new InsituicaoConfiguration());
            modelBuilder.Configurations.Add(new GeneroConfiguration());
        }
    }
}
