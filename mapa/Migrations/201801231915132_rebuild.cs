namespace mapa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rebuild : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.m1", "adres");
            DropColumn("dbo.m1", "x");
            DropColumn("dbo.m1", "y");
            DropColumn("dbo.m1", "a");
            DropColumn("dbo.m1", "b");
            DropTable("dbo.mapas");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.mapas",
                c => new
                    {
                        mapaId = c.Int(nullable: false, identity: true),
                        nazwa = c.String(),
                        dlugosc = c.Double(nullable: false),
                        szerokosc = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.mapaId);
            
            AddColumn("dbo.m1", "b", c => c.String());
            AddColumn("dbo.m1", "a", c => c.String());
            AddColumn("dbo.m1", "y", c => c.Double(nullable: false));
            AddColumn("dbo.m1", "x", c => c.Double(nullable: false));
            AddColumn("dbo.m1", "adres", c => c.String());
        }
    }
}
