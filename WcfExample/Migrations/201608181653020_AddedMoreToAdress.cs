namespace WcfExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMoreToAdress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContactInformations", "StreetName", c => c.String());
            AddColumn("dbo.ContactInformations", "City", c => c.String());
            AddColumn("dbo.ContactInformations", "ZipCode", c => c.String());
            AddColumn("dbo.ContactInformations", "Country", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ContactInformations", "Country");
            DropColumn("dbo.ContactInformations", "ZipCode");
            DropColumn("dbo.ContactInformations", "City");
            DropColumn("dbo.ContactInformations", "StreetName");
        }
    }
}
