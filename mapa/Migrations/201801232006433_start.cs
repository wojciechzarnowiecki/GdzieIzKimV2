namespace mapa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class start : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.m1", "adres", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.m1", "adres");
        }
    }
}
