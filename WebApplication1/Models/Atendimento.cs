﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
namespace WebApplication1.Models
{
    public class Atendimento
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string duvida { get; set; }

    }
}