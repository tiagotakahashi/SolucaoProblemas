using System.ComponentModel.DataAnnotations;

namespace Livraria.Presentation.MVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Display(Name = "Descrição da categoria"), Required(AllowEmptyStrings = false)]
        public string DescricaoCategoria { get; set; }
    }
}