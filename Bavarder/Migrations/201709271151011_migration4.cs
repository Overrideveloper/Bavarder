namespace Bavarder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "EmailVisible", c => c.Boolean());
            AddColumn("dbo.AspNetUsers", "PhoneVisible", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "PhoneVisible");
            DropColumn("dbo.AspNetUsers", "EmailVisible");
        }
    }
}
