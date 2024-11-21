using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Usuario
    {
        public int UsuarioID {get; set;}
        public string? Nome {get; set;}
        public string? Email {get; set;}
        public string? Senha {get; set;}
        public int? Contato {get; set;}
        public bool? Admin {get; set;}
        public int? Status {get; set;}
    
    }
}