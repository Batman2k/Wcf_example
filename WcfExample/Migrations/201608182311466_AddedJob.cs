namespace WcfExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedJob : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ContactInformationId = c.String(),
                        Created = c.DateTime(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        Confrimed = c.DateTime(nullable: false),
                        IsCanceled = c.Boolean(nullable: false),
                        ContactInformation_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ContactInformations", t => t.ContactInformation_Id)
                .Index(t => t.ContactInformation_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jobs", "ContactInformation_Id", "dbo.ContactInformations");
            DropIndex("dbo.Jobs", new[] { "ContactInformation_Id" });
            DropTable("dbo.Jobs");
        }
    }
}
