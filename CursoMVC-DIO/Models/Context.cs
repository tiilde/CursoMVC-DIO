using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC_DIO.Models {
    // herda do Entity framework DbContext
    public class Context : DbContext{
        // método responsável por configurar o Entity Framework

        // tabela categorias
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

            // definindo banco de dados
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=CursoMVC_DIO;Integrated Security=True");

        }
    }
}
