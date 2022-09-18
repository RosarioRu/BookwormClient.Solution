using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookwormClient.Models
{
    public class BookwormClientContext : IdentityDbContext<ApplicationUser>
    {
      public DbSet<Book> Books { get; set; }
      public DbSet<Library> Librarys { get; set; }
      public DbSet<BookLibrary> BookLibrary { get; set; }
      public BookwormClientContext(DbContextOptions options) : base(options) { }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}