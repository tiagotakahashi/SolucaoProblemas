namespace Livraria.Presentation.MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeAutor = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DescricaoCategoria = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Editora",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeEditora = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Livro",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        IdCategoria = c.Int(nullable: false),
                        IdAutor = c.Int(nullable: false),
                        DataLancamento = c.DateTime(nullable: false),
                        IdEditora = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Autor", t => t.IdAutor, cascadeDelete: true)
                .ForeignKey("dbo.Categoria", t => t.IdCategoria, cascadeDelete: true)
                .ForeignKey("dbo.Editora", t => t.IdEditora, cascadeDelete: true)
                .Index(t => t.IdCategoria)
                .Index(t => t.IdAutor)
                .Index(t => t.IdEditora);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Livro", "IdEditora", "dbo.Editora");
            DropForeignKey("dbo.Livro", "IdCategoria", "dbo.Categoria");
            DropForeignKey("dbo.Livro", "IdAutor", "dbo.Autor");
            DropIndex("dbo.Livro", new[] { "IdEditora" });
            DropIndex("dbo.Livro", new[] { "IdAutor" });
            DropIndex("dbo.Livro", new[] { "IdCategoria" });
            DropTable("dbo.Livro");
            DropTable("dbo.Editora");
            DropTable("dbo.Categoria");
            DropTable("dbo.Autor");
        }
    }
}
