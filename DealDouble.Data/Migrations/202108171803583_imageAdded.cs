namespace DealDouble.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imageAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AuctionImages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ImageID = c.Int(nullable: false),
                        AuctionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Images", t => t.ImageID, cascadeDelete: true)
                .ForeignKey("dbo.Auctions", t => t.AuctionID, cascadeDelete: true)
                .Index(t => t.ImageID)
                .Index(t => t.AuctionID);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        URL = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropColumn("dbo.Auctions", "PictureURL");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Auctions", "PictureURL", c => c.String());
            DropForeignKey("dbo.AuctionImages", "AuctionID", "dbo.Auctions");
            DropForeignKey("dbo.AuctionImages", "ImageID", "dbo.Images");
            DropIndex("dbo.AuctionImages", new[] { "AuctionID" });
            DropIndex("dbo.AuctionImages", new[] { "ImageID" });
            DropTable("dbo.Images");
            DropTable("dbo.AuctionImages");
        }
    }
}
