﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OChamado.Web.Pages
{
    public class FuncionarioModel : PageModel
    {
        public void OnGet()
        {
            ViewData["NomeUsuario"] = "Irineu Funcionario";
        }
    }
}