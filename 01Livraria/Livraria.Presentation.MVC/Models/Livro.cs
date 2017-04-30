using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria.Presentation.MVC.Models
{
    public class Livro
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Nome { get; set; }

        [Display(Name = "Categoria")]
        public int IdCategoria { get; set; }

        [Display(Name = "Autor")]
        public int IdAutor { get; set; }

        [Display(Name = "Data de Lançamento"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataLancamento { get; set; }

        [Display(Name = "Editora")]
        public int IdEditora { get; set; }

        
        [ForeignKey("IdCategoria")]
        public virtual Categoria Categoria { get; set; }

        [ForeignKey("IdAutor")]
        public virtual Autor Autor { get; set; }

        [ForeignKey("IdEditora")]
        public virtual Editora Editora { get; set; }
        
    }
}