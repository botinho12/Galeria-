using System.ComponentModel.DataAnnotations;

namespace auebaGaleria.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome do produto não pode exceder 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O preço do produto é obrigatório.")]
        [Range(0.01, 10000.00, ErrorMessage = "O preço do produto deve ser entre 0.01 e 10000.")]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        [StringLength(500, ErrorMessage = "A descrição do produto não pode exceder 500 caracteres.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "A categoria é obrigatória.")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}