using System.Runtime.InteropServices;
using System.Xml;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entrega_modulo6.Models
{
    [Table("Usuarios")]
    public class UsuarioModel
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioId { get; set; }

        
        public string? Nome { get; set; }

        public string? Cpf { get; set; }

        public string? Email { get; set; }

        public string? Celular { get; set; }
       
        public string? Senha { get; set; }

        public string? Genero { get; set; }

        public List<DestinoModel>? Destinos { get; set; }
    }

  

}