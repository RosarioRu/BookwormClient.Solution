// using Microsoft.AspNetCore.Mvc.Rendering;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Mvc;
// using BookwormClient.Models;
// using System.Collections.Generic;
// using System.Linq;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Identity;
// using System.Threading.Tasks;
// using System.Security.Claims;

// namespace BookwormClient.Controllers
// {
//   public class LibrarysController : Controller
//   {
//     private readonly BookwormClientContext _db;
//     private readonly UserManager<ApplicationUser> _userManager;

//     public LibrarysController(UserManager<ApplicationUser> userManager, BookwormClientContext db)
//     {
//       _userManager = userManager;
//       _db = db;
//     }

//     public ActionResult Index()
//     {
//       return View(_db.Librarys.ToList());
//     }

//     [Authorize]
//     public ActionResult Create()
//     {
//       return View();
//     }
//     [HttpPost]
//     public ActionResult Create(Library library)
//     {
//       _db.Librarys.Add(library);
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }
  
//     public ActionResult Details(int id)
//     {
//       var thisLibrary = _db.Librarys
//         .Include(library => library.JoinEntities)
//         .ThenInclude(join => join.Book)
//         .FirstOrDefault(library => library.LibraryId == id);
//         return View(thisLibrary);
//     }

//     [Authorize]
//     public ActionResult Edit(int id)
//     {
//       var thisLibrary = _db.Librarys.FirstOrDefault(library => library.LibraryId == id);
//       ViewBag.BookId = new SelectList(_db.Books, "BookId", "Name");
//       return View(thisLibrary);
//     }

//     [HttpPost]
//     public ActionResult Edit(Library library, int BookId)
//     {
//       if (BookId != 0)
//       {
//         _db.BookLibrarys.Add(new BookLibrary() { BookId = BookId, LibraryId = library.LibraryId });
//       }
//       _db.Entry(library).State = EntityState.Modified;
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }

//     public ActionResult AddFlavor(int id)
//     {
//       var thisLibrary = _db.Librarys.FirstOrDefault(library => library.LibraryId == id);
//       ViewBag.BookId = new SelectList(_db.Books, "BookId", "Name");
//       return View(thisLibrary);
//     }

//     [HttpPost]
//     public ActionResult AddBook(Library library, int BookId)
//     {
//       if (BookId != 0)
//       {
//         _db.BookLibrary.Add(new BookLibrary() { BookId = BookId, LibraryId = library.LibraryId });
//         _db.SaveChanges();
//       }
//       return RedirectToAction("Index");
//     }

//     [Authorize]
//     public ActionResult Delete(int id)
//     {
//       var thisLibrary = _db.Librarys.FirstOrDefault(library => library.LibraryId == id);
//       return View(thisLibrary);
//     }

//     [HttpPost, ActionName("Delete")]
//     public ActionResult DeleteConfirmed(int id)
//     {
//       var thisLibrary = _db.Librarys.FirstOrDefault(libary => library.LibrartId == id);
//       _db.Librarys.Remove(thisLibrary);
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }

//   }
// }