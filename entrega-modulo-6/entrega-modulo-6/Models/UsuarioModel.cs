using System.Runtime.InteropServices;
using System.Xml;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace entrega_modulo6.Models
{
    [Table("Usuarios")]
    public class UsuarioModel 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioId { get; set; }

        [Required]
        [StringLength(200)]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Digite seu CPF corretamente! ")]
        [StringLength(11)]
        [Unicode]
        public string? Cpf { get; set; }

        [Required(ErrorMessage = "Digite seu E-mail")]
        [StringLength(200)]
        [Unicode]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Digite o seu número de celular!")]
        [StringLength(12)]
        [Unicode]
        public string? Celular { get; set; }

        public string? Genero { get; set; }

        [Required(ErrorMessage = "The Senha field is required.")]
        public string? Senha { get; set; }

     
        public List<DestinoModel>? Destinos { get; set; }

     
    }

}

