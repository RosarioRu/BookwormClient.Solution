using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookwormClient.Models
{
<<<<<<< HEAD
  public class BookwormClientContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Book> Books { get; set; }
    public DbSet<Library> Librarys { get; set; }
    public DbSet<BookLibrary> BookLibrary { get; set; }

    public BookwormClientContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      //optionsBuilder.UseLazyLoadingProxies();
    }
  }
=======
    public class BookwormClientContext : IdentityDbContext<ApplicationUser>
    {
      // Don't change code in here.
    }
>>>>>>> a386147d402209de782c47775d94dc599db81891
}