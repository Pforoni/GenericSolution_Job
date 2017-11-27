namespace Generic.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NomeDaMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contatos",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        FoneResidencial = c.String(),
                        FoneComercial = c.String(),
                        Celular = c.String(),
                        IsEmergencia = c.Boolean(),
                        Nome = c.String(),
                        IdUser = c.Int(),
                        Usurario_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.Usurario_ID)
                .Index(t => t.Usurario_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contatos", "Usurario_ID", "dbo.User");
            DropIndex("dbo.Contatos", new[] { "Usurario_ID" });
            DropTable("dbo.Contatos");
        }
    }
}
