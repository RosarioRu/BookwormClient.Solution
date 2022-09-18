using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace BookwormClient.Models
{
  public class BookwormClientContextFactory : IDesignTimeDbContextFactory<BookwormClientContext>
  {

    BookwormClientContext IDesignTimeDbContextFactory<BookwormClientContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<BookwormClientContext>();

      // DbContextOptionsBuilder<BookwormClientContext> builder = new DbContextOptionsBuilder<BookwormClientContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new BookwormClientContext(builder.Options);
    }
  }
}

