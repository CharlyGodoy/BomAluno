namespace BomAlunoNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atividade : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Materias", "LoginID", c => c.Int(nullable: false));
            CreateIndex("dbo.Materias", "LoginID");
            AddForeignKey("dbo.Materias", "LoginID", "dbo.Logins", "LoginID", cascadeDelete: true);
            DropColumn("dbo.Logins", "Nome");
            DropColumn("dbo.Logins", "Ativo");
            DropColumn("dbo.Materias", "AtividadeID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Materias", "AtividadeID", c => c.Int(nullable: false));
            AddColumn("dbo.Logins", "Ativo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Logins", "Nome", c => c.String());
            DropForeignKey("dbo.Materias", "LoginID", "dbo.Logins");
            DropIndex("dbo.Materias", new[] { "LoginID" });
            DropColumn("dbo.Materias", "LoginID");
        }
    }
}
