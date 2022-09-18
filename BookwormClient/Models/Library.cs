using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

//using System;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;

namespace BookwormClient.Models
{
  public class Library
  { 
    public Library()
    {
      this.JoinEntities = new HashSet<BookLibrary>();
    }

    public int LibraryId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<BookLibrary> JoinEntities { get; set; }
    
    public virtual ApplicationUser User { get; set; }
  }
}