namespace Generic.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEspecialidadeProfissional1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Especialidade",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Profissional_Especialidade",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Especialidade_ID = c.Guid(),
                        Profissional_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Especialidade", t => t.Especialidade_ID)
                .ForeignKey("dbo.DoctorUser", t => t.Profissional_ID)
                .Index(t => t.Especialidade_ID)
                .Index(t => t.Profissional_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profissional_Especialidade", "Profissional_ID", "dbo.DoctorUser");
            DropForeignKey("dbo.Profissional_Especialidade", "Especialidade_ID", "dbo.Especialidade");
            DropIndex("dbo.Profissional_Especialidade", new[] { "Profissional_ID" });
            DropIndex("dbo.Profissional_Especialidade", new[] { "Especialidade_ID" });
            DropTable("dbo.Profissional_Especialidade");
            DropTable("dbo.Especialidade");
        }
    }
}
