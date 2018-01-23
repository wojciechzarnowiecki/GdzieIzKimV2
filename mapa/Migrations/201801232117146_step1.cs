namespace mapa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class step1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kats",
                c => new
                    {
                        KatId = c.Int(nullable: false, identity: true),
                        NazwaKat = c.String(),
                        OpisKat = c.String(),
                    })
                .PrimaryKey(t => t.KatId);
            
            AddColumn("dbo.m1", "Kat_KatId", c => c.Int());
            CreateIndex("dbo.m1", "Kat_KatId");
            AddForeignKey("dbo.m1", "Kat_KatId", "dbo.Kats", "KatId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.m1", "Kat_KatId", "dbo.Kats");
            DropIndex("dbo.m1", new[] { "Kat_KatId" });
            DropColumn("dbo.m1", "Kat_KatId");
            DropTable("dbo.Kats");
        }
    }
}
