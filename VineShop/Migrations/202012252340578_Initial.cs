namespace VineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                        YearOfProduction = c.Int(nullable: false),
                        Image = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        TypeId = c.Int(nullable: false),
                        SweetnessId = c.Int(nullable: false),
                        BrandId = c.Int(nullable: false),
                        SizeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .ForeignKey("dbo.Sizes", t => t.SizeId, cascadeDelete: true)
                .ForeignKey("dbo.Sweetnesses", t => t.SweetnessId, cascadeDelete: true)
                .ForeignKey("dbo.Types", t => t.TypeId, cascadeDelete: true)
                .Index(t => t.TypeId)
                .Index(t => t.SweetnessId)
                .Index(t => t.BrandId)
                .Index(t => t.SizeId);
            
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        VineId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Vines", t => t.VineId, cascadeDelete: true)
                .Index(t => t.VineId);
            
            CreateTable(
                "dbo.Sizes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sweetnesses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 20),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Vines", "TypeId", "dbo.Types");
            DropForeignKey("dbo.Vines", "SweetnessId", "dbo.Sweetnesses");
            DropForeignKey("dbo.Vines", "SizeId", "dbo.Sizes");
            DropForeignKey("dbo.Carts", "VineId", "dbo.Vines");
            DropForeignKey("dbo.Vines", "BrandId", "dbo.Brands");
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Carts", new[] { "VineId" });
            DropIndex("dbo.Vines", new[] { "SizeId" });
            DropIndex("dbo.Vines", new[] { "BrandId" });
            DropIndex("dbo.Vines", new[] { "SweetnessId" });
            DropIndex("dbo.Vines", new[] { "TypeId" });
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
            DropTable("dbo.Types");
            DropTable("dbo.Sweetnesses");
            DropTable("dbo.Sizes");
            DropTable("dbo.Carts");
            DropTable("dbo.Vines");
            DropTable("dbo.Brands");
        }
    }
}
