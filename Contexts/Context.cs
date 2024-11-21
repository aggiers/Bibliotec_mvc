using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bibliotec.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Bibliotec.Contexts
{
    // classe que terá as informações do banco de dados
    public class Context : DbContext
    {
        // criar um método construtor
        public Context(){
        }
        public Context(DbContextOptions<Context> options) : base 
        (options){
        }
        // OnConfiguring -> possui a configuração da conexao com
        // o banco de dados

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            // colocar as informações do banco

            // as configurações existem?

            if(!optionsBuilder .IsConfigured){
                //string de conexão do banco de dados:
                // data Source => Nome do servidor do banco de dados
                // User Id e Password => Informações de acesso ao servidor do banco de dados

                optionsBuilder.UseSqlServer(@"Data Source=NOTE16-S28\\SQLEXPRESS; 
                Initial Catalog =  Bibliotec_mvc; User Id=sa; Password=123; Integrated 
                Security=true; TrustServerCertificate = true");
            }
        }

        // as referencias das nossas tabelas no banco de dados:

        // Categoria
        public DbSet<Categoria> Categoria {get; set;}
        // Curso
        public DbSet<Curso> Curso {get; set;}
        // Livro
        public DbSet<Livro> Livro {get; set;}
        // Usuario
        public DbSet<Usuario> Usuario {get; set;}
        // LivroCategoria
        public DbSet<LivroCategoria> LivroCategoria {get; set;}
        // LivroReserva
        public DbSet<LivroReserva> LivroReserva {get; set;}

        
    }
}