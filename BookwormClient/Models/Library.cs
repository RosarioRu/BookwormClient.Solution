using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization; //might be needed for json data



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
    
    public static List<Library> GetLibrarys()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      List<Library> receivedLibraries = JsonConvert.DeserializeObject<List<Library>>(result);

      // JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      // List<Library> libraryList = JsonConvert.DeserializeObject<List<Library>>(jsonResponse["results"].ToString());

      

      // JObject jsonResponse = JObject.Parse(result);
      // JArray jsonAsArray = (JArray)jsonResponse["results"];
        
      //   List<Library> libraryList = new List<Library>();  

      // foreach (JObject item in jsonAsArray) // <-- Note that here we used JObject instead of usual JProperty
      // {
        

      //   var convertedJObject = (Library)JsonConvert.DeserializeObject(item, typeof(Libary));
        
        // var convertedJObject = JsonConvert.DeserializeObject<Library>(item);
        // Library currentLibrary = item.GetValue("library").ToString();
      //   libraryList.Add(convertedJObject);

      // }
      
      //IList<Library> libraryList = jsonAsArray.ToObject<IList<Library>>();

      //List<Library> libraryList = jsonAsArray["results"].ToObject<List<Library>>();

      //List<Library> libraryList = JsonConvert.DeserializeObject<List<Library>>(jsonAsArray["results"].ToString());


      // JObject o = JObject.Parse(json);
      // JArray a = (JArray)o["d"];
      // IList<Person> person = a.ToObject<IList<Person>>();

      return receivedLibraries;
    }
    // public virtual ApplicationUser User { get; set; }
  }
}