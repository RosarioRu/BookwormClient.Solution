using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization; //might be needed for json data
// using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace BookwormClient.Models
{
 

  public class Book
  {
    [JsonProperty("bookId")]
    public int BookId { get; set; }
    [JsonProperty("title")]
    public string Title { get; set; }
    [JsonProperty("author")]
    public string Author { get; set; }
    [JsonProperty("ageRange")]
    public string AgeRange { get; set; }
    [JsonProperty("summary")]
    public string Summary { get; set; }
    [JsonProperty("genre")]
    public string Genre { get; set; }
    [JsonProperty("tags")]
    public string Tags { get; set; }
    
    // public virtual ApplicationUser User { get; set; }

    public Book()
    {
      this.JoinEntities = new HashSet<BookLibrary>();
    }

    [JsonProperty("joinEntities")]
    public virtual ICollection<BookLibrary> JoinEntities { get; set; }

    public static List<Book> GetBooks()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;
      
      // JObject jsonResponse = (JObject)JsonConvert.DeserializeObject(result);

      //JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);

      //List<Book> BookList = JsonConvert.DeserializeObject<List<Book>>(jsonResponse.ToString());

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Book> bookList = JsonConvert.DeserializeObject<List<Book>>(jsonResponse["results"].ToString());

      return bookList;
    }
  }
}