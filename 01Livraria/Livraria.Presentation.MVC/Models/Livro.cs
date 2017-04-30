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

        [Display(Name = "Categoria"), Required]
        public int IdCategoria { get; set; }

        [Display(Name = "Autor"), Required]
        public int IdAutor { get; set; }

        [Display(Name = "Data de Lançamento"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}"), Required]
        public DateTime DataLancamento { get; set; }

        [Display(Name = "Editora"), Required]
        public int IdEditora { get; set; }

        
        [ForeignKey("IdCategoria")]
        public virtual Categoria Categoria { get; set; }

        [ForeignKey("IdAutor")]
        public virtual Autor Autor { get; set; }

        [ForeignKey("IdEditora")]
        public virtual Editora Editora { get; set; }
        
    }
}