using Microsoft.EntityFrameworkCore;

namespace EFCore.Entities
{
    public class EFCoreDbContext : DbContext
    {

        public EFCoreDbContext ()
        {
          
        }
            public DbSet<Post> Posts { get; set; }
            public DbSet<Category> Categories { get; set; }
            public DbSet<Comment> Comments { get; set; }
    }
}