namespace Bavarder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "UserPhoto", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "UserPhoto", c => c.Binary());
        }
    }
}
