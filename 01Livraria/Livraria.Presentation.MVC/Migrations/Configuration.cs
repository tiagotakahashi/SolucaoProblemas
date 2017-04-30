namespace Livraria.Presentation.MVC.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Models.Contexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Models.Contexto context)
        {            
            context.Categoria.AddOrUpdate(
              p => p.Id,
              new Models.Categoria { Id = 1, DescricaoCategoria = "Administração"     },
              new Models.Categoria { Id = 2, DescricaoCategoria = "Arte e Fotografia" },
              new Models.Categoria { Id = 3, DescricaoCategoria = "Ciências"          },
              new Models.Categoria { Id = 4, DescricaoCategoria = "Direito"           },
              new Models.Categoria { Id = 5, DescricaoCategoria = "Ficção"            },
              new Models.Categoria { Id = 6, DescricaoCategoria = "Infantil"          },
              new Models.Categoria { Id = 7, DescricaoCategoria = "Tecnologia"        }
            );

            context.Autor.AddOrUpdate(
              p => p.Id,
              new Models.Autor { Id = 1, NomeAutor = "Manuel Bandeira"  },
              new Models.Autor { Id = 2, NomeAutor = "Carlos Drummond"  },
              new Models.Autor { Id = 3, NomeAutor = "Francis Alys"     },
              new Models.Autor { Id = 4, NomeAutor = "Carlos Lebeis"    },
              new Models.Autor { Id = 5, NomeAutor = "Ruy Castro"       },
              new Models.Autor { Id = 6, NomeAutor = "Vicente de Mello" },
              new Models.Autor { Id = 7, NomeAutor = "Willian Kennedy"  }
            );

            context.Editora.AddOrUpdate(
              p => p.Id,
              new Models.Editora { Id = 1, NomeEditora = "Abril"  },
              new Models.Editora { Id = 2, NomeEditora = "Mello"  },
              new Models.Editora { Id = 3, NomeEditora = "Lebeis" },
              new Models.Editora { Id = 4, NomeEditora = "Loyola" }
            );

            context.Livro.AddOrUpdate(
              p => p.Id,
              new Models.Livro { Id = 1, Nome = "Criatividade S/A"    , IdAutor = 1, IdCategoria = 1, IdEditora = 1, DataLancamento = System.DateTime.Today.AddDays(-300) },
              new Models.Livro { Id = 2, Nome = "A Chácara da Rua Um" , IdAutor = 2, IdCategoria = 2, IdEditora = 2, DataLancamento = System.DateTime.Today.AddDays(-286) },
              new Models.Livro { Id = 3, Nome = "Numa Dada Situação"  , IdAutor = 3, IdCategoria = 3, IdEditora = 3, DataLancamento = System.DateTime.Today.AddDays(-120) },
              new Models.Livro { Id = 4, Nome = "Deuses Americanos"   , IdAutor = 4, IdCategoria = 4, IdEditora = 1, DataLancamento = System.DateTime.Today.AddDays(-350) },
              new Models.Livro { Id = 4, Nome = "Parallaxis"          , IdAutor = 5, IdCategoria = 5, IdEditora = 4, DataLancamento = System.DateTime.Today.AddDays(-400) }
            );

        }
    }
}
