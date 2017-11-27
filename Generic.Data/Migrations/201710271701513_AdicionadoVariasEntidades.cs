namespace Generic.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionadoVariasEntidades : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Lesoes");
            CreateTable(
                "dbo.LadoLesao",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LocalLesao",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OcorrenciaLesao",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TipoLesao",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TiposTratamento",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tratamento_TipoTratamento",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        TiposTratamento_ID = c.Guid(),
                        Tratamento_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TiposTratamento", t => t.TiposTratamento_ID)
                .ForeignKey("dbo.Tratamento", t => t.Tratamento_ID)
                .Index(t => t.TiposTratamento_ID)
                .Index(t => t.Tratamento_ID);
            
            CreateTable(
                "dbo.Tratamento",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        Observacoes = c.String(nullable: false, maxLength: 200),
                        TratamentoFinalizado = c.Boolean(),
                        Lesoes_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Lesoes", t => t.Lesoes_ID)
                .Index(t => t.Lesoes_ID);
            
            AddColumn("dbo.Lesoes", "DataLesao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Lesoes", "Diagnostico", c => c.String(maxLength: 200));
            AddColumn("dbo.Lesoes", "LadoLesao_ID", c => c.Guid());
            AddColumn("dbo.Lesoes", "LocalLesao_ID", c => c.Guid());
            AddColumn("dbo.Lesoes", "OcorrenciaLesao_ID", c => c.Guid());
            AddColumn("dbo.Lesoes", "TipoLesao_ID", c => c.Guid());
            AlterColumn("dbo.Gravidade", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Lesoes", "ID", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Lesoes", "ID");
            CreateIndex("dbo.Lesoes", "LadoLesao_ID");
            CreateIndex("dbo.Lesoes", "LocalLesao_ID");
            CreateIndex("dbo.Lesoes", "OcorrenciaLesao_ID");
            CreateIndex("dbo.Lesoes", "TipoLesao_ID");
            AddForeignKey("dbo.Lesoes", "LadoLesao_ID", "dbo.LadoLesao", "ID");
            AddForeignKey("dbo.Lesoes", "LocalLesao_ID", "dbo.LocalLesao", "ID");
            AddForeignKey("dbo.Lesoes", "OcorrenciaLesao_ID", "dbo.OcorrenciaLesao", "ID");
            AddForeignKey("dbo.Lesoes", "TipoLesao_ID", "dbo.TipoLesao", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tratamento_TipoTratamento", "Tratamento_ID", "dbo.Tratamento");
            DropForeignKey("dbo.Tratamento", "Lesoes_ID", "dbo.Lesoes");
            DropForeignKey("dbo.Tratamento_TipoTratamento", "TiposTratamento_ID", "dbo.TiposTratamento");
            DropForeignKey("dbo.Lesoes", "TipoLesao_ID", "dbo.TipoLesao");
            DropForeignKey("dbo.Lesoes", "OcorrenciaLesao_ID", "dbo.OcorrenciaLesao");
            DropForeignKey("dbo.Lesoes", "LocalLesao_ID", "dbo.LocalLesao");
            DropForeignKey("dbo.Lesoes", "LadoLesao_ID", "dbo.LadoLesao");
            DropIndex("dbo.Tratamento", new[] { "Lesoes_ID" });
            DropIndex("dbo.Tratamento_TipoTratamento", new[] { "Tratamento_ID" });
            DropIndex("dbo.Tratamento_TipoTratamento", new[] { "TiposTratamento_ID" });
            DropIndex("dbo.Lesoes", new[] { "TipoLesao_ID" });
            DropIndex("dbo.Lesoes", new[] { "OcorrenciaLesao_ID" });
            DropIndex("dbo.Lesoes", new[] { "LocalLesao_ID" });
            DropIndex("dbo.Lesoes", new[] { "LadoLesao_ID" });
            DropPrimaryKey("dbo.Lesoes");
            AlterColumn("dbo.Lesoes", "ID", c => c.Guid(nullable: false));
            AlterColumn("dbo.Gravidade", "Name", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Lesoes", "TipoLesao_ID");
            DropColumn("dbo.Lesoes", "OcorrenciaLesao_ID");
            DropColumn("dbo.Lesoes", "LocalLesao_ID");
            DropColumn("dbo.Lesoes", "LadoLesao_ID");
            DropColumn("dbo.Lesoes", "Diagnostico");
            DropColumn("dbo.Lesoes", "DataLesao");
            DropTable("dbo.Tratamento");
            DropTable("dbo.Tratamento_TipoTratamento");
            DropTable("dbo.TiposTratamento");
            DropTable("dbo.TipoLesao");
            DropTable("dbo.OcorrenciaLesao");
            DropTable("dbo.LocalLesao");
            DropTable("dbo.LadoLesao");
            AddPrimaryKey("dbo.Lesoes", "ID");
        }
    }
}
