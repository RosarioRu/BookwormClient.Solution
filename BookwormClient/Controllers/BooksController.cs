using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BookwormClient.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using System; 

namespace BookwormClient.Controllers
{
  public class BooksController : Controller
  {

    public IActionResult Index()
    {
      var allBooks = Book.GetBooks();
      return View(allBooks);
    }
    
    

    // public async Task<ActionResult> Index()
    // {
    //   var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value; 
    //   var currentUser = await _userManager.FindByIdAsync(userId); 
    //   var userBooks = _db.Books.Where(entry => entry.User.Id == currentUser.Id).ToList(); 
    //   return View(userBooks); 
    // }

    // [Authorize]
    // public ActionResult Create()
    // {
    //   return View(); 
    // }

    // [HttpPost]
    // public async Task<ActionResult> Create(Book book, int LibraryId)
    // {
    //   var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value; 
    //   var currentUser = await _userManager.FindByIdAsync(userId); 
    //   book.User = currentUser; 
    //   _db.Books.Add(book); 
    //   _db.SaveChanges(); 
    //   if (LibraryId != 0)
    //   {
    //     _db.BookLibrary.Add(new BookLibrary() {LibraryId = LibraryId, BookId = book.BookId}); 
    //   }
    //   _db.SaveChanges(); 
    //   return RedirectToAction("Index");
    // }

    // public async Task<ActionResult> Details(int id)
    // {
    //   var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value; 
    //   var currentUser = await _userManager.FindByIdAsync(userId);
    //   Book thisBook = _db.Books.FirstOrDefault(book => book.BookId == id); 
    //   return View(thisBook); 
    // }

    // [Authorize]
    // public ActionResult Edit(int id)
    // {
    //   var thisBook = _db.Books.FirstOrDefault(book => book.BookId == id); 
    //   return View(thisBook); 
    // }

    // [Authorize]
    // [HttpPost]
    // public ActionResult Edit(Book book)
    // {
    //   _db.Entry(book).State = EntityState.Modified; 
    //   _db.SaveChanges(); 
    //   return RedirectToAction("Index"); 
    // }

    // public ActionResult Delete(int id)
    // {
    //   var thisBook = _db.Books.FirstOrDefault(book => book.BookId == id);
    //   return View(thisBook); 
    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   var thisBook = _db.Books.FirstOrDefault(book => book.BookId == id);
    //   _db.Books.Remove(thisBook); 
    //   _db.SaveChanges(); 
    //   return RedirectToAction("Index"); 
    // }

    // public ActionResult AddLibrary(int id)
    // {
    //   var thisBook = _db.Books.FirstOrDefault(book => book.BookId == id); 
    //   ViewBag.LibraryId = new SelectList(_db.Librarys, "LibraryId", "Name"); 
    //   return View(thisBook); 
    // }

    // [HttpPost]
    // public ActionResult AddLibrary(Book book, int LibraryId)
    // {
    //   if (LibraryId != 0)
    //   {
    //     _db.BookLibrary.Add(new BookLibrary() { LibraryId = LibraryId, BookId = book.BookId}); 
    //     _db.SaveChanges(); 
    //   }
    //   return RedirectToAction("Index");
    // }
  }
}
