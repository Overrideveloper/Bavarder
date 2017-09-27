namespace Bavarder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DateJoined", c => c.DateTime(precision: 0));
            AddColumn("dbo.AspNetUsers", "DOB", c => c.DateTime(precision: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "DOB");
            DropColumn("dbo.AspNetUsers", "DateJoined");
        }
    }
}
