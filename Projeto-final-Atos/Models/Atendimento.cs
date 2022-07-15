using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
namespace Projeto_final_Atos.Models;

public class Atendimento
{
    [Key()]
    public int IdAtendimento { get; set; }
    [ForeignKey("Usuario")]
    [Display(Name = "Id do Usuario")]
    public int idUsuario { get; set; }
    public virtual Usuario Usuario { get; set; }
    [Display(Name = "Nome")]
    public string nome { get; set; }
    [Display(Name = "E-mail")]
    public string email { get; set; }
    [Display(Name = "Duvida")]
    public string duvida { get; set; }

}
