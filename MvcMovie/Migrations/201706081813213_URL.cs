namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class URL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "URL Link", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.Movies", "URL Link");
        }
    }
}
