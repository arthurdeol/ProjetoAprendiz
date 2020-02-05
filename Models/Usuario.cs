using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario {get;set;}
        public string Nome {get;set;}
        public string Idade { get; set; }
        public string Instrumento {get;set;}
        public string Bairro { get; set; }
        public string Email { get; set; }
        public string Fone { get; set; }
        public bool PossuiInstrumento { get; set; }
    }
}