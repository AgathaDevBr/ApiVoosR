using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiVoos.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoosController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var url = "https://dev.reserve.com.br/airapi/gol/getavailability?origin=Rio%20de%20Janeiro&destination=S%C3%A3o%20Paulo&date=2024-06-20";
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();
                        dynamic json = JObject.Parse(jsonString);

                        // Processar o JSON dinâmico aqui
                        // Exemplo: acessando uma lista de objetos
                        var companhias = new List<dynamic>(json.Companhias);

                        // Aqui você pode fazer qualquer operação necessária com os dados
                        // Por exemplo, retornar as companhias como resultado
                        return Ok(companhias);
                    }
                    else
                    {
                        return StatusCode((int)response.StatusCode, "Erro ao obter os dados do servidor.");
                    }
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Erro interno: {e.Message}");
            }
        }
    }
}
