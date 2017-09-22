using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace poc.UtilizandoSwagger.Models
{
     /// <summary>
        /// 
        /// </summary>
        public sealed class Article
        {
            ///<summary>
            /// Id do artigo
            /// </summary>
            [Required]
            [DefaultValue(Math.PI)]
            public int Id { get; set; }


            ///<summary>
            /// Titulo do artigo
            /// </summary>
            [Required]
            public string Title { get; set; }


            /// <summary>
            /// Descrição do artigo
            /// </summary>
            [Required]
            public string Description { get; set; }


            ///<summary>
            /// Data de publicação
            /// </summary>
            public DateTime DatePublish { get; set; }


            ///<summary>
            /// Nome do autor
            /// </summary>
            public string Author { get; set; }


            /// <summary>
            /// Url da imagem do artigo
            /// </summary>
            public string ImageUrl { get; set; }
        }
    }
