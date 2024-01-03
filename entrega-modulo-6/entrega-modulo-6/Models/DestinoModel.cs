

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace entrega_modulo6.Models
{
    public class DestinoModel
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DestinoId { get; set; }


        [Required(ErrorMessage = "Digite seu Destino corretamente! ")]
        [StringLength(200)]
        [Unicode]
        public string? NomeDestino { get; set; }

        [Required(ErrorMessage = "valor não pode ser em branco digite apenas numeros .")]
        [StringLength(200)]
        [Unicode]
        public String? Valor { get; set; }

        [Required(ErrorMessage = " EX: formatação da data 10-01-2024")]
        [StringLength(10)]
        [Unicode]
        public String? DataChegada { get; set; }

        [Required(ErrorMessage = " EX: formatação da data 10-01-2024")]
        [StringLength(10)]
        [Unicode]
        public String? DataSaida { get; set; }

        [Required(ErrorMessage = " EX: formatação da hora 12:00:00")]
        [StringLength(8)]
        [Unicode]
        public String? HoraChegada { get; set; }

       
       

     
       



    }
}

    

