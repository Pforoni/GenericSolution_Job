namespace Generic.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInstituicao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Instituicao",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.User", "Instituicao_ID", c => c.Guid());
            CreateIndex("dbo.User", "Instituicao_ID");
            AddForeignKey("dbo.User", "Instituicao_ID", "dbo.Instituicao", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "Instituicao_ID", "dbo.Instituicao");
            DropIndex("dbo.User", new[] { "Instituicao_ID" });
            DropColumn("dbo.User", "Instituicao_ID");
            DropTable("dbo.Instituicao");
        }
    }
}
