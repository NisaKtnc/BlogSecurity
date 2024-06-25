using BlogSecurity.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogSecurity.Context
{
    public class BlogSecurityContext : DbContext
    {
        public BlogSecurityContext(DbContextOptions<BlogSecurityContext> options) : base(options) 
        { 

        }
        public DbSet<User> User { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Blog> Blog { get; set; }
    }
}
