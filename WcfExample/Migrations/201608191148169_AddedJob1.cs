namespace WcfExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedJob1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Jobs", "ContactInformation_Id", "dbo.ContactInformations");
            DropIndex("dbo.Jobs", new[] { "ContactInformation_Id" });
            AddColumn("dbo.Jobs", "CreatedByUserId", c => c.String());
            AddColumn("dbo.Jobs", "AssigneddCompany", c => c.String());
            AddColumn("dbo.Jobs", "AssignedCleaner", c => c.String());
            AddColumn("dbo.Jobs", "ForDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Jobs", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Jobs", "CreatedByUser_Id", c => c.Guid());
            CreateIndex("dbo.Jobs", "CreatedByUser_Id");
            AddForeignKey("dbo.Jobs", "CreatedByUser_Id", "dbo.Users", "Id");
            DropColumn("dbo.Jobs", "ContactInformationId");
            DropColumn("dbo.Jobs", "DateTime");
            DropColumn("dbo.Jobs", "IsCanceled");
            DropColumn("dbo.Jobs", "ContactInformation_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Jobs", "ContactInformation_Id", c => c.Guid());
            AddColumn("dbo.Jobs", "IsCanceled", c => c.Boolean(nullable: false));
            AddColumn("dbo.Jobs", "DateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Jobs", "ContactInformationId", c => c.String());
            DropForeignKey("dbo.Jobs", "CreatedByUser_Id", "dbo.Users");
            DropIndex("dbo.Jobs", new[] { "CreatedByUser_Id" });
            DropColumn("dbo.Jobs", "CreatedByUser_Id");
            DropColumn("dbo.Jobs", "IsDeleted");
            DropColumn("dbo.Jobs", "ForDateTime");
            DropColumn("dbo.Jobs", "AssignedCleaner");
            DropColumn("dbo.Jobs", "AssigneddCompany");
            DropColumn("dbo.Jobs", "CreatedByUserId");
            CreateIndex("dbo.Jobs", "ContactInformation_Id");
            AddForeignKey("dbo.Jobs", "ContactInformation_Id", "dbo.ContactInformations", "Id");
        }
    }
}
