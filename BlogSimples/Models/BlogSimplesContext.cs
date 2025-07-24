using Microsoft.EntityFrameworkCore;

namespace BlogSimples.Models
{
    public class BlogSimplesContext : DbContext
    {
        public BlogSimplesContext(DbContextOptions<BlogSimplesContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Post { get; set; }
    }
}
