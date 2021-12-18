using ApiNoticias.Context;
using ApiNoticias.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiNoticias.Controllers
{
    [ApiController]
    [Route("api/noticas")]

    public class resultApisController : ControllerBase
    {
        private readonly newsWeatherDBContext _ctx;

        public resultApisController()
        {
        }

        public resultApisController(newsWeatherDBContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet("{ciudad}")]
        public IActionResult GetNoticias(string ciudad)
        {
            var getNoti = new Noticias_Clima.ApiNoticias();

            return Ok(getNoti.GetNoticias(ciudad));
        }


        [HttpGet("clima/{ciudad}")]
        public IActionResult callNoticia(string ciudad)
        {
            var getClima = new Noticias_Clima.ApiClima();

            return Ok(getClima.GetTiempo(ciudad));
        }

        [HttpPost]
        public async Task<ActionResult<HistoryDB>> postHistoryItem (HistoryDB item)
        {
            _ctx.History.Add(item);
            await _ctx.SaveChangesAsync();

            return CreatedAtAction(nameof(callNoticia), new { ciudad = item.id }, item);
        }
    }
}
