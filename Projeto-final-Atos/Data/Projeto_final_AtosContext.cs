using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_final_Atos.Models;

namespace Projeto_final_Atos.Data
{
    public class Projeto_final_AtosContext : DbContext
    {
        public Projeto_final_AtosContext (DbContextOptions<Projeto_final_AtosContext> options)
            : base(options)
        {
        }

        public DbSet<Projeto_final_Atos.Models.Usuario> Usuario { get; set; } = default!;


        public DbSet<Projeto_final_Atos.Models.Atendimento>? Atendimento { get; set; }


        public DbSet<Projeto_final_Atos.Models.Pacote>? Pacote { get; set; }


        public DbSet<Projeto_final_Atos.Models.Cadastrar>? Cadastrar { get; set; }
    }
}
