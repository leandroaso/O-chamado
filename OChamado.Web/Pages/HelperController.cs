using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OChamado.API.Models;

namespace OChamado.Web.Pages
{
    [Produces("application/json")]
    [Route("api/Helper")]
    public class HelperController : Controller
    {
        private string UrlBase => "http://localhost:53520/api/";

        [HttpPost]
        [Route("Atend-Cadastro")]
        public async Task<IActionResult> Post([FromBody] AtendimentoVO atendimentoVo)
        {
            using (var client = new HttpClient())

            {
                var content = new StringContent(JsonConvert.SerializeObject(atendimentoVo), Encoding.UTF8, "application/json");
                var url = $"{UrlBase}Atendimento/cadastro";

                var result = client.PostAsync(url, content).Result;
                if (result.IsSuccessStatusCode)
                    return Created(string.Empty, atendimentoVo);
            }

            return BadRequest();
        }

        [HttpPost]
        [Route("Atend-Salvar")]
        public async Task<IActionResult> Salvar([FromBody] AtendimentoVO atendimentoVo)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(atendimentoVo), Encoding.UTF8, "application/json");
                var url = $"{UrlBase}Atendimento/Salvar";

                var result = client.PostAsync(url, content).Result;
                if (result.IsSuccessStatusCode)
                    return Ok(atendimentoVo);
            }

            return BadRequest();
        }

        [HttpPost]
        [Route("Atend-Finalizar")]
        public async Task<IActionResult> Finalizar([FromBody] AtendimentoVO atendimentoVo)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(atendimentoVo), Encoding.UTF8, "application/json");
                var url = $"{UrlBase}Atendimento/Finalizar";

                var result = client.PostAsync(url, content).Result;
                if (result.IsSuccessStatusCode)
                    return Ok(atendimentoVo);
            }

            return BadRequest();
        }
    }
}