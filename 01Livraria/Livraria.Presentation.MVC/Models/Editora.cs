using System.ComponentModel.DataAnnotations;

namespace Livraria.Presentation.MVC.Models
{
    public class Editora
    {
        public int Id { get; set; }

        [Display(Name = "Nome da Editora"), Required(AllowEmptyStrings = false)]
        public string NomeEditora { get; set; }
    }
}