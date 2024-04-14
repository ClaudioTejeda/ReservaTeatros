namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableReservas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservas",
                c => new
                    {
                        ReservaId = c.Int(nullable: false, identity: true),
                        TeatroId = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        Teatro = c.String(nullable: false, maxLength: 120),
                        Cliente = c.String(nullable: false, maxLength: 120),
                        FechaReserva = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReservaId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId)
                .ForeignKey("dbo.Teatros", t => t.TeatroId)
                .Index(t => t.TeatroId)
                .Index(t => t.ClienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservas", "TeatroId", "dbo.Teatros");
            DropForeignKey("dbo.Reservas", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Reservas", new[] { "ClienteId" });
            DropIndex("dbo.Reservas", new[] { "TeatroId" });
            DropTable("dbo.Reservas");
        }
    }
}
