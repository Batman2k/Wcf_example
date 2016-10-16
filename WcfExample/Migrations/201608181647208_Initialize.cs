namespace WcfExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        HasRut = c.Boolean(nullable: false),
                        Description = c.String(),
                        UserId = c.String(),
                        Owner_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Owner_Id)
                .Index(t => t.Owner_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserName = c.String(),
                        Password = c.String(),
                        AccountType = c.Int(nullable: false),
                        ContactInformationId = c.String(),
                        ContactInformation_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ContactInformations", t => t.ContactInformation_Id)
                .Index(t => t.ContactInformation_Id);
            
            CreateTable(
                "dbo.ContactInformations",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        EmailAdress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Companies", "Owner_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "ContactInformation_Id", "dbo.ContactInformations");
            DropIndex("dbo.Users", new[] { "ContactInformation_Id" });
            DropIndex("dbo.Companies", new[] { "Owner_Id" });
            DropTable("dbo.ContactInformations");
            DropTable("dbo.Users");
            DropTable("dbo.Companies");
        }
    }
}
