using Microsoft.EntityFrameworkCore;

namespace BookwormClient.Models
{
  public class BookLibrary
  {       
    public int BookLibraryId { get; set; }
    public int BookId { get; set; }
    public int LibraryId { get; set; }
    public virtual Book Book { get; set; }
    public virtual Library Library { get; set; }
  }
}