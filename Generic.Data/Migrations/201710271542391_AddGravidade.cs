namespace Generic.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGravidade : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Gravidade",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Lesoes",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Gravidade_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Gravidade", t => t.Gravidade_ID)
                .Index(t => t.Gravidade_ID);
            
            DropColumn("dbo.Contatos", "IdUser");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contatos", "IdUser", c => c.Int());
            DropForeignKey("dbo.Lesoes", "Gravidade_ID", "dbo.Gravidade");
            DropIndex("dbo.Lesoes", new[] { "Gravidade_ID" });
            DropTable("dbo.Lesoes");
            DropTable("dbo.Gravidade");
        }
    }
}
