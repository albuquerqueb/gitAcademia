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
        public string nome { get; set; }
        [Required]
        public string data_nascimento { get; set; }
        [Required]
        public string senha { get; set; }
        public string conta { get; set; }
        public string login { get; set; }
    }
}