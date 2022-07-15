using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto_final_Atos.Data;
using Projeto_final_Atos.Models;

namespace Projeto_final_Atos.Models
{

    public class Pacote
    {
        [Key()]
        public int idPacotes { get; set; }
        [ForeignKey("Atendimento")]
        [Display(Name = "Id do Atendimento")]
        public int idAtendimento { get; set; }
        public virtual Atendimento Atendimento { get; set; }
        public string nome { get; set; }
        public string origem { get; set; }
        public string destino { get; set; }
        public string saida { get; set; }
        public string retorno { get; set; }
        public double preco { get; set; }

    }
}