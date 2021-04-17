namespace ServiceLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClassesToBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AuthorID = c.Int(nullable: false, identity: true),
                        NickName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AuthorID);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorID = c.Int(nullable: false, identity: true),
                        NickName = c.String(),
                        Password = c.String(),
                        AboutYourself = c.String(),
                        TimeBan = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AuthorID);
            
            CreateTable(
                "dbo.BookAuthors",
                c => new
                    {
                        BookID = c.Int(nullable: false),
                        AuthorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.BookID, t.AuthorID });
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookID = c.Int(nullable: false, identity: true),
                        TextTxtPath = c.String(),
                        DescriptionTxtPath = c.String(),
                        Ban = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookID);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentID = c.Int(nullable: false, identity: true),
                        AuthorID = c.Int(nullable: false),
                        Text = c.String(),
                        BookID = c.Int(nullable: false),
                        Datetime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CommentID);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreID = c.Int(nullable: false, identity: true),
                        Genr = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GenreID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Genres");
            DropTable("dbo.Comments");
            DropTable("dbo.Books");
            DropTable("dbo.BookAuthors");
            DropTable("dbo.Authors");
            DropTable("dbo.Admins");
        }
    }
}
