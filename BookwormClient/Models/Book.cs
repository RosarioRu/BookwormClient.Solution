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
    public list<string> Reviews { get; set; }

    public int Rating { get; set; } //we need a list of all ratings + average of them - 2 dimensional array? Or a list with a seperate method for averaging list?

    // public list<int> Ratings { get; set}

    // public static RatingAverage()
    // {
    //   //average the int(s) in list called Ratings
    //   return average;
    // }

//     int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

//     rating [[4], [3.5]]
//     first index: single rating, second index: average

//     int[] ratingArray = new int[5] {
//       1,
//       2,
//       3, 
//       4,
//       5
//     };
//     int length = ratingArray.Length; /// length = 1
//     int sum = 0;
//     int average = 0;
//     for (int i =0; i < length; i++) {
//       sum += ratingArray[i];
//     }
//     average = sum / length;
// Console.Writeline("Sum = " + sum);
// Console.Writeline("Average Of integer elements = " + average);


  }


    public static List<Book> GetBooks()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Book> BookList = JsonConvert.DeserializeObject<List<Book>>(jsonResponse.ToString());

      return BookList;
    }
  
}