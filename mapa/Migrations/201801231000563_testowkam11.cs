namespace mapa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testowkam11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.m1",
                c => new
                    {
                        m1Id = c.Int(nullable: false, identity: true),
                        nazwa = c.String(),
                        dlugosc = c.Double(nullable: false),
                        szerokosc = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.m1Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.m1");
        }
    }
}
