using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using OChamado.API.Models;

namespace OChamado.Web.Pages
{
    public class ClienteModel : PageModel
    {
        private string UrlBase => "http://localhost:53520/api/";
        public IList<Atendimento> Atendimentos { get; set; }

        public async Task<IActionResult> OnGet()
        {
            //if (string.IsNullOrWhiteSpace(UsuarioLogado.Nome))
            //    return RedirectToPage("Index");

            ViewData["NomeUsuario"] = "Cliente";
            using (var client = new HttpClient())
            {
                var result = await client.GetStringAsync($"{UrlBase}Atendimento/lista");
                Atendimentos = JsonConvert.DeserializeObject<IList<Atendimento>>(result);
            }
            return Page();
        }

    }
}