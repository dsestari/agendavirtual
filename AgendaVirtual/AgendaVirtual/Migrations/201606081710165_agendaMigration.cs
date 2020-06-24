namespace AgendaVirtual.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agendaMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contatos",
                c => new
                    {
                        idContato = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false),
                        email = c.String(nullable: false),
                        telefone = c.String(nullable: false),
                        celular = c.String(nullable: false),
                        foto = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.idContato);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contatos");
        }
    }
}
