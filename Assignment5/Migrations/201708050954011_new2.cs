namespace Assignment5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Emps", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Emps", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Emps", "Phone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Emps", "Phone", c => c.String());
            AlterColumn("dbo.Emps", "Email", c => c.String());
            AlterColumn("dbo.Emps", "Name", c => c.String());
        }
    }
}
