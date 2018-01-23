namespace mapa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class start1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.m1", "dlugosc");
            DropColumn("dbo.m1", "szerokosc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.m1", "szerokosc", c => c.Double(nullable: false));
            AddColumn("dbo.m1", "dlugosc", c => c.Double(nullable: false));
        }
    }
}
