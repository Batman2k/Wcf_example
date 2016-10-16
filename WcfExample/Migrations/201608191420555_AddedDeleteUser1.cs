namespace WcfExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDeleteUser1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jobs", "AssignedCompany", c => c.String());
            DropColumn("dbo.Jobs", "AssigneddCompany");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Jobs", "AssigneddCompany", c => c.String());
            DropColumn("dbo.Jobs", "AssignedCompany");
        }
    }
}
