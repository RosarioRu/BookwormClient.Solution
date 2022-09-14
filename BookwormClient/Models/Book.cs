using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BookwormClient.Models
{
  public class Book
  {
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Category { get; set; }
    public string Summary { get; set; }
    public string Genre { get; set; }
    public string Tags { get; set; }
    public string AgeRange { get; set; } //might be a way to use a numeric data type here
    public List<string> Reviews { get; set; }

    public int Rating { get; set; } //we need a list of all ratings + average of them - 2 dimensional array? Or a list with a seperate method for averaging list?


    public static List<Book> GetBooks()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Book> BookList = JsonConvert.DeserializeObject<List<Book>>(jsonResponse.ToString());

      return BookList;
    }
}
}