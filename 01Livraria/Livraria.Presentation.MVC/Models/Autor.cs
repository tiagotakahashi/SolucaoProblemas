using System.ComponentModel.DataAnnotations;

namespace Livraria.Presentation.MVC.Models
{
    public class Autor
    {
        public int Id { get; set; }

        [Display(Name = "Nome do Autor"), Required(AllowEmptyStrings = false)]
        public string NomeAutor { get; set; }
    }
}