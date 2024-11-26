using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Bibliotec.Models
{
    public class Usuario
    {
        public int UsuarioID {get; set;}
        public string? Nome {get; set;}
        public DateOnly? DtNascimento {get; set;}
        public string? Email {get; set;}
        public string? Senha {get; set;}
        public int? Contato {get; set;}
        public bool? Admin {get; set;}
        public bool? Status {get; set;}

        // criar um atributo
        // eu falo para este atributo que ele é uma FK
        [ForeignKey("Curso")]
        public int CursoID {get; set;}
        public Curso? Curso {get; set;}
    
    }
}