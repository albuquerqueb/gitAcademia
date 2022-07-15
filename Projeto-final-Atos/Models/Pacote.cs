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
        [Display(Name = "Nome")]
        public string nome { get; set; }
        [Display(Name = "Origem")]
        public string origem { get; set; }
        [Display(Name = "Destino")]
        public string destino { get; set; }
        [Display(Name = "Saida")]
        public string saida { get; set; }
        [Display(Name = "Retorno")]
        public string retorno { get; set; }
        [Display(Name = "Preço")]
        public double preco { get; set; }

    }
}