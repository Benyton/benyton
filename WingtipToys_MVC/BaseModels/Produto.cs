using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseModels
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        [Required]
        [StringLength(20)]
        public string Nome { get; set; }
        
        public string Descricao { get; set; }

        [Required]
        public string Ativo { get; set; }

        // -- Relacionamento Categoria --> Produto
        [ForeignKey("_Categoria")]
        public int CategoriaID { get; set; }

        public virtual Categoria _Categoria { get; set; }
    }
}
