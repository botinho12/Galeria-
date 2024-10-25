using System.ComponentModel.DataAnnotations;

namespace auebaGaleria.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da categoria é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome da categoria não pode exceder 100 caracteres.")]
        public string Nome { get; set; }

        [StringLength(250, ErrorMessage = "A descrição da categoria não pode exceder 250 caracteres.")]
        public string Descricao { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}