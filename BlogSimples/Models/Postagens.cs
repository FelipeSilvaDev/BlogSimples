using System.Collections.Generic;

namespace BlogSimples.Models
{
    public class Postagens
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Postagens()
        {
        }

        public Postagens(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
