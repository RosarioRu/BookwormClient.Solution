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

namespace BookwormClient.Controllers
{
  // [Authorize]
  public class BooksController : Controller
  {
    private readonly BookwormClientContext _db; 
    private readonly UserManager<ApplicationUser> _userManager;

    public BooksController(UserManager<ApplicationUser> userManager, BookwormClientContext db)
    {
      _userManager = userManager; 
      _db = db; 
    }

    public async Task<ActionResult> Index()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value; 
      var currentUser = await _userManager.FindByIdAsync(userId); 
      var userBooks = _db.Books.Where(entry => entry.User.Id == currentUser.Id).ToList(); 
      return View(userBooks); 
    }

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
    //     _db.BookLibrarys.Add(new BookLibrary() {LibraryId = LibraryId, BookId = book.BookId}); 
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
  }
}
