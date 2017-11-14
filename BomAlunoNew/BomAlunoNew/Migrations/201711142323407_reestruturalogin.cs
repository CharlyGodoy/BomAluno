namespace BomAlunoNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reestruturalogin : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Logins", "Nome");
            DropColumn("dbo.Logins", "Ativo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Logins", "Ativo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Logins", "Nome", c => c.String());
        }
    }
}
