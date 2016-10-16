namespace WcfExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDeleteOnCompany : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "IsDeleted");
        }
    }
}
