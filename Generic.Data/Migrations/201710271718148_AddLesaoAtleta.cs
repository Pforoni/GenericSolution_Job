namespace Generic.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLesaoAtleta : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lesoes", "AthleteUser_ID", c => c.Guid());
            CreateIndex("dbo.Lesoes", "AthleteUser_ID");
            AddForeignKey("dbo.Lesoes", "AthleteUser_ID", "dbo.AthleteUser", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lesoes", "AthleteUser_ID", "dbo.AthleteUser");
            DropIndex("dbo.Lesoes", new[] { "AthleteUser_ID" });
            DropColumn("dbo.Lesoes", "AthleteUser_ID");
        }
    }
}
