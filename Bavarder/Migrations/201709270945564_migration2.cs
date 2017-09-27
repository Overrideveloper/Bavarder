namespace Bavarder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Website", c => c.String(unicode: false));
            AddColumn("dbo.AspNetUsers", "Bio", c => c.String(unicode: false));
            AddColumn("dbo.AspNetUsers", "Twitter", c => c.String(unicode: false));
            AddColumn("dbo.AspNetUsers", "Snapchat", c => c.String(unicode: false));
            AddColumn("dbo.AspNetUsers", "PhoneNumber", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "PhoneNumber");
            DropColumn("dbo.AspNetUsers", "Snapchat");
            DropColumn("dbo.AspNetUsers", "Twitter");
            DropColumn("dbo.AspNetUsers", "Bio");
            DropColumn("dbo.AspNetUsers", "Website");
        }
    }
}
