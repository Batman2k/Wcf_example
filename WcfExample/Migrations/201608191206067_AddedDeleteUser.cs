namespace WcfExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDeleteUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "IsDeleted");
        }
    }
}
