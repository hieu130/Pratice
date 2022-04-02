namespace Pratice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class coin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        baseAsset = c.String(nullable: false),
                        quoteAsset = c.String(nullable: false),
                        volumn24h = c.String(nullable: false),
                        createdAt = c.DateTime(nullable: false),
                        updatedAt = c.DateTime(nullable: false),
                        status = c.Int(nullable: false),
                        marketId_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Markets", t => t.marketId_Id, cascadeDelete: true)
                .Index(t => t.marketId_Id);
            
            CreateTable(
                "dbo.Markets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        createdAt = c.DateTime(nullable: false),
                        updatedAt = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Coins", "marketId_Id", "dbo.Markets");
            DropIndex("dbo.Coins", new[] { "marketId_Id" });
            DropTable("dbo.Markets");
            DropTable("dbo.Coins");
        }
    }
}
