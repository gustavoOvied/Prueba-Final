using ApiNoticias.Models;
using Microsoft.AspNetCore.Mvc;
using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ApiNoticias.Noticias_Clima
{
    public class ApiNoticias
    {
        public IEnumerable<PostNews> GetNoticias(string ciudad)
        {

            var newsApiClient = new NewsApiClient("ca561ca1e9f74ffab5a4c73222ff0ea7");
            var articlesResponse = newsApiClient.GetTopHeadlines(new TopHeadlinesRequest
            {
                Q = ciudad
            });

            List<PostNews> noti = new List<PostNews>();

            if (articlesResponse.Status == Statuses.Ok)
            {
                // here's the first 20
                foreach (var article in articlesResponse.Articles)
                {
                    new PostNews
                    {
                        title = article.Title,
                        author = article.Author,
                        description = article.Description,
                        url = article.Url
                    };
                }
            }
            return noti;

        }

    }
}
