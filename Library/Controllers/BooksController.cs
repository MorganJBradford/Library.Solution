using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using Library.Models;

namespace Library.Controllers
{
  public class BooksController : Controller
  {
    private readonly LibraryContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public BooksController(UserManager<ApplicationUser> userManager, LibraryContext db)
    {
      _userManager - userManager;
      _db = db;
    }
    public ActionResult Index()
    {
      List<Book> model = _db.Books.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.AuthorId = new SelectList(_db.Authors, "AuthorId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Book book, int AuthorId)
    {
      _db.Books.Add(book);
      _db.SaveChanges();
      if (AuthorId != 0)
      {
        _db.AuthorBook.Add(new AuthorBook() { AuthorId = AuthorId, BookId = book.BookId })
      }
      return RedirectToAction("Index");
    }
  }
}