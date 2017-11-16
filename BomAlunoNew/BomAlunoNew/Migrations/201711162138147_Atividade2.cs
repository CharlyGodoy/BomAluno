namespace BomAlunoNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atividade2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Atividades", "Materia_MateriaID", "dbo.Materias");
            DropIndex("dbo.Atividades", new[] { "Materia_MateriaID" });
            RenameColumn(table: "dbo.Atividades", name: "Materia_MateriaID", newName: "MateriaID");
            AlterColumn("dbo.Atividades", "MateriaID", c => c.Int(nullable: false));
            CreateIndex("dbo.Atividades", "MateriaID");
            AddForeignKey("dbo.Atividades", "MateriaID", "dbo.Materias", "MateriaID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Atividades", "MateriaID", "dbo.Materias");
            DropIndex("dbo.Atividades", new[] { "MateriaID" });
            AlterColumn("dbo.Atividades", "MateriaID", c => c.Int());
            RenameColumn(table: "dbo.Atividades", name: "MateriaID", newName: "Materia_MateriaID");
            CreateIndex("dbo.Atividades", "Materia_MateriaID");
            AddForeignKey("dbo.Atividades", "Materia_MateriaID", "dbo.Materias", "MateriaID");
        }
    }
}
