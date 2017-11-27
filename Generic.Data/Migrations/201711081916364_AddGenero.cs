namespace Generic.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenero : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genero",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.User", "Genero_ID", c => c.Guid());
            CreateIndex("dbo.User", "Genero_ID");
            AddForeignKey("dbo.User", "Genero_ID", "dbo.Genero", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "Genero_ID", "dbo.Genero");
            DropIndex("dbo.User", new[] { "Genero_ID" });
            DropColumn("dbo.User", "Genero_ID");
            DropTable("dbo.Genero");
        }
    }
}
