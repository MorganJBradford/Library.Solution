using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Library.Models;
using System.Collections.Generic;
using System.Linq;

namespace Library.Controllers
{
  public class HomeController : Controller
  {
    private readonly LibraryContext _db;
    private List<SelectListItem> _selectList;
    public HomeController(LibraryContext db)
    {
      _db = db;
      _selectList = new List<SelectListItem>()
      {
        new SelectListItem {Text = "All", Value = "All"},
        new SelectListItem {Text = "Author", Value = "Author"},
        new SelectListItem {Text = "Book", Value = "Book"}
      };
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    public ActionResult Search()
    {
      ViewBag.Category = _selectList;
      return View();
    }
    [HttpPost]
    public ActionResult Search(string category, string searchEntry)
    {
      ViewBag.Category = _selectList;
      List<Author> authorSearch = new List<Author>{};
      List<Book> bookSearch = new List<Book>{};
      if(category != "Book")
      {
        authorSearch = _db.Authors.Where(Author => Author.Name.Contains(searchEntry)).ToList();
      }
      if(category!="Author")
      {
        bookSearch = _db.Books.Where(Book => Book.Title.Contains(searchEntry)).ToList();
      }
      Dictionary<string,object> model = new Dictionary<string, object>();
      model.Add("AuthorResults",authorSearch);
      model.Add("BookResults",bookSearch);
      return View(model);
    }
  }
}