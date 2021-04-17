namespace ServiceLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddComplaint : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Сomplaint",
                c => new
                    {
                        СomplaintID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        СomplaintTheme = c.String(),
                        BookID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.СomplaintID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Сomplaint");
        }
    }
}
