using System;
using System.ComponentModel.DataAnnotations;

namespace BlogSimples.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        [Required]
        public string Conteudo { get; set; }

        public DateTime DataPublicacao { get; set; } = DateTime.Now;
    }
}
