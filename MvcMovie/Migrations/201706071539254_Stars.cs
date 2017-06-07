namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stars : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Stars", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Stars");
        }
    }
}
