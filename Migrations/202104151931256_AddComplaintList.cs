namespace ServiceLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddComplaintList : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ListСomplaint",
                c => new
                    {
                        ListСomplaintID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ListСomplaintID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ListСomplaint");
        }
    }
}
