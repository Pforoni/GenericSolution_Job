namespace Generic.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddContatos : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Contatos");
            AlterColumn("dbo.User", "Username", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.User", "Email", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.User", "HashedPassword", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.User", "Salt", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.User", "CPF", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.User", "RG", c => c.String(maxLength: 10));
            AlterColumn("dbo.User", "Naturalidade", c => c.String(maxLength: 30));
            AlterColumn("dbo.Contatos", "ID", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.Contatos", "FoneResidencial", c => c.String(maxLength: 15));
            AlterColumn("dbo.Contatos", "FoneComercial", c => c.String(maxLength: 15));
            AlterColumn("dbo.Contatos", "Celular", c => c.String(maxLength: 15));
            AlterColumn("dbo.Contatos", "Nome", c => c.String(maxLength: 50));
            AddPrimaryKey("dbo.Contatos", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Contatos");
            AlterColumn("dbo.Contatos", "Nome", c => c.String());
            AlterColumn("dbo.Contatos", "Celular", c => c.String());
            AlterColumn("dbo.Contatos", "FoneComercial", c => c.String());
            AlterColumn("dbo.Contatos", "FoneResidencial", c => c.String());
            AlterColumn("dbo.Contatos", "ID", c => c.Guid(nullable: false));
            AlterColumn("dbo.User", "Naturalidade", c => c.String());
            AlterColumn("dbo.User", "RG", c => c.String());
            AlterColumn("dbo.User", "CPF", c => c.String());
            AlterColumn("dbo.User", "Salt", c => c.String());
            AlterColumn("dbo.User", "HashedPassword", c => c.String());
            AlterColumn("dbo.User", "Email", c => c.String());
            AlterColumn("dbo.User", "Username", c => c.String());
            AddPrimaryKey("dbo.Contatos", "ID");
        }
    }
}
