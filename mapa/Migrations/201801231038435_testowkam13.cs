namespace mapa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testowkam13 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.m1", "x", c => c.Double(nullable: false));
            AddColumn("dbo.m1", "y", c => c.Double(nullable: false));
            AddColumn("dbo.m1", "a", c => c.String());
            AddColumn("dbo.m1", "b", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.m1", "b");
            DropColumn("dbo.m1", "a");
            DropColumn("dbo.m1", "y");
            DropColumn("dbo.m1", "x");
        }
    }
}
