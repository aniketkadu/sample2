namespace Assignment5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cties",
                c => new
                    {
                        CtyId = c.Int(nullable: false, identity: true),
                        CtyName = c.String(),
                        StateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CtyId)
                .ForeignKey("dbo.States", t => t.StateId, cascadeDelete: true)
                .Index(t => t.StateId);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        StateId = c.Int(nullable: false, identity: true),
                        StateName = c.String(),
                    })
                .PrimaryKey(t => t.StateId);
            
            CreateTable(
                "dbo.Emps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.String(nullable: false, maxLength: 10),
                        MaritalStatus = c.Boolean(nullable: false),
                        StateId = c.Int(nullable: false),
                        CtyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cties", t => t.CtyId, cascadeDelete: true)
                .Index(t => t.CtyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Emps", "CtyId", "dbo.Cties");
            DropForeignKey("dbo.Cties", "StateId", "dbo.States");
            DropIndex("dbo.Emps", new[] { "CtyId" });
            DropIndex("dbo.Cties", new[] { "StateId" });
            DropTable("dbo.Emps");
            DropTable("dbo.States");
            DropTable("dbo.Cties");
        }
    }
}
