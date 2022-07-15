using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto_final_Atos.Data;
using Projeto_final_Atos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto_final_Atos.Models
{
    public class Usuario
    {
        [Key()]
        public int idUsuario { get; set; }
        [Required]
        [Display(Name = "Nome")]
        public string nome { get; set; }
        [Required]
        [Display(Name = "Data de Nascimento")]
        public string data_nascimento { get; set; }
        [Required]
        [Display(Name = "Senha")]
        public string senha { get; set; }
        [Display(Name = "Conta")]
        public string conta { get; set; }
    }
}