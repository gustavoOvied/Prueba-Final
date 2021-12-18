using ApiNoticias.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiNoticias.Noticias_Clima
{
    public class ApiClima
    {
        public async Task<WeatherResponse> GetTiempo([FromRoute] string ciudad)
        {

            using (var client = new HttpClient())
            {
                var result = await client.GetAsync($"api.openweathermap.org/data/2.5/weather?q={ciudad}&appid=c7e8e81c3c442c74b2238270d4b5e7b1");
                var weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(await result.Content.ReadAsStringAsync());

                return weatherResponse;
            }
        }

    }
}
