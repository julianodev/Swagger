using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using poc.UtilizandoSwagger.Models;

namespace poc.UtilizandoSwagger.Controllers
{
    /// <inheritdoc />
    /// <summary>
    /// Article Controller
    /// </summary>
    public class ArticleController : ApiController
    {
        /// <summary>
        /// Lista de artigos do blog
        /// </summary>
        /// <remarks>Lista de artigos do blog</remarks>
        public IEnumerable<Article> Get()
        {
            return GetArticles();
        }

        /// <summary>
        /// Retorna um artigo especifico
        /// </summary>
        ///<param name="id">Informe um numero inteiro</param>
        /// <response code="200">OK</response>
        /// <response code="500">Internal Server Error</response>
        public Article Get(int id)
        {
            var articles = GetArticles();
            return articles.FirstOrDefault(x => x.Id == id);
        }


        /// <summary>
        /// Criar um novo artigo
        /// </summary>
        /// <param name="article">Preencha os campos corretamente para conseguir criar um artigo</param>
        /// <returns>Será criado um novo objeto do tipo artigo</returns>
        /// <response code="200">Artigo criado com sucesso</response>
        /// <response code="500">Preencha os campos corretamente</response> 
        /// <response code="400">Ocorreu um erro interno no servidor</response>   
        [HttpPost]
        public IHttpActionResult Post([FromBody] Article article)
        {
            if (article == null)
            {
                return BadRequest();
            }

            return Ok(article);
        }


        /// <summary>
        /// Atualização do artigo
        /// </summary>
        /// <param name="id"></param>
        /// <param name="article"></param>
        /// <returns></returns>
        public IHttpActionResult Put(int id, [FromBody] Article article)
        {

            //TODO

            return Ok(new
            {
                success = true,
                mensagem = $"Artigo {article.Title} atualizado com sucesso"
            });
        }


        /// <summary>
        /// Excluir um artigo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult Delete(int id)
        {
            var article = GetArticles().FirstOrDefault(x => x.Id == id);

            if (article == null)
                return NotFound();

            GetArticles().Remove(article);

            return Ok(new
            {
                success = true,
                mensagem = $"Artigo {article.Title} apagado com sucesso em {DateTime.Now}"
            });
        }


        private static IList<Article> GetArticles()
        {
            return new List<Article>
            {
                new Article
                {
                    Id = 1,
                    Title = "Injeção de Dependência: A Redenção do Simple Injector",
                    Description = "Neste artigo mostrarei a usabilidade, facilidade e performance do gerenciador de container Simple Injector para turbinar sua Dependência de Injeção nas plataformas MVC e Web API.",
                    DatePublish = DateTime.Now,
                    Author = "Fabio Silva",
                    ImageUrl = "https://www.fabiosilvalima.net/wp-content/uploads/2017/07/fabiosilvalima-dependencia-de-injecao-simple-injector-4-300x150.png"
                },
                new Article
                {
                    Id = 2,
                    Title = "Injeção de Dependência: A Redenção do Simple Injector",
                    Description = "Neste artigo mostrarei a usabilidade, facilidade e performance do gerenciador de container Simple Injector para turbinar sua Dependência de Injeção nas plataformas MVC e Web API.",
                    DatePublish = DateTime.Now,
                    Author = "Fabio Silva",
                    ImageUrl = "https://www.fabiosilvalima.net/wp-content/uploads/2017/07/fabiosilvalima-dependencia-de-injecao-simple-injector-4-300x150.png"
                },
                new Article
                {
                    Id = 3,
                    Title = "Injeção de Dependência: A Redenção do Simple Injector",
                    Description = "Neste artigo mostrarei a usabilidade, facilidade e performance do gerenciador de container Simple Injector para turbinar sua Dependência de Injeção nas plataformas MVC e Web API.",
                    DatePublish = DateTime.Now,
                    Author = "Fabio Silva",
                    ImageUrl = "https://www.fabiosilvalima.net/wp-content/uploads/2017/07/fabiosilvalima-dependencia-de-injecao-simple-injector-4-300x150.png"
                },
                new Article
                {
                    Id = 4,
                    Title = "Injeção de Dependência: A Redenção do Simple Injector",
                    Description = "Neste artigo mostrarei a usabilidade, facilidade e performance do gerenciador de container Simple Injector para turbinar sua Dependência de Injeção nas plataformas MVC e Web API.",
                    DatePublish = DateTime.Now,
                    Author = "Fabio Silva",
                    ImageUrl = "https://www.fabiosilvalima.net/wp-content/uploads/2017/07/fabiosilvalima-dependencia-de-injecao-simple-injector-4-300x150.png"
                }

            };
        }
    }
}
