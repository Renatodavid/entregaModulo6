
using entrega_modulo6.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace entrega_modulo6.Models
{   
    public class DestinoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DestinoId { get; set; }


        public string? NomeDestino { get; set; }

        public decimal? Valor { get; set; }

        public DateTime? DataChegada { get; set; }

        public DateTime? DataSaida { get; set; }

        public DateTime? HoraChegada { get; set; }
        public StatusCompra? Status { get; set; }

        public int UsuarioId { get; set; }
        public UsuarioModel? Usuarios { get; set; }

        public int CompraId { get; set; }
        public List<CompraModel>? Compras { get; set; }
    }
    
}
