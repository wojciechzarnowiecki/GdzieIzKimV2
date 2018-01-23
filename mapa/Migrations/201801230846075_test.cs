namespace mapa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.mapas");
        }
    }
}
