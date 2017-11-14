namespace BomAlunoNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class estrutura : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Atividades",
                c => new
                    {
                        AtividadeID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Data = c.DateTime(nullable: false),
                        Descricao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        TipoID = c.Int(nullable: false),
                        Materia_MateriaID = c.Int(),
                    })
                .PrimaryKey(t => t.AtividadeID)
                .ForeignKey("dbo.Tipoes", t => t.TipoID, cascadeDelete: true)
                .ForeignKey("dbo.Materias", t => t.Materia_MateriaID)
                .Index(t => t.TipoID)
                .Index(t => t.Materia_MateriaID);
            
            CreateTable(
                "dbo.Tipoes",
                c => new
                    {
                        TipoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TipoID);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        LoginID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Usuario = c.String(),
                        Senha = c.String(),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.LoginID);
            
            CreateTable(
                "dbo.Materias",
                c => new
                    {
                        MateriaID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        AtividadeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MateriaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Atividades", "Materia_MateriaID", "dbo.Materias");
            DropForeignKey("dbo.Atividades", "TipoID", "dbo.Tipoes");
            DropIndex("dbo.Atividades", new[] { "Materia_MateriaID" });
            DropIndex("dbo.Atividades", new[] { "TipoID" });
            DropTable("dbo.Materias");
            DropTable("dbo.Logins");
            DropTable("dbo.Tipoes");
            DropTable("dbo.Atividades");
        }
    }
}
