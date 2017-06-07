namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Score : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Score", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Movies", "IMDBScore");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "IMDBScore", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Movies", "Score");
        }
    }
}
