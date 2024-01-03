using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using System.Text.Json.Serialization;

namespace entrega_modulo6.Models
{
    [Table("Compras")]
    public class CompraModel 
        
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompraId { get; set; }

        [Required(ErrorMessage = "Digite corretamente sua descrição! ")]
        [StringLength(110)]
        [Unicode]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "Compra invalida digite o valor  corretamente! ")]
        [StringLength(110)]
        [Unicode]
        public String? ValorCompra { get; set; }


     

        [JsonIgnore]
        public  DestinoModel? Destino { get; set; }


    }
}
