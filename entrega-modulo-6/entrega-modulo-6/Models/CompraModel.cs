using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entrega_modulo6.Models
{
    [Table("Compras")]
    public class CompraModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompraId { get; set; }


        public string? Descricao { get; set; }

        public decimal? Valor { get; set; }

        public int UsuarioId { get; set; }
        public  UsuarioModel? Usuario { get; set; }

        public int DestinoId { get; set; }
        public  DestinoModel? Destino { get; set; }


    }
}
