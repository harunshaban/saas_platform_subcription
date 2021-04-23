namespace saas_platform_subcription.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sub01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        subName = c.String(),
                        vat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subs");
        }
    }
}
